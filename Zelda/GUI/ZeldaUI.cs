using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;

namespace Zelda
{
    public partial class ZeldaUI : Form
    {
        internal static Settings settings;
        internal static string TooltipDir {
            get { return string.IsNullOrEmpty(settings?.TooltipFolder) ? JRiverAPI.TooltipFolder : settings.TooltipFolder.TrimEnd('\\'); } }

        State state;
        JRiverAPI jrAPI;
        JRPlaylist currentPlaylist;
        JRFile currentFile;
        double latency = -1;
        int latencyChecks = 0;
        bool paused = false;
        bool loading;
        int lastResize = 0;
        bool initialized = false;
        bool LinkedFieldsEnabled = false;

        public Dictionary<JRFile, DataRow> rowIndex = new Dictionary<JRFile, DataRow>();
        ExpressionTab currentTab { get { return tabsLeft.SelectedTab as ExpressionTab; } }
        List<ExpressionTab> expressionTabs { get { return tabsLeft.TabPages.Cast<ExpressionTab>().ToList(); } }

        #region form init

        public ZeldaUI()
        {
            InitializeComponent();

            settings = Settings.Load();
            state = State.Load();

            Icon = Properties.Resources.ZeldaIcon;
            this.Text = $"ZELDA v{Program.version.ToString(3)}";
            lblZoom.Visible = false;

            gridFiles.DoubleBuffered(true);
            gridFiles.Columns.Clear();

            tabsLeft.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabsLeft.TabPages.Clear();
            txtOutput.Margins[1].Width = 10;             // remove default margin
            SetOutputStyle();

            toolStrip1.Renderer = new ToolstripRenderer(Color.PowderBlue);      // renderer to apply a backcolor on Checked toolstrip buttons
            showFunctionHelper(false);

            comboLists.DrawMode = DrawMode.OwnerDrawFixed;
            comboLists.DrawItem += drawCombobox;
        }

        private void ZeldaUI_Load(object sender, EventArgs e)
        {
            if (!Connect(true))
                Close();
            else
            {
                GetPlayLists();
                initialized = true;
                LoadState();
                UpdateLinkedTabs();
            }
        }

        void LoadState()
        {
            tabsLeft.SuspendLayout();
            if (settings.SaveExpressions && state.Tabs.Count > 0)
            {
                int current = state.CurrentTab;
                foreach (var exp in state.Tabs)
                {
                    // recover linked field if State was re-saved by an older version
                    if (string.IsNullOrEmpty(exp.linkedField) && Regex.IsMatch(exp.name, @"🔗 \[.+\]$"))
                        exp.linkedField = exp.name.Substring(exp.name.IndexOf('[')+1).TrimEnd(']');
                    AddExpressionTab(exp.name, exp.content, exp.position, exp.linkedField);
                }
                tabsLeft.SelectedIndex = current;
            }
            else
                tabsLeft.SelectedTab = AddExpressionTab();

            if (settings.SaveState)
            {
                chkWhitespace.Checked = state.Whitespace;
                chkWrap.Checked = state.LineWrap;
                tabsRight.SelectedIndex = state.OutputTab;
                showFunctionHelper(state.FunctionHelper);
                txtOutput.Zoom = state.Zoom;        // triggers zoom change on expression tabs too

                // restore size and position, ensure visibility
                var desktop = SystemInformation.VirtualScreen;
                if (state.Dimensions != Rectangle.Empty && state.Dimensions.Right > 300 && state.Dimensions.X < desktop.Width - 300
                    && state.Dimensions.Y >= 0 && state.Dimensions.Y < desktop.Height - 300)
                    DesktopBounds = state.Dimensions;

                if (state.Maximized)
                    WindowState = FormWindowState.Maximized;

                if (state.SplitPosition > 0)
                    splitContainer1.SplitterDistance = state.SplitPosition;
            }
            resizeGridColumns();
            tabsLeft.ResumeLayout();
        }

        private void SetOutputStyle()
        {
            txtOutput.Styles[Style.Default].Font = settings.OutputFont.family;
            txtOutput.Styles[Style.Default].Bold = settings.OutputFont.isBold;
            txtOutput.Styles[Style.Default].Italic = settings.OutputFont.isItalic;
            txtOutput.Styles[Style.Default].SizeF = settings.OutputFont.size;
            txtOutput.Styles[Style.Default].ForeColor = settings.OutputFont.ForeColor;
            txtOutput.Styles[Style.Default].BackColor = settings.OutputFont.BackColor;
            txtOutput.StyleClearAll();
            // scintillaNET bugs
            txtOutput.CaretLineVisible = false;
            txtOutput.CaretStyle = CaretStyle.Invisible;
        }

        private void ZeldaUI_Shown(object sender, EventArgs e)
        {
            // scintillaNET bugs
            txtOutput.CaretLineVisible = false;
            txtOutput.CaretStyle = CaretStyle.Invisible;
            txtOutput.Focus();

            tabsLeft.SelectedIndex = state.CurrentTab == -1 ? 0 : state.CurrentTab;
            currentTab?.Invalidate();
            currentTab?.scintilla.Focus();
            if (settings.isDefault)
                btnAbout_Click(null, EventArgs.Empty);

            Task.Run(() =>
            {
                if (AutoUpgrade.CheckUpgrade(true))
                    UpgradeAvailable(AutoUpgrade.LatestVersion);
            });
        }

        void UpgradeAvailable(VersionInfo ver)
        {
            if (this.InvokeRequired)
                Invoke(new MethodInvoker(() => UpgradeAvailable(ver)));
            else
            {
                lblUpgrade.Text = $"ZELDA v{ver.version} is now available - click to upgrade";
                lblUpgrade.Visible = true;
                lblStatus.Visible = false;
            }
        }

