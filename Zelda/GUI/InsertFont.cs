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
    public partial class InsertFont : Form
    {
        public ELFont SelectedFont = new ELFont();

        public InsertFont()
        {
            InitializeComponent();
            Icon = Properties.Resources.ZeldaIcon;
            DialogResult = DialogResult.Cancel;

            ddFont.DataSource = new InstalledFontCollection().Families;
            ddFont.ValueMember = "Name";
            ddFont.SelectedValue = "Segoe UI";
            ddFontSize.Text = "100";
            ddAlpha.Text = "100";
            lblColor.BackColor = Color.Blue;
            lblBackcolor.BackColor = Color.Black;
            chkFont.Checked = false;
            chkSize.Checked = false;
            chkAlpha.Checked = false;
            chkColor.Checked = false;
            chkBackcolor.Checked = false;
        }

        public InsertFont(string tag) : this()
        {
            ELFont font = ELFont.Parse(tag);
            if (font.font != null)
                ddFont.Text = font.font;
            if (font.size > 0)
                ddFontSize.Text = font.size.ToString();
            if (font.alpha > 0)
                ddAlpha.Text = font.alpha.ToString();
            if (font.color != Color.Empty)
                lblColor.BackColor = font.color;
            if (font.bgcolor != Color.Empty)
                lblBackcolor.BackColor = font.bgcolor;
            chkColor.Checked = (font.color != Color.Empty);
            chkBackcolor.Checked = (font.bgcolor != Color.Empty);
            SelectedFont = font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = validate();
            if (err != null)
                MessageBox.Show(err, "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = DialogResult.OK;
                SelectedFont.font = chkFont.Checked ? ddFont.Text : null;
                SelectedFont.size = chkSize.Checked ? int.Parse(ddFontSize.Text) : -1;
                SelectedFont.alpha = chkAlpha.Checked ? int.Parse(ddAlpha.Text) : -1;
                SelectedFont.color = chkColor.Checked ? lblColor.BackColor : Color.Empty;
                SelectedFont.bgcolor = chkBackcolor.Checked ? lblBackcolor.BackColor : Color.Empty;
                Close();
            }
        }

        private string validate()
        {
            if (chkSize.Checked && (!int.TryParse(ddFontSize.Text, out int num) || num <= 0)) return "Invalid font size";
            if (chkAlpha.Checked && (!int.TryParse(ddAlpha.Text, out num) || num < 0)) return "Invalid Alpha value";
            return null;
        }

        private void SettingsUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                Close();
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = (sender as Label).BackColor;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                (sender as Label).BackColor = colorPicker.Color;
                chkColor.Checked = true;
            }
        }

        private void lblBackcolor_Click(object sender, EventArgs e)
        {
            colorPicker.Color = (sender as Label).BackColor;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                (sender as Label).BackColor = colorPicker.Color;
                chkBackcolor.Checked = true;
            }
        }

        private void ddFontSize_TextChanged(object sender, EventArgs e)
        {
            chkSize.Checked = true;
        }

        private void ddAlpha_TextChanged(object sender, EventArgs e)
        {
            chkAlpha.Checked = true;
        }

        private void ddFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkFont.Checked = true;
        }

        private void ddFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
