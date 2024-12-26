using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zelda
{
    public partial class SettingsUI : Form
    {
        Settings settings;
        CustomFont[] fonts = new CustomFont[3];
        public bool ConnectionOptionsChanged = false;

        public SettingsUI(Settings settings)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Icon = Properties.Resources.ZeldaIcon;
            tabControl1.TabPages.Remove(tabCustomize);      // not implemented
            
            this.settings = settings;
            chkAPITime.Checked      = settings.ShowAPICallTime;
            chkIndent.Checked       = settings.WrapIndent;
            chkSaveTabs.Checked     = settings.SaveExpressions;
            chkSaveView.Checked     = settings.SaveState;
            chkTabs.Checked         = settings.ReplaceTabs;
            chkMaximize.Checked     = settings.StartMaximized;
            chkLoadPlaylist.Checked = settings.ReloadPlaylist;
            chkLines.Checked        = settings.ShowLineNumbers;
            chkFastStart.Checked    = settings.FastStart;
            chkSafeMode.Checked     = settings.SafeMode;

            delaySlide.Value        = settings.EvaluateDelay;

            chkSyntax.Checked         = settings.HighlightSyntax;
            chkSyntaxFunction.Checked = settings.HighlightFunction;
            chkSyntaxDelim.Checked    = settings.HighlightDelimiters;
            chkSyntaxComments.Checked = settings.HighlightComments;

            optMCWS.Checked = panelMCWS.Enabled = settings.UseMCWS;
            optAutomation.Checked = !settings.UseMCWS;
            txtServer.Text = settings.MCWSServer;
            if (string.IsNullOrEmpty(txtServer.Text))
                txtServer.Text = "http://localhost:52199";
            txtUsername.Text = settings.MCWSUsername;
            txtPassword.Text = OSProtect.Unprotect(settings.MCWSPassword);

            chkTooltip.Checked = txtTooltip.Enabled = !string.IsNullOrEmpty(settings.TooltipFolder);
            txtTooltip.Text = chkTooltip.Checked ? settings.TooltipFolder : JRiverAPI.TooltipFolder;
            chkPlaylistFilter.Checked = txtPlaylistFilter.Enabled = !string.IsNullOrEmpty(settings.PlaylistFilter);
            txtPlaylistFilter.Text = settings.PlaylistFilter;

            txtExtraFuncs.Text = string.Join(" ", settings.ExtraFunctions);

            radio1.Checked = true;
            fonts[0] = settings.EditorFont;
            fonts[1] = settings.OutputFont;
            fonts[2] = settings.RenderFont;
            ShowCustomFont();

            ConnectionOptionsChanged = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.ShowAPICallTime = chkAPITime.Checked;
            settings.WrapIndent = chkIndent.Checked;
            settings.SaveExpressions = chkSaveTabs.Checked;
            settings.SaveState = chkSaveView.Checked;
            settings.ReplaceTabs = chkTabs.Checked;
            settings.StartMaximized = chkMaximize.Checked;
            settings.ReloadPlaylist = chkLoadPlaylist.Checked;
            settings.ShowLineNumbers = chkLines.Checked;
            settings.FastStart = chkFastStart.Checked;
            settings.SafeMode = chkSafeMode.Checked;

            settings.HighlightSyntax = chkSyntax.Checked;
            settings.HighlightFunction = chkSyntaxFunction.Checked;
            settings.HighlightDelimiters = chkSyntaxDelim.Checked;
            settings.HighlightComments = chkSyntaxComments.Checked;

            settings.EvaluateDelay = delaySlide.Value;
            settings.TooltipFolder = chkTooltip.Checked ? txtTooltip.Text?.TrimEnd('\\') : null;
            settings.PlaylistFilter = chkPlaylistFilter.Checked && !string.IsNullOrWhiteSpace(txtPlaylistFilter.Text) ? txtPlaylistFilter.Text : null;

            settings.UseMCWS = optMCWS.Checked;
            settings.MCWSServer = txtServer.Text;
            settings.MCWSUsername = txtUsername.Text;
            settings.MCWSPassword = OSProtect.Protect(txtPassword.Text);

            string funcs = Regex.Replace(txtExtraFuncs.Text ?? "", "[,;()\r\n]+", " ");
            settings.ExtraFunctions = funcs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            settings.EditorFont = fonts[0];
            settings.OutputFont = fonts[1];
            settings.RenderFont = fonts[2];

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SettingsUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                Close();
            }
        }

        private void SettingsUI_Load(object sender, EventArgs e)
        {
            dgSyntax.Rows.Add("Fields", true, "", false, "", "[Director]");
            dgSyntax.Rows.Add("Functions", true, "", false, "", "ListCombine()");
            dgSyntax.Rows.Add("Math Funcs", true, "", false, "", "Int()");
            dgSyntax.Rows.Add("HTML", true, "", false, "", "<font>");
            dgSyntax.Rows.Add("Escaped", false, "", true, "", "/,");
            dgSyntax.Rows.Add("Literals", false, "", true, "", "/# expression #/");
            dgSyntax.Rows.Add("Numbers", true, "", false, "", "1234567890");
            dgSyntax.Rows.Add("Symbols", true, "", false, "", "( , , )");
            dgSyntax.Rows.Add("Comments", true, "", false, "", "[//, comment]");

            dgSyntax.Rows[0].Cells[2].Style.BackColor = Color.DarkGreen;
            dgSyntax.Rows[0].Cells[5].Style.ForeColor = Color.DarkGreen;

            dgSyntax.Rows[1].Cells[2].Style.BackColor = Color.Blue;
            dgSyntax.Rows[1].Cells[5].Style.ForeColor = Color.Blue;

            dgSyntax.Rows[2].Cells[2].Style.BackColor = Color.DarkCyan;
            dgSyntax.Rows[2].Cells[5].Style.ForeColor = Color.DarkCyan;

            dgSyntax.Rows[3].Cells[2].Style.BackColor = Color.DarkMagenta;
            dgSyntax.Rows[3].Cells[5].Style.ForeColor = Color.DarkMagenta;

            dgSyntax.Rows[4].Cells[4].Style.BackColor = Color.PaleGoldenrod;
            dgSyntax.Rows[4].Cells[5].Style.BackColor = Color.PaleGoldenrod;

            dgSyntax.Rows[5].Cells[4].Style.BackColor = Color.PaleGoldenrod;
            dgSyntax.Rows[5].Cells[5].Style.BackColor = Color.PaleGoldenrod;

            dgSyntax.Rows[6].Cells[2].Style.BackColor = Color.DarkOrange;
            dgSyntax.Rows[6].Cells[5].Style.ForeColor = Color.DarkOrange;

            dgSyntax.Rows[7].Cells[2].Style.BackColor = Color.Red;
            dgSyntax.Rows[7].Cells[5].Style.ForeColor = Color.Red;

            dgSyntax.Rows[8].Cells[2].Style.BackColor = Color.Gray;
            dgSyntax.Rows[8].Cells[5].Style.ForeColor = Color.Gray;
        }

        private void delaySlide_ValueChanged(object sender, EventArgs e)
        {
            lblDelay.Text = $"{delaySlide.Value} ms";
            if (delaySlide.Value % 50 != 0)
                delaySlide.Value = (delaySlide.Value / 50) * 50;
        }

        private void btnFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fontDialog.Font = lblSampleColor.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                lblSampleColor.Font = fontDialog.Font;
                SetCustomFont();
            }
        }

        private void btnTextColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colorDialog.Color = lblSampleColor.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            { 
                lblSampleColor.ForeColor = colorDialog.Color;
                SetCustomFont();
            }
        }

        private void btnBackColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            colorDialog.Color = lblSampleColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            { 
                lblSampleColor.BackColor = colorDialog.Color;
                SetCustomFont();
            }
        }

        int GetCustomizeIndex()
        {
            int index = 0;
            //if (radio1.Checked) index = 0;
            if (radio2.Checked) index = 1;
            if (radio3.Checked) index = 2;
            return index;
        }

        void SetCustomFont()
        {
            int index = GetCustomizeIndex();
            fonts[index].ForeColor = lblSampleColor.ForeColor;
            fonts[index].BackColor = lblSampleColor.BackColor;
            fonts[index].font = lblSampleColor.Font;
        }

        void ShowCustomFont()
        {
            int index = GetCustomizeIndex();
            lblSampleColor.ForeColor = fonts[index].ForeColor;
            lblSampleColor.BackColor = fonts[index].BackColor;
            lblSampleColor.Font = fonts[index].font;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                ShowCustomFont();
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            txtTooltip.Enabled = chkTooltip.Checked;
            txtTooltip.Text = chkTooltip.Checked ? settings.TooltipFolder : JRiverAPI.TooltipFolder;
        }

        private void connectionOptionChanged(object sender, EventArgs e)
        {
            txtPlaylistFilter.Enabled = chkPlaylistFilter.Checked;
            panelMCWS.Enabled = optMCWS.Checked;
            ConnectionOptionsChanged = true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            bool ok = false;
            JRiverAPI api;
            if (optAutomation.Checked)
                api = new JRiverAPI();
            else
                api = new JRiverAPI(txtServer.Text, txtUsername.Text, txtPassword.Text);

            try
            {
                ok = api.Connect();
            }
            catch { }

            if (!ok)
                MessageBox.Show("Failed to connect!", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Connection successful!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void connection_Changed(object sender, EventArgs e)
        {
            ConnectionOptionsChanged = true;
        }

        private void lblServer_Click(object sender, EventArgs e)
        {
            string help = toolTip1.GetToolTip(lblServer);
            toolTip1.Show(help, lblServer);
        }
    }
}