        private void ZeldaUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            jrAPI?.Disconnect();
            if (initialized && state != null)
            {
                state.Tabs = new List<TabExpression>();
                foreach (var tab in expressionTabs)
                    state.Tabs.Add(new TabExpression(tab.Text, tab.scintilla.Text, tab.scintilla.CurrentPosition, tab.linkedField));

                state.Maximized = WindowState == FormWindowState.Maximized;
                state.Dimensions = state.Maximized ? RestoreBounds : DesktopBounds;
                state.SplitPosition = splitContainer1.SplitterDistance;

                state.Save();
            }
        }

        #endregion

        #region JRiver connect

        private bool Connect(bool isStartup = false)
        {
            while (true)
            {
                string password = OSProtect.Unprotect(settings.MCWSPassword);
                jrAPI = settings.UseMCWS ? new JRiverAPI(settings.MCWSServer, settings.MCWSUsername, password) : new JRiverAPI();

                var progressUI = new ProgressUI("Connecting to MediaCenter...", ConnectJRiver, false);
                if (isStartup)
                    progressUI.StartPosition = FormStartPosition.CenterScreen;

                progressUI.ShowDialog(this);
                progressUI.Close();

                if (jrAPI.Connected)
                    break;

                string method = settings.UseMCWS ? "MCWS" : "Automation";
                if (DialogResult.No == MessageBox.Show($"Cannot connect to MediaCenter ({method})!\nDo you want to open the Connection Settings?",
                    "Failed to Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                    return false;

                ShowSettings(out _);
            }

            if (jrAPI.Playlists.Count == 0)
            {
                string filtered = !string.IsNullOrEmpty(settings.PlaylistFilter) ? "\nPlease check the Playlist Filter in settings." : "";
                MessageBox.Show($"Failed to load list of Playlists from MediaCenter!{filtered}", "No playlists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblStatus.Text = $"Connected to MediaCenter v{jrAPI.MCVersion} - {jrAPI.Library} ({jrAPI.Server})";
            lblReadOnly.Visible = jrAPI.ReadOnly;

            return jrAPI.Connected;
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {
            if (Connect())
            {
                GetPlayLists();
                UpdateLinkedTabs();
            }
            else
                Close();
        }

        private void UpdateLinkedTabs()
        {
            foreach (ExpressionTab tab in tabsLeft.TabPages)
                if (tab.isLinkedTab)
                {
                    var field = jrAPI.Fields.FirstOrDefault(f => f.Name.ToLower() == tab.linkedField.ToLower());
                    tab.SetSavedExpression(field?.Expression);
                }
            
            tabsLeft.Invalidate();
            tabsLeft_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private bool GetPlayLists(bool startup = false)
        {
            LinkedFieldsEnabled = false;

            if (!jrAPI.Connected)
                return false;

            LinkedFieldsEnabled = settings.UseMCWS && new Version(jrAPI.MCVersion) >= new Version(32, 0, 17);

            // update datagrid column/field list
            loading = true;
            List<string> columns = new List<string>();
            foreach (var f in state.TableFields)
                if (jrAPI.FieldDisplayNames.Contains(f, StringComparer.InvariantCultureIgnoreCase))
                    columns.Add(f);
            state.TableFields = columns;

            // load current playlist files
            comboLists.DataSource = jrAPI.Playlists.OrderBy(p => p.Path).ThenBy(p => p.ToString()).ToList();
            JRPlaylist list = null;
            if (currentPlaylist != null)
                list = jrAPI.Playlists.Where(p => p.Name == currentPlaylist.Name).FirstOrDefault();
            if (startup && settings.ReloadPlaylist && state.Playlist != null)
                list = jrAPI.Playlists.Where(p => p.Name == state.Playlist).FirstOrDefault();
            if (list == null) list = jrAPI.Playlists.Where(p => p.Name == "Recently Played").FirstOrDefault();
            if (list == null) list = jrAPI.Playlists.FirstOrDefault();

            loading = false;
            comboLists.SelectedItem = list;

            return true;
        }

        private void ConnectJRiver(ProgressInfo progress)
        {
            progress.result = false;
            progress.subtitle = "Starting MediaCenter";
            progress.Update(true);
            if (!jrAPI.Connect())
                return;

            progress.subtitle = "Reading fields";
            progress.Update();
            jrAPI.getFields();

            // syntax highlighter
            foreach (var tab in expressionTabs)
                tab.highlighter = new ELSyntax(jrAPI.FieldsHighlight, settings.ExtraFunctions);

            progress.subtitle = "Reading playlists";
            progress.Update(true);
            jrAPI.getPlaylists(settings.PlaylistFilter, !settings.FastStart).ToList();

            progress.result = true;
        }

        private void LoadPlaylist(JRPlaylist list, ProgressUI progress = null)
        {
            if (progress == null)
                progress = new ProgressUI($"Loading playlist '{list.Name}'", LoadPlaylist, false, list);
            progress.ShowDialog(this);

            LoadDataTable();
        }

        private void LoadPlaylist(ProgressInfo progress)
        {
            JRPlaylist pl = progress.args[0] as JRPlaylist;
            pl.Files = new List<JRFile>();
            progress.totalItems = pl.Count;
            int i = 0;

            List<string> fields = new List<string>();

            try
            {
                foreach (var f in state.TableFields)
                    if (jrAPI.FieldMap.TryGetValue(f.ToLower(), out string name))
                        fields.Add(name);

                foreach (var file in jrAPI.getFiles(pl, fields))
                {
                    pl.Files.Add(file);
                    progress.currentItem = ++i;
                    progress.subtitle = $"{file.Name} ({file.Year})";
                    progress.Update(false);
                }
            }
            catch (Exception ex) { Logger.Log(ex); }
        }

        // draw colored tab headers
        private void tabsLeft_DrawItem(object sender, DrawItemEventArgs e)
        {
            ExpressionTab tab = tabsLeft.TabPages[e.Index] as ExpressionTab;

            e.DrawBackground();
            bool selected = e.State == DrawItemState.Selected;

            Color back = selected ? SystemColors.ControlLightLight : SystemColors.Control;
            Color fore = tab.isLinkedTab ? (tab.isSaved ? Color.Green : Color.Red) : Color.Black;

            using (Brush br = new SolidBrush(back))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                if (selected)
                    e.Graphics.DrawLine(new Pen(Color.Orange, 2), e.Bounds.Left + 4, e.Bounds.Top + 3, e.Bounds.Right - 3, e.Bounds.Top + 3);

                TextRenderer.DrawText(e.Graphics, tab.Text, e.Font, e.Bounds, fore, back);
                e.DrawFocusRectangle();
            }
        }

        // adds playlist filecount to each combobox entry
        private void drawCombobox(object cmb, DrawItemEventArgs args)
        {
            args.DrawBackground();
            if (args.Index < 0) return;

            JRPlaylist item = (JRPlaylist)this.comboLists.Items[args.Index];

            Rectangle r1 = args.Bounds;
            r1.Width = r1.Width - 40;
            using (SolidBrush sb = new SolidBrush(args.ForeColor))
            {
                args.Graphics.DrawString(item.FullName, args.Font, sb, r1);
            }

            bool isSlow = item.Count == -2;
            if (item.Count >= 0 || isSlow)
            {
                string txt = isSlow ? "slow!" : item.Count.ToString();
                SizeF size = args.Graphics.MeasureString(txt, args.Font);
                Rectangle r2 = args.Bounds;
                r2.X = args.Bounds.Width - (int)size.Width - 1;
                r2.Width = (int)size.Width + 1;

                Color color = isSlow ? Color.Red : Color.DarkCyan;
                using (SolidBrush sb = new SolidBrush(args.State.HasFlag(DrawItemState.Selected) ? Color.White : color))
                {
                    args.Graphics.DrawString(txt, args.Font, sb, r2);
                }
            }
        }

        private void comboLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            currentPlaylist = comboLists.SelectedItem as JRPlaylist;
            state.Playlist = currentPlaylist?.Name;
            if (currentPlaylist != null)
            {
                //if (currentPlaylist.Files == null)
                LoadPlaylist(currentPlaylist);
            }

            var files = currentPlaylist?.Files.OrderBy(f => f.ToString()).ToList();
            comboFiles.DataSource = files;
            if (files == null || files.Count == 0)
                currentFile = null;
            else
                comboFiles.SelectedIndex = 0;
        }

        private void comboFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFile = comboFiles.SelectedItem as JRFile;
            //if (currentFile != null)
            //    Text = $"ZELDA - {currentFile.Name} ({currentFile.Year})";
            //else
            //    Text = $"ZELDA";

            foreach (var tab in expressionTabs)
                tab.Evaluate(currentFile);
        }

        #endregion

        private ExpressionTab AddExpressionTab(string name = null, string content = null, int pos = -1, string linkedField = null)
        {
            if (name == null)
            {
                // find free name
                int n = tabsLeft.TabCount + 1;
                string[] names = expressionTabs.Select(t => t.Text).ToArray();
                while (names.Contains($"expr{n}")) n++;
                name = $"expr{n}";
            }

            var tab = new ExpressionTab(name, settings);
            tab.highlighter = new ELSyntax(jrAPI.FieldsHighlight, settings.ExtraFunctions);
            tab.jrAPI = jrAPI;
            tab.Paused = paused;
            tab.ZoomChanged += expression_ZoomChanged;
            tab.ExpressionChanged += expression_TextChanged;
            tab.FunctionChanged += expression_FunctionChanged;
            tab.NeedsSavingChanged += (sender, saved) => { if (((ExpressionTab)sender).isLinkedTab) tabsLeft.Invalidate(); };
            tab.linkedField = linkedField;

            if (content != null)
                tab.SetContent(content);

            if (pos >= 0) tab.scintilla.GotoPosition(pos);
            tabsLeft.TabPages.Add(tab);

            DataTable dt = gridFiles.DataSource as DataTable;
            if (dt != null)
            {
                dt.Columns.Add(tab.ID);
                gridFiles.Columns[tab.ID].HeaderText = tab.Text;
                gridFiles.Columns[tab.ID].SortMode = DataGridViewColumnSortMode.NotSortable;
                reorderDatagridColumns();
            }

            tabsLeft.SelectedTab = tab;
            tab.scintilla.WrapMode = chkWrap.Checked ? WrapMode.Word : WrapMode.None;
            tab.scintilla.ViewWhitespace = chkWhitespace.Checked ? WhitespaceMode.VisibleAlways : WhitespaceMode.Invisible;
            tab.scintilla.ViewEol = chkWhitespace.Checked;
            tab.scintilla.EmptyUndoBuffer();
            tab.scintilla.Focus();
            tab.Evaluate(currentFile);
            return tab;
        }

        private void expression_FunctionChanged(object sender, ELToken e)
        {
            if (splitContainer3.Panel2Collapsed) return;
            if ((sender as ExpressionTab) != currentTab) return;
            string name = e == null ? null : e.function == ELFunctions.Unknown ? null : e.function.ToString();
            var func = name == null ? null : ELConstants.ELFunctionWiki.Where(f => f.function.ToLower() == name.ToLower()).FirstOrDefault();
            LoadWiki(name ?? e?.text, func);
        }

        void LoadWiki(string name, ELFunction func)
        {
            if (wikiBrowser.IsBusy)
                wikiBrowser.Stop();
            if (name == null)
                wikiBrowser.DocumentText = $"no function highlighted";
            else if (string.IsNullOrEmpty(func?.wikiUrl))
                wikiBrowser.DocumentText = $"<b>{name}():</b> Wiki not available for this function";
            else
                wikiBrowser.Navigate(func?.wikiUrl);
        }

        void reorderDatagridColumns()
        {
            int order = 1;
            foreach (var et in expressionTabs)
                gridFiles.Columns[et.ID].DisplayIndex = order++;
        }

        double getAPILatency()
        {
            try
            {
                long max = int.MaxValue;
                long min = 0;
                long sum = 0;
                latency = -1;
                Stopwatch sw = new Stopwatch();
                for (int i = 0; i < 10; i++)
                {
                    sw.Restart();
                    string value = jrAPI.resolveExpression(currentFile, " ");
                    sw.Stop();
                    sum += sw.ElapsedTicks;
                    if (sw.ElapsedTicks < max) max = sw.ElapsedTicks;
                    if (sw.ElapsedTicks > min) min = sw.ElapsedTicks;
                    if (TimeSpan.FromTicks(sum).TotalMilliseconds > 1000)
                    {
                        latency = 0;
                        break;
                    }
                }

                if (latency != 0)
                    latency = TimeSpan.FromTicks(sum / 10).TotalMilliseconds;
            }
            catch { }
            lblLatency.Text = (latency > 0) ? $"{latency:0.00} ms" : "???";
            return latency;
        }

        void ShowResults()
        {
            if (currentTab == null) return;
            lblCalltime.Text = $"{currentTab.APItime:0.00} ms";
            if (currentTab.APItime > 0 && currentTab.APItime < latency)
            {
                latency = currentTab.APItime;
                lblLatency.Text = $"{latency:0.00} ms";
            }
            LoadDocument(currentTab.Result ?? "evaluation error");
        }

        #region HTML Renderer

        private void LoadDocument(string text)
        {
            txtOutput.ReadOnly = false;
            txtOutput.Text = text;
            txtOutput.ReadOnly = true;

            string html = getHTML(text);
            //htmlOutput.Text = html;

            if (renderBrowser.IsBusy)
            {
                renderBrowser.Stop();
                Application.DoEvents();
            }
            renderBrowser.DocumentText = html;
        }

        string fixFont(string expression)
        {
            string text = expression;
            try
            {
                text = text.Replace("</font>", "</span>");
                Regex re = new Regex("<font(.+?)>", RegexOptions.IgnoreCase);
                Match m = re.Match(text);
                int pos = 0;
                while (m.Success)
                {
                    ELFont font = ELFont.Parse(m.Value);
                    string html = font.ToHTML();

                    text = text.Remove(m.Index, m.Length);
                    text = text.Insert(m.Index, html);

                    pos = m.Index + html.Length;
                    m = re.Match(text, pos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return text;
        }

        string fixImg(string text)
        {
            // <img src="C:\Jiver\tooltip album artwork\wvy.png" size="379x100">,

            Regex re = new Regex("<img(.+?)>", RegexOptions.IgnoreCase);
            Match m = re.Match(text);
            int pos = 0;
            while (m.Success)
            {
                ELImg img = ELImg.Parse(m.Groups[1].Value);
                string html = img.ToHTML();

                text = text.Remove(m.Index, m.Length);
                text = text.Insert(m.Index, html);

                pos = m.Index + html.Length;
                m = re.Match(text, pos);
            }
            return text;
        }

        string fixWhitespace(string text)
        {
            Regex r1 = new Regex("</?(font|img|b|i|u|br)(>|\\s.*?>)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            StringBuilder sb = new StringBuilder();

            int pos = 0;
            while (pos < text.Length)
            {
                Match m = r1.Match(text, pos);
                if (m.Success)
                {
                    sb.Append(fixEntities(text.Substring(pos, m.Index - pos)));
                    sb.Append(m.ToString());
                    pos = m.Index + m.Length;
                }
                else
                {
                    sb.Append(fixEntities(text.Substring(pos)));
                    break;
                }
            }
            return sb.ToString();
        }

        string fixEntities(string text)
        {
            text = Regex.Replace(text, "  ", "&nbsp;&nbsp;");
            text = Regex.Replace(text, "<", "&lt;");
            text = Regex.Replace(text, ">", "&gt;");
            return text;
        }

        string getHTML(string text)
        {
            text = fixWhitespace(text);
            text = text.Replace("\n", "<br>\n");
            text = fixFont(text);
            text = fixImg(text);

            StringBuilder sb = new StringBuilder();
            string css = getCSS();
            sb.AppendLine($"<!DOCTYPE html><html>"
                + $"<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />"
                + $"<head><style>\n{css}\n</style></head><body>");

            sb.Append(text);
            sb.AppendLine("</body></html>");

            return sb.ToString();
        }

        private string getCSS()
        {
            CustomFont cFont = settings.RenderFont;
            string fontStyle = ((cFont.isItalic ? "italic " : "") + (cFont.isBold ? "bold " : "")).Trim();

            return $@"body {{
  margin: 10px; padding: 0;
  background-color: #{cFont.bgcolor}; color: #{cFont.fgcolor};
  font: {fontStyle} {cFont.size}pt {cFont.family}, Segoe UI, Verdana, Arial, Helvetica, sans-serif
}} ";
        }

        #endregion

        #region form buttons

        private bool ShowSettings(out bool connectionChanged)
        {
            var settingsUI = new SettingsUI(settings);
            connectionChanged = false;
            if (DialogResult.OK == settingsUI.ShowDialog(this))
            {
                settings.Save();
                connectionChanged = settingsUI.ConnectionOptionsChanged;
                return true;
            }
            return false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (ShowSettings(out bool reconnect))
            {
                if (reconnect)
                    btnReconnect_Click(null, EventArgs.Empty);

                SetOutputStyle();
                if (!paused)
                    currentTab?.Evaluate(true);
                ShowResults();

                foreach (var tab in expressionTabs)
                    tab.Config(settings);
                if (gridFiles.Columns["API"] != null)
                    gridFiles.Columns["API"].Visible = settings.ShowAPICallTime;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutUI().ShowDialog(this);
        }

        private void btnPrevFile_Click(object sender, EventArgs e)
        {
            if (comboFiles.SelectedIndex > 0) comboFiles.SelectedIndex--;
        }

        private void tabsLeft_DoubleClick(object sender, EventArgs e)
        {
            currentTab?.Rename();
            gridFiles.Columns[currentTab.ID].HeaderText = currentTab.Text;
        }

        private void btnNextFile_Click(object sender, EventArgs e)
        {
            if (comboFiles.SelectedIndex < comboFiles.Items.Count - 1) comboFiles.SelectedIndex++;
        }

        #endregion

        #region toolbar buttons


        private void btnNew_Click(object sender, EventArgs e)
        {
            AddExpressionTab();
        }

        private void btnAutorun_Click(object sender, EventArgs e)
        {
            paused = !paused;
            btnAutorun.Image = paused ? Properties.Resources.Stop16 : Properties.Resources.Play16;

            foreach (var tab in expressionTabs)
            {
                tab.Paused = paused;
                if (!paused)
                {
                    tab.Evaluate(true);
                    if (tab != currentTab) UpdateDatagrid(tab, tab.scintilla.Text);
                }
            }
        }

        private void btnWrap_CheckedChanged(object sender, EventArgs e)
        {
            state.LineWrap = chkWrap.Checked;
            txtOutput.WrapMode = chkWrap.Checked ? WrapMode.Word : WrapMode.None;

            foreach (var tab in expressionTabs)
                tab.scintilla.WrapMode = chkWrap.Checked ? WrapMode.Word : WrapMode.None;
        }

        private void btnWhitespace_CheckedChanged(object sender, EventArgs e)
        {
            state.Whitespace = chkWhitespace.Checked;
            foreach (var tab in expressionTabs)
            {
                tab.scintilla.ViewWhitespace = chkWhitespace.Checked ? WhitespaceMode.VisibleAlways : WhitespaceMode.Invisible;
                tab.scintilla.ViewEol = chkWhitespace.Checked;
            }
        }

        private void btnZoomUp_Click(object sender, EventArgs e)
        {
            if (txtOutput.Zoom < 20)
                txtOutput.Zoom++;       // triggers zoom change on all exprssion tabs
        }

        private void btnZoomDown_Click(object sender, EventArgs e)
        {
            if (txtOutput.Zoom > -5)
                txtOutput.Zoom--;       // triggers zoom change on all exprssion tabs
        }

        private void expression_ZoomChanged(object sender, int zoom)
        {
            if (txtOutput.Zoom != zoom)
                txtOutput.Zoom = zoom;      // triggers zoom change on all exprssion tabs
        }

        private void txtOutput_ZoomChanged(object sender, EventArgs e)
        {
            foreach (var tab in expressionTabs)
                tab.SetZoom(txtOutput.Zoom);
            state.Zoom = txtOutput.Zoom;
            lblZoom.Visible = txtOutput.Zoom != 0;
            lblZoom.Text = $"Zoom {txtOutput.Zoom:+#;-#;0}";
        }

        private void notImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (currentTab == null || currentTab.isLinkedTab) return;
            currentTab?.Rename();
            gridFiles.Columns[currentTab.ID].HeaderText = currentTab.Text;
        }

        private void btnFunctionHelp_Click(object sender, EventArgs e)
        {
            state.FunctionHelper = splitContainer3.Panel2Collapsed;
            showFunctionHelper(state.FunctionHelper);
            expression_FunctionChanged(currentTab, currentTab.selectedFunction);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            currentTab?.InsertText("<b>", "bold text", "<//b>");
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            currentTab?.InsertText("<i>", "italic text", "<//i>");
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            currentTab?.InsertText("<u>", "underlined text", "<//u>");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            currentTab.InsertFont();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            currentTab.InsertImg();
        }

        private void btnInsertField_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
                jrAPI.updateFile(currentFile);
            var dialog = new InsertField(jrAPI.FieldDisplayNames, currentFile, jrAPI);
            if (DialogResult.OK == dialog.ShowDialog(this))
                currentTab?.InsertText("[", $"{dialog.selected}{(dialog.unformatted ? ",0" : "")}", "]", false, replace: true);
        }

        private void btnInsertFunction_Click(object sender, EventArgs e)
        {
            var dialog = new InsertFunction();
            if (DialogResult.OK == dialog.ShowDialog(this))
            {
                var func = dialog.selected;
                currentTab?.InsertText($"{func.function}(", "args", ")");
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            currentTab?.scintilla.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            currentTab?.scintilla.Redo();
        }

        #endregion

        private void expression_TextChanged(object sender, bool isEvaluated)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => expression_TextChanged(sender, isEvaluated)));
                return;
            }

            if (currentTab == null) return;

            lblChanged.Visible = paused && currentTab.needsEvaluation;
            if (currentTab.needsEvaluation) return;

            if (latencyChecks++ < 5 || latencyChecks % 10 == 0)
                getAPILatency();

            ShowResults();
            var tab = sender as ExpressionTab;
            UpdateDatagrid(tab, tab.scintilla.Text);
        }

        private void tabsRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            state.OutputTab = tabsRight.SelectedIndex;
            btnColumns.Visible = tabsRight.SelectedTab == tabDatagrid;

            if (!paused)
            {
                currentTab?.Evaluate(true);
                foreach (var tab in expressionTabs)
                    if (tab != currentTab)
                        UpdateDatagrid(tab, tab.scintilla.Text);
            }

            if (tabsRight.SelectedTab == tabDatagrid)
                resizeGridColumns();
        }

