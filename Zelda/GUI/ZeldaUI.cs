using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    public partial class ZeldaUI : Form
    {
        internal static Settings settings;
        internal static string TooltipDir {
            get { return string.IsNullOrEmpty(settings?.TooltipFolder) ? JRiverAPI.TooltipFolder : settings.TooltipFolder.TrimEnd('\\');  } }

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
            this.Text = $"ZELDA v{Program.version.ToString()}";
            gridFiles.DoubleBuffered(true);
            gridFiles.Columns.Clear();

            jrAPI = new JRiverAPI();
            tabsLeft.TabPages.Clear();

            txtOutput.Margins[1].Width = 0;             // remove default margin
            SetOutputStyle();

            toolStrip1.Renderer = new ToolstripRenderer(Color.PowderBlue);      // renderer to apply a backcolor on Checked toolstrip buttons
            showFunctionHelper(false);

            comboLists.DrawMode = DrawMode.OwnerDrawFixed;
            comboLists.DrawItem += drawCombobox;

            // this doesn't work, looks like a bug in the Scintilla native control
            // it's supposed to change the representation of [CR] and [LF] symbols
            //int SCI_SETREPRESENTATION = 2665;
            //txtExpression.DirectMessage(SCI_SETREPRESENTATION, Marshal.StringToBSTR("\n"), Marshal.StringToBSTR("\xC2\xB6"));
            //txtExpression.DirectMessage(SCI_SETREPRESENTATION, Marshal.StringToBSTR("\r"), Marshal.StringToBSTR("\xC2\xA4"));
        }

        private void ZeldaUI_Load(object sender, EventArgs e)
        {

            if (!GetPlayLists(true))
                this.Close();
            else
            {
                initialized = true;
                LoadState();
                if (settings.StartMaximized)
                    this.WindowState = FormWindowState.Maximized;
            }
        }

        void LoadState()
        {
            tabsLeft.SuspendLayout();
            if (settings.SaveExpressions && state.Tabs.Count > 0)
            {
                int current = state.CurrentTab;
                foreach (var exp in state.Tabs)
                    AddExpressionTab(exp.name, exp.content, exp.position);
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
        }

        private void ZeldaUI_Shown(object sender, EventArgs e)
        {
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
                    state.Tabs.Add(new TabExpression(tab.Text, tab.scintilla.Text, tab.scintilla.CurrentPosition));
                state.Save();
            }
        }

        #endregion

        #region JRiver connect

        private void btnReconnect_Click(object sender, EventArgs e)
        {
            GetPlayLists();
        }

        private bool GetPlayLists(bool startup = false)
        {
            var progressUI = new ProgressUI("Connecting to MediaCenter...", ConnectJRiver, false);
            if (startup)
                progressUI.StartPosition = FormStartPosition.CenterScreen;

            progressUI.ShowDialog(this);

            if (!jrAPI.Connected)
            {
                progressUI.Close();
                MessageBox.Show("Cannot connect to MediaCenter, please make sure it's installed on this PC", "No MediaCenter!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (jrAPI.Playlists.Count == 0)
            {
                string filtered = !string.IsNullOrEmpty(settings.PlaylistFilter) ? "\nPlease check the Playlist Filter in settings." : "";
                MessageBox.Show($"Failed to load list of Playlists from MediaCenter!{filtered}", "No playlists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblStatus.Text = $"Connected to MediaCenter v{jrAPI.Version} - {jrAPI.Library}";
            loading = true;

            // update datagrid column/field list
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
            var lists = jrAPI.getPlaylists(settings.PlaylistFilter, !settings.FastStart).ToList();

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

        private ExpressionTab AddExpressionTab(string name = null, string content = null, int pos = -1)
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

            if (content != null) tab.scintilla.Text = content;
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
            webBrowser.Stop();
            if (name == null)
                webBrowser.DocumentText = $"no function highlighted";
            else if (string.IsNullOrEmpty(func?.wikiUrl))
                webBrowser.DocumentText = $"<b>{name}():</b> Wiki not available for this function";
            else
                webBrowser.Navigate(func?.wikiUrl);
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
            LoadDocument(currentTab.Result ?? "");
        }

        #region HTML Renderer

        private void LoadDocument(string text)
        {
            txtOutput.ReadOnly = false;
            txtOutput.Text = text;
            txtOutput.ReadOnly = true;

            string html = getHTML(text);
            //htmlOutput.Text = html;

            if (browser.IsBusy)
            {
                browser.Stop();
                Application.DoEvents();
            }
            browser.DocumentText = html;
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
                    sb.Append(fixEntities(text.Substring(pos, m.Index-pos)));
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            string filter = settings.PlaylistFilter ?? "";
            if (DialogResult.OK == new SettingsUI(settings).ShowDialog(this))
            {
                settings.Save();
                SetOutputStyle();
                ShowResults();
                foreach (var tab in expressionTabs)
                    tab.Config(settings);
                if (gridFiles.Columns["API"] != null)
                    gridFiles.Columns["API"].Visible = settings.ShowAPICallTime;

                if (filter != (settings.PlaylistFilter ?? ""))
                    GetPlayLists();
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
            if(txtOutput.Zoom < 20)
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
            if (currentFile == null) return;

            currentFile.updateFields(jrAPI.FieldDisplayNames, jrAPI);
            var dialog = new InsertField(jrAPI.FieldDisplayNames, currentFile, jrAPI);
            if (DialogResult.OK == dialog.ShowDialog(this))
                currentTab?.InsertText("[", $"{dialog.selected}{(dialog.unformatted ? ",0":"")}", "]", false, replace: true);
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

            lblChanged.Visible = paused && currentTab.isModified;
            if (!isEvaluated) return;

            lblChanged.Visible = false;
            if (latencyChecks++ < 5)
                getAPILatency();

            ShowResults();
            var tab = sender as ExpressionTab;
            UpdateDatagrid(tab, tab.scintilla.Text);
        }

        private void tabsRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            state.OutputTab = tabsRight.SelectedIndex;
            btnColumns.Visible = tabsRight.SelectedTab == tabDatagrid;

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
                    if (tab.changed) return;
                    //if (changed) return;  // TODO!!!! cancel current processing on changes
                    if (settings.ShowAPICallTime) sw.Restart();
                    string value = isEmpty ? expression : jrAPI.resolveExpression(row[0] as JRFile, expression);
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
            foreach (var file in playlist.Files.OrderBy(f=>f.ToString()))
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
            if (state == null) return;
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
            lblChanged.Visible = paused && currentTab.isModified;

            // datagrid: show column for current tab
            if (!state.TableShowAll & gridFiles.Columns.Count > 0)
                foreach (var tab in expressionTabs)
                    if (gridFiles.Columns.Contains(tab.ID))
                        gridFiles.Columns[tab.ID].Visible = tab.ID == currentTab.ID;

            currentTab.scintilla.Focus();
            if (!paused && currentTab.isModified)
                currentTab.Evaluate(true);

            expression_FunctionChanged(currentTab, currentTab.selectedFunction);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(currentTab?.scintilla.Text))
                if (DialogResult.OK != MessageBox.Show(this, "Close this tab will delete its current contents, are you sure?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    return;
            ExpressionTab tab = currentTab;

            int index = tabsLeft.SelectedIndex;

            tabsLeft.Controls.Remove(tab);
            DataTable dt = gridFiles.DataSource as DataTable;
            if (dt != null)
                dt.Columns.Remove(tab.ID);

            if (tabsLeft.TabCount == 0)
                AddExpressionTab();

            if (index >= tabsLeft.TabCount)
                index = tabsLeft.TabCount-1;
            tabsLeft.SelectedIndex = index;

            reorderDatagridColumns();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var node = webBrowser.Document.GetElementById("column-one");
            if (node != null) node.OuterHtml = "";
            node = webBrowser.Document.GetElementById("footer");
            if (node != null) node.OuterHtml = "";
            node = webBrowser.Document.GetElementById("catlinks");
            if (node != null) node.OuterHtml = "";

            node = webBrowser.Document.GetElementById("content");
            if (node != null)
                node.Style = "margin: 0 0 0 0; border:0; padding: 0;";

            Match m = Regex.Match(e.Url.ToString(), "([^#]+)#?(.+)?");
            if (m.Success && !string.IsNullOrEmpty(m.Groups[2].Value))
            {
                node = webBrowser.Document.GetElementById(m.Groups[2].Value);
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
    }
}
