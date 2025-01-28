using System;
using System.Windows.Forms;

namespace Zelda
{
    public partial class InputBox : Form
    {
        public string Value;

        public InputBox()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public InputBox(string title, string value) : this()
        {
            Text = title;
            Value = value ?? "";
            txtValue.Text = Value;
            txtValue.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValue.Text))
            {
                DialogResult = DialogResult.OK;
                Value = txtValue.Text; 
                this.Close();
            }
            else MessageBox.Show("You need to enter something...", "What?", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == 27) this.Close();
            else if (e.KeyChar == 13) btnOK_Click(null, EventArgs.Empty);
            else e.Handled = false;
        }
    }
}