        private void lblLatency_Click(object sender, EventArgs e)
        {
            getAPILatency();
        }

        void showFunctionHelper(bool show)
        {
            splitContainer3.Panel2Collapsed = !show;
            btnFunctionHelp.Image = show ? Properties.Resources.book_open : Properties.Resources.book;
        }

        #region datagrid

        void UpdateDatagrid(ExpressionTab tab, string expression)
        {
            if (tabsRight.SelectedTab != tabDatagrid) return;
            if (!gridFiles.Columns.Contains(tab.ID) || !gridFiles.Columns[tab.ID].Visible)
                return;

            // get visible rows to fetch them first
            int first = gridFiles.FirstDisplayedScrollingRowIndex;
            int count = gridFiles.DisplayedRowCount(true);
            DataTable data = gridFiles.DataSource as DataTable;
            if (data == null) return;
            if (!data.Columns.Contains(tab.ID)) return;

            List<JRFile> visible = new List<JRFile>();
            for (int i = first - 1; i <= first + count; i++)
                if (i >= 0 && i < gridFiles.Rows.Count)
                    visible.Add(gridFiles.Rows[i].Cells[0].Value as JRFile);

            // make list of rows - visible first
            List<DataRow> rows = new List<DataRow>();
            foreach (DataRow row in data.Rows)
                if (visible.Contains(row[0] as JRFile))
                    rows.Add(row);
            foreach (DataRow row in data.Rows)
                if (!visible.Contains(row[0] as JRFile))
                    rows.Add(row);

            Task.Run(() =>
            {
                // calculate expression and populate data
                Stopwatch sw = new Stopwatch();
                List<object[]> rowData = new List<object[]>();
                int currRow = 0;
                bool isEmpty = string.IsNullOrWhiteSpace(expression);
                foreach (DataRow row in rows)
                {
                    if (tab.Paused || tab.needsEvaluation) return;
                    
                    if (settings.ShowAPICallTime) sw.Restart();
                    string value = isEmpty ? expression : jrAPI.resolveExpression(row[0] as JRFile, expression, settings.HighlightComments);
                    if (settings.ShowAPICallTime) sw.Stop();
                    double time = settings.ShowAPICallTime && !isEmpty ? TimeSpan.FromTicks(sw.ElapsedTicks).TotalMilliseconds : 0;

                    rowData.Add(new object[] { row, value, time });
                    if (++currRow % 100 == 0)
                    {
                        var copy = new List<object[]>(rowData);
                        BeginInvoke(new MethodInvoker(() => UpdateDatagrid(tab.ID, copy)));
                        rowData.Clear();
                    }
                }
                BeginInvoke(new MethodInvoker(() => UpdateDatagrid(tab.ID, rowData)));
            });

        }

