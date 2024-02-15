using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                string url = $"mailto:pfonseca@gmail.com?subject=Zelda%20v{Program.version.ToString()}";
                Process.Start(url);
            }
            catch { }
        }

        private void AboutUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void lblForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start($"https://yabb.jriver.com/interact/index.php/topic,125975.0.html");
            }
            catch { }
        }
    }
}
