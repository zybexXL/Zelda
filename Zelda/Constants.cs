using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda
{
    public class Constants
    {
        static string _dataFolder;
        public static string DataFolder
        {
            get
            {
                if (_dataFolder == null) _dataFolder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Zelda");
                return _dataFolder;
            }
        }

        public static string SettingsFile = Path.Combine(DataFolder, "zelda.json");
        public static string StateFile = Path.Combine(DataFolder, "zeldaState.json");
        public static string WebView2Data = Path.Combine(DataFolder, "WebView2");
    }
}