        void UpdateDatagrid(string column, List<object[]> newData)
        {
            try
            {
                foreach (var data in newData)
                {
                    DataRow row = data[0] as DataRow;
                    row[column] = data[1];
                    if (settings.ShowAPICallTime)
                        row["API"] = $"{data[2]:0.00} ms";
                }
            }
            catch { }
        }

        DataTable getDataTable(JRPlaylist playlist)
        {
            // create table and columns
            DataTable dt = new DataTable();
            dt.Columns.Add("File", typeof(JRFile));
            foreach (var tab in expressionTabs)
                dt.Columns.Add(tab.ID);
            foreach (string field in state.TableFields)
                dt.Columns.Add(field);
            dt.Columns.Add("API");

            var index = new Dictionary<JRFile, DataRow>();

            // add rows
            foreach (var file in playlist.Files.OrderBy(f => f.ToString()))
            {
                List<object> items = new List<object>();
                items.Add(file);
                foreach (var tab in expressionTabs)
                    items.Add(string.Empty);
                foreach (string field in state.TableFields)
                {
                    if (!jrAPI.FieldMap.TryGetValue(field.ToLower(), out string fname))
                        fname = field;

                    items.Add(file[fname.ToLower()]);
                }
                if (settings.ShowAPICallTime) items.Add(string.Empty);
                index[file] = dt.Rows.Add(items.ToArray());
            }
            rowIndex = index;
            return dt;
        }

