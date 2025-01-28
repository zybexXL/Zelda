using System;
using System.IO;
using System.Windows.Forms;

namespace Zelda
{
    public partial class InsertImg : Form
    {
        public ELImg SelectedImg = new ELImg();

        public InsertImg()
        {
            InitializeComponent();
            Icon = Properties.Resources.ZeldaIcon;
            DialogResult = DialogResult.Cancel;

            chkWidth.Checked = false;
            chkHeight.Checked = false;
            
            comboVAlign.SelectedIndex = 1;  // middle
            chkVAlign.Checked = false;
        }

        public InsertImg(string tag) : this()
        {
            ELImg img = ELImg.Parse(tag);
            txtPath.Text = img.path ?? "";
            if (img.width > 0)
                txtWidth.Text = img.width.ToString();
            if (img.height > 0)
                txtHeight.Text = img.height.ToString();
            switch (img.valign?.ToLower())
            {
                case "top":
                case "middle":
                case "bottom": 
                    comboVAlign.Text = img.valign;
                    chkVAlign.Checked = true;
                    break;
            }
            SelectedImg = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = validate();
            if (err != null)
                MessageBox.Show(err, "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = DialogResult.OK;
                SelectedImg.setPath(txtPath.Text);
                SelectedImg.width = chkWidth.Checked ? int.Parse(txtWidth.Text) : -1;
                SelectedImg.height = chkHeight.Checked ? int.Parse(txtHeight.Text) : -1;
                SelectedImg.valign = chkVAlign.Checked ? comboVAlign.Text.ToLower() : null;
                Close();
            }
        }

        private string validate()
        {
            if (string.IsNullOrWhiteSpace(txtPath.Text)) return "Image file path is required";
            if (chkWidth.Checked && (!int.TryParse(txtWidth.Text, out int num) || num <= 0)) return "Invalid width";
            if (chkHeight.Checked && (!int.TryParse(txtHeight.Text, out num) || num <= 0)) return "Invalid height";
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

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            chkWidth.Checked = true;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            chkHeight.Checked = true;
        }

        private void comboVAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkVAlign.Checked = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string tooltip = ZeldaUI.TooltipDir?.ToLower();
            if (!string.IsNullOrEmpty(txtPath.Text))
                browseFile.InitialDirectory = txtPath.Text.ToLower().Trim().StartsWith("tooltip:") ? ZeldaUI.TooltipDir : Path.GetDirectoryName(txtPath.Text);
            if (browseFile.ShowDialog(this) == DialogResult.OK) {
                txtPath.Text = browseFile.FileName;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
