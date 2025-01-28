using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zelda
{
    public partial class SettingsUI : Form
    {
        Settings settings;
        Font[] fonts = new Font[3];
        public bool ConnectionOptionsChanged = false;

        public SettingsUI(Settings settings)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Icon = Properties.Resources.ZeldaIcon;
            this.settings = settings;

            // connection
            optMCWS.Checked = panelMCWS.Enabled = settings.UseMCWS;
            optAutomation.Checked = !settings.UseMCWS;
            txtServer.Text = settings.MCWSServer;
            if (string.IsNullOrEmpty(txtServer.Text))
                txtServer.Text = "http://localhost:52199";
            txtUsername.Text = settings.MCWSUsername;
            txtPassword.Text = OSProtect.Unprotect(settings.MCWSPassword);

            // preferences - application
            chkAPITime.Checked = settings.ShowAPICallTime;
            chkFastStart.Checked = settings.FastStart;
            chkLoadPlaylist.Checked = settings.ReloadPlaylist;
            chkSaveView.Checked = settings.SaveState;
            chkSaveTabs.Checked = settings.SaveExpressions;
            chkTooltip.Checked = txtTooltip.Enabled = !string.IsNullOrEmpty(settings.TooltipFolder);
            txtTooltip.Text = chkTooltip.Checked ? settings.TooltipFolder : JRiverAPI.TooltipFolder;
            chkPlaylistFilter.Checked = txtPlaylistFilter.Enabled = !string.IsNullOrEmpty(settings.PlaylistFilter);
            txtPlaylistFilter.Text = settings.PlaylistFilter;

            // preferences - editor
            chkIndent.Checked = settings.WrapIndent;
            chkTabs.Checked = settings.ReplaceTabs;
            chkLines.Checked = settings.ShowLineNumbers;
            chkSafeMode.Checked = settings.SafeMode;
            delaySlide.Value = settings.EvaluateDelay;

            // theme - highlight
            optThemeAuto.Checked = true;
            optThemeDark.Checked = settings.Theme == SkinTheme.Dark;
            optThemeLight.Checked = settings.Theme == SkinTheme.Light;
            chkSyntax.Checked = settings.HighlightSyntax;
            chkSyntaxFunction.Checked = settings.HighlightFunction;
            chkSyntaxDelim.Checked = settings.HighlightDelimiters;
            chkSyntaxComments.Checked = settings.HighlightComments;
            txtExtraFuncs.Text = string.Join(" ", settings.ExtraFunctions);

            // theme - fonts
            fonts[0] = settings.EditorFont;
            fonts[1] = settings.OutputFont;
            fonts[2] = settings.RenderFont;
            ShowFonts();

            ConnectionOptionsChanged = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // connection
            settings.UseMCWS = optMCWS.Checked;
            settings.MCWSServer = txtServer.Text;
            settings.MCWSUsername = txtUsername.Text;
            settings.MCWSPassword = OSProtect.Protect(txtPassword.Text);

            // preferences - application
            settings.ShowAPICallTime = chkAPITime.Checked;
            settings.FastStart = chkFastStart.Checked;
            settings.ReloadPlaylist = chkLoadPlaylist.Checked;
            settings.SaveState = chkSaveView.Checked;
            settings.SaveExpressions = chkSaveTabs.Checked;
            settings.TooltipFolder = chkTooltip.Checked ? txtTooltip.Text?.TrimEnd('\\') : null;
            settings.PlaylistFilter = chkPlaylistFilter.Checked && !string.IsNullOrWhiteSpace(txtPlaylistFilter.Text) ? txtPlaylistFilter.Text : null;

            // preferences - editor
            settings.WrapIndent = chkIndent.Checked;
            settings.ReplaceTabs = chkTabs.Checked;
            settings.ShowLineNumbers = chkLines.Checked;
            settings.SafeMode = chkSafeMode.Checked;
            settings.EvaluateDelay = delaySlide.Value;

            // theme
            settings.Theme = optThemeDark.Checked ? SkinTheme.Dark : optThemeLight.Checked ? SkinTheme.Light : SkinTheme.Auto;
            settings.HighlightSyntax = chkSyntax.Checked;
            settings.HighlightFunction = chkSyntaxFunction.Checked;
            settings.HighlightDelimiters = chkSyntaxDelim.Checked;
            settings.HighlightComments = chkSyntaxComments.Checked;
            string funcs = Regex.Replace(txtExtraFuncs.Text ?? "", "[,;()\r\n]+", " ");
            settings.ExtraFunctions = funcs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // theme - fonts
            settings.EditorFont = fonts[0];
            settings.OutputFont = fonts[1];
            settings.RenderFont = fonts[2];

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
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
            DialogResult = DialogResult.Cancel;
        }

        private void delaySlide_ValueChanged(object sender, EventArgs e)
        {
            lblDelay.Text = $"{delaySlide.Value} ms";
            if (delaySlide.Value % 50 != 0)
                delaySlide.Value = (delaySlide.Value / 50) * 50;
        }

        private void btnResetEditorFont_Click(object sender, EventArgs e)
        {
            fonts[0] = Constants.DefaultEditorFont;
            lblEditorFont.Text = settings.GetFontString(fonts[0]);
        }

        private void btnResetOutputFont_Click(object sender, EventArgs e)
        {
            fonts[1] = Constants.DefaultOutputFont;
            lblOutputFont.Text = settings.GetFontString(fonts[1]);
        }

        private void btnResetRenderFont_Click(object sender, EventArgs e)
        {
            fonts[2] = Constants.DefaultRenderFont;
            lblRenderFont.Text = settings.GetFontString(fonts[2]);
        }
        private void btnEditorFont_Click(object sender, EventArgs e)
        {
            fonts[0] = SelectFont(fonts[0]);
            ShowFonts();
        }

        private void btnOutputFont_Click(object sender, EventArgs e)
        {
            fonts[1] = SelectFont(fonts[1]);
            ShowFonts();
        }

        private void btnRenderFont_Click(object sender, EventArgs e)
        {
            fonts[2] = SelectFont(fonts[2]);
            ShowFonts();
        }

        private Font SelectFont(Font font)
        {
            fontDialog.Font = font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
                font = fontDialog.Font;
            return font;
        }

        private void ShowFonts()
        {
            lblEditorFont.Text = settings.GetFontString(fonts[0]);
            lblOutputFont.Text = settings.GetFontString(fonts[1]);
            lblRenderFont.Text = settings.GetFontString(fonts[2]);
            lblEditorFont.Font = new Font(fonts[0].Name, 10, fonts[0].Style);
            lblOutputFont.Font = new Font(fonts[1].Name, 10, fonts[1].Style);
            lblRenderFont.Font = new Font(fonts[2].Name, 10, fonts[2].Style);
        }

        private void chkTooltip_CheckChanged(object sender, EventArgs e)
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

        private void btnThemeHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnThemeEdit_Click(object sender, EventArgs e)
        {
            var theme = optThemeDark.Checked ? SkinTheme.Dark : optThemeLight.Checked ? SkinTheme.Light : SkinTheme.Auto;
            Skin skin = Skin.LoadTheme(theme);

            try
            {
                Process.Start("notepad", skin.Filename);
            }
            catch
            {
                MessageBox.Show("Process failed", $"Failed to open Notepad!\n{skin.Filename}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemeReset_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Reset theme colors", $"This will overwrite the selected Theme file.\nAre you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                var theme = optThemeDark.Checked ? SkinTheme.Dark : optThemeLight.Checked ? SkinTheme.Light : SkinTheme.Auto;
                Skin skin = Skin.LoadTheme(theme, true);
                skin.Save();
            }
        }
    }
}
