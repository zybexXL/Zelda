using System;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Windows.Forms;

namespace Zelda
{
    public partial class AboutUI : Form
    {
        public AboutUI()
        {
            InitializeComponent();
            Icon = Properties.Resources.ZeldaIcon;
            lblVersion.Text = $"Version {Program.version.ToString(3)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.ShellStart($"mailto:pbfonseca@gmail.com?subject=Zelda%20v{Program.version.ToString()}");
        }

        private void AboutUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void lblForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.ShellStart("https://yabb.jriver.com/interact/index.php/topic,125975.0.html");
        }
    }
}
