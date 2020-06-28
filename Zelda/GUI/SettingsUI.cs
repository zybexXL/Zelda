using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    public partial class SettingsUI : Form
    {
        Settings settings;

        public SettingsUI(Settings settings)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Icon = Properties.Resources.ZeldaIcon;

            this.settings = settings;
            chkAPITime.Checked      = settings.ShowAPICallTime;
            chkIndent.Checked       = settings.WrapIndent;
            chkSaveTabs.Checked     = settings.SaveExpressions;
            chkSaveView.Checked     = settings.SaveState;
            chkTabs.Checked         = settings.ReplaceTabs;
            chkMaximize.Checked     = settings.StartMaximized;
            chkLoadPlaylist.Checked = settings.ReloadPlaylist;
            chkLines.Checked        = settings.ShowLineNumbers;

            delaySlide.Value        = settings.EvaluateDelay;

            chkSyntax.Checked       = settings.HighlightSyntax;
            chkSyntaxFunction.Checked = settings.HighlightFunction;
            chkSyntaxDelim.Checked  = settings.HighlightDelimiters;

            txtExtraFuncs.Text = string.Join(" ", settings.ExtraFunctions);
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

            settings.HighlightSyntax = chkSyntax.Checked;
            settings.HighlightFunction = chkSyntaxFunction.Checked;
            settings.HighlightDelimiters = chkSyntaxDelim.Checked;

            settings.EvaluateDelay = delaySlide.Value;

            string funcs = txtExtraFuncs.Text ?? "";
            funcs = funcs.Replace(",", " ");
            funcs = funcs.Replace(";", " ");
            funcs = funcs.Replace("(", " ");
            funcs = funcs.Replace(")", " ");
            settings.ExtraFunctions = funcs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

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

            ddFont.DataSource = new InstalledFontCollection().Families;
            ddFont.ValueMember = "Name";
            ddFont.SelectedValue = "Consolas";
            ddFontSize.Text = "10";
        }

        private void delaySlide_ValueChanged(object sender, EventArgs e)
        {
            lblDelay.Text = $"{delaySlide.Value} ms";
            if (delaySlide.Value % 50 != 0)
                delaySlide.Value = (delaySlide.Value / 50) * 50;
            
        }
    }
}