        void LoadDataTable()
        {
            var dt = getDataTable(currentPlaylist);

            gridFiles.DataSource = null;
            gridFiles.Columns.Clear();
            gridFiles.AutoGenerateColumns = true;
            gridFiles.DataSource = dt;

            gridFiles.Columns["API"].Width = 60;
            gridFiles.Columns["API"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            gridFiles.Columns["API"].SortMode = DataGridViewColumnSortMode.NotSortable;
            gridFiles.Columns["API"].Visible = settings.ShowAPICallTime;
            gridFiles.Columns[0].Width = 200;

            foreach (var tab in expressionTabs)
            {
                gridFiles.Columns[tab.ID].HeaderText = tab.Text;
                gridFiles.Columns[tab.ID].Visible = state.TableShowAll ? true : tab == currentTab;
                gridFiles.Columns[tab.ID].SortMode = DataGridViewColumnSortMode.NotSortable;
                gridFiles.Columns[tab.ID].Width = 100;
            }
            resizeGridColumns(true);
        }

        private void resizeGridColumns(bool force = false)
        {
            if (state == null || expressionTabs.Count == 0) return;
            int available = gridFiles.DisplayRectangle.Width;
            if (!force && available == lastResize) return;
            lastResize = available;

            int used = 0;
            foreach (DataGridViewColumn col in gridFiles.Columns)
                if (col.Visible) used += col.Width + col.DividerWidth;

            int grow = state.TableShowAll ? (available - used - 2) / expressionTabs.Count : available - used - 2;
            if (grow != 0)
            {
                foreach (var tab in expressionTabs)
                    if (gridFiles.Columns.Contains(tab.ID))
                    {
                        int w = gridFiles.Columns[tab.ID].Width + grow;
                        gridFiles.Columns[tab.ID].Width = w < 100 ? 100 : w;
                    }
            }
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            var selector = new ColumnSelector(jrAPI.FieldDisplayNames, state.TableFields, state.TableShowAll);
            if (DialogResult.OK == selector.ShowDialog())
            {
                state.TableFields = selector.SelectedFields;
                state.TableShowAll = selector.showAll;
                LoadPlaylist(currentPlaylist);
                if (!paused)
                {
                    currentTab?.Evaluate(true);
                    foreach (var tab in expressionTabs)
                        if (tab != currentTab)
                            UpdateDatagrid(tab, tab.scintilla.Text);
                }
                resizeGridColumns(true);
            }
        }

        #endregion

        private void tabsLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            state.CurrentTab = tabsLeft.SelectedIndex;
            if (currentTab == null) return;
            ShowResults();
            lblChanged.Visible = paused && currentTab.needsEvaluation;
            btnRevert.Enabled = btnSave.Enabled = btnLink.Enabled = LinkedFieldsEnabled && currentTab.isLinkedTab;
            btnLink.Enabled = LinkedFieldsEnabled;
            btnRename.Enabled = !currentTab.isLinkedTab;

            // datagrid: show column for current tab
            if (!state.TableShowAll & gridFiles.Columns.Count > 0)
                foreach (var tab in expressionTabs)
                    if (gridFiles.Columns.Contains(tab.ID))
                        gridFiles.Columns[tab.ID].Visible = tab.ID == currentTab.ID;

            currentTab.scintilla.Focus();
            currentTab.Evaluate();

            expression_FunctionChanged(currentTab, currentTab.selectedFunction);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (currentTab == null) return;
            if (currentTab.isLinkedTab && !currentTab.isSaved)
            {
                if (DialogResult.OK != MessageBox.Show(this, "Changes to this linked expression are not yet saved to MC and will be lost!\nAre you sure you want to close?",
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    return;
            }
            else if (!currentTab.isLinkedTab && !string.IsNullOrWhiteSpace(currentTab?.scintilla.Text))
                if (DialogResult.OK != MessageBox.Show(this, "Closing this tab will delete its current contents, are you sure?",
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    return;

            ExpressionTab tab = currentTab;

            int index = tabsLeft.SelectedIndex + 1;
            if (index >= tabsLeft.TabCount)
                index = tabsLeft.SelectedIndex - 1;
            if (index >= 0)
                tabsLeft.SelectedIndex = index;

            tabsLeft.Controls.Remove(tab);
            DataTable dt = gridFiles.DataSource as DataTable;
            if (dt != null)
                dt.Columns.Remove(tab.ID);

            if (tabsLeft.TabCount == 0)
                AddExpressionTab();

            reorderDatagridColumns();
        }

        private void wikiBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var node = wikiBrowser.Document.GetElementById("column-one");
            if (node != null) node.OuterHtml = "";
            node = wikiBrowser.Document.GetElementById("footer");
            if (node != null) node.OuterHtml = "";
            node = wikiBrowser.Document.GetElementById("catlinks");
            if (node != null) node.OuterHtml = "";

            node = wikiBrowser.Document.GetElementById("content");
            if (node != null)
                node.Style = "margin: 0 0 0 0; border:0; padding: 0;";

            Match m = Regex.Match(e.Url.ToString(), "([^#]+)#?(.+)?");
            if (m.Success && !string.IsNullOrEmpty(m.Groups[2].Value))
            {
                node = wikiBrowser.Document.GetElementById(m.Groups[2].Value);
                node?.ScrollIntoView(true);
            }
        }

        private void lblZoom_Click(object sender, EventArgs e)
        {
            txtOutput.Zoom = 0;
        }

        private void tabDatagrid_ClientSizeChanged(object sender, EventArgs e)
        {
            resizeGridColumns();
        }

        private void lblUpgrade_Click(object sender, EventArgs e)
        {
            AutoUpgrade.CheckUpgrade();
            lblUpgrade.Visible = false;
            lblStatus.Visible = true;
        }

        private void browser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.C || e.KeyCode == Keys.X) && e.Modifiers.HasFlag(Keys.Control))
                ClipboardCopySelection(sender as WebBrowser);
        }

