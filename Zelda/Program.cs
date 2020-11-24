using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    internal static class Program
    {
        public static Version version = new Version(1, 2, 0);    // major, minor, revision
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoUpgrade.Cleanup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ZeldaUI());
        }
    }
}