        public void ClipboardCopySelection(WebBrowser browser)
        {
            try
            {
                IHTMLDocument2 htmlDocument = browser?.Document?.DomDocument as IHTMLDocument2;
                IHTMLSelectionObject currentSelection = htmlDocument?.selection;
                IHTMLTxtRange range = currentSelection?.createRange() as IHTMLTxtRange;

                if (!string.IsNullOrEmpty(range?.text))
                    Clipboard.SetText(range.text);
            }
            catch { }
        }

        private void ZeldaUI_KeyDown(object sender, KeyEventArgs e)
        {
            Action<object, EventArgs> action = null;
            if (e.Shift && e.Control && e.KeyCode == Keys.Z)
            {
                currentTab?.scintilla?.Redo();
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.Control)
            {
                int digit = -1;
                if (e.KeyCode >= Keys.NumPad1 &&  e.KeyCode <= Keys.NumPad9)
                    digit = e.KeyCode - Keys.NumPad1;
                if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
                    digit = e.KeyCode - Keys.D1;
                if (digit >= 0)
                {
                    // switch tab
                    if (tabsLeft.TabPages.Count > digit)
                        tabsLeft.SelectedIndex = digit;
                }
                else switch (e.KeyCode)
                {
                    case Keys.N: action = btnNew_Click; break;
                    case Keys.W: action = btnClose_Click; break;
                    case Keys.I: action = btnItalic_Click; break;
                    case Keys.B: action = btnBold_Click; break;
                    case Keys.U: action = btnUnderline_Click; break;
                    case Keys.L: action = btnLink_Click; break;
                    case Keys.S: action = btnSave_Click; break;
                    case Keys.R: action = btnRevert_Click; break;
                }
            }
            else if (e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right: action = btnNextFile_Click; break;
                    case Keys.Left: action = btnPrevFile_Click; break;
                }
            }
            else
                switch (e.KeyCode)
                {
                    case Keys.F1: action = btnAbout_Click; break;
                    case Keys.F2: action = btnRename_Click; break;
                    case Keys.F3: action = btnInsertField_Click; break;
                    case Keys.F4: action = btnInsertFunction_Click; break;
                    case Keys.F5: action = btnAutorun_Click; break;
                    case Keys.F10: action = btnSettings_Click; break;
                    case Keys.F11: WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized; break;
                }

            if (action != null)
            {
                e.Handled = e.SuppressKeyPress = true;
                BeginInvoke((MethodInvoker) delegate { action(null, EventArgs.Empty); });
            }
        }

        private void wikiBrowser_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string target = wikiBrowser.Document.ActiveElement.GetAttribute("href");
            if (string.IsNullOrEmpty(target))
                target = wikiBrowser.StatusText;
            if (!string.IsNullOrEmpty(target))
            {
                e.Cancel = true;
                try { Process.Start(target); }
                catch { }
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (!LinkedFieldsEnabled || currentTab == null) return;

            var fields = jrAPI.Fields.Where(f => f.isCalculated && f.FieldType != null && f.FieldType.ToLower().Contains("user")).OrderBy(f => f.Name).ToList();
            if (fields == null || fields.Count == 0)
            {
                MessageBox.Show("No user-defined calculated fields found in MC. Please add a field in MC first.", "No calculated fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            menuFieldList.Items.Clear();
            foreach (var f in fields)
            {
                var item = menuFieldList.Items.Add(f.Name);
                item.Tag = f.Expression;
            }

            var point = PointToClient(new Point(btnLink.Bounds.Left, splitContainer2.Panel1.Height + toolStrip1.Height));
            menuFieldList.Show(toolStrip1, new Point(btnLink.Bounds.Left, btnLink.Bounds.Height));
        }

        private void menuFieldList_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string name = $"🔗 [{e.ClickedItem.Text}]";
            string exp = e.ClickedItem.Tag as string;
            AddExpressionTab(name, exp, linkedField: e.ClickedItem.Text);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (!LinkedFieldsEnabled || currentTab == null || !currentTab.isLinkedTab) return;

            if (!currentTab.isSaved)
            {
                if (DialogResult.Yes != MessageBox.Show("Discard current changes and reload field expression from MC?", "Discard changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return;
            }

            var field = jrAPI.Fields.SingleOrDefault(f => f.isCalculated && f.Name.ToLower() == currentTab.linkedField.ToLower());
            if (field == null)
            {
                MessageBox.Show($"Field [{currentTab.linkedField}] not found in MC!", "Field not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentTab.SetContent(field.Expression);
            tabsLeft.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!LinkedFieldsEnabled || currentTab == null || !currentTab.isLinkedTab) return;
            if (jrAPI.ReadOnly)
            {
                MessageBox.Show("Please connect MCWS with a non-readonly username and password.",
                    "MCWS in read-only mode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var field = jrAPI.Fields.SingleOrDefault(f => f.Name == currentTab.linkedField);
            if (field == null)
                field = new JRField(currentTab.linkedField, currentTab.linkedField);

            field.Expression = Util.StripComments(currentTab.scintilla.Text);
            if (currentTab.Result == null || currentTab.Result.ToLower().StartsWith("expression error"))
            {
                if (DialogResult.Yes != MessageBox.Show("This seems to be an invalid expression!\nAre you sure you want to save it to MC?", "Expression error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
            }

            bool ok = jrAPI.CreateField(field);
            var newField = jrAPI.getFields()?.FirstOrDefault(f => f.Name == field.Name);
            ok &= Util.isSameExpression(field.Expression, newField?.Expression);

            if (!ok)
                MessageBox.Show($"Failed to save expression to linked MC field!", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateLinkedTabs();
            if (!ok)
            {
                currentTab.savedExpression = "";
                currentTab.isSaved = false;
            }
        }
    }
}
