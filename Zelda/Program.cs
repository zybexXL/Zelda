﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace Zelda
{
    internal static class Program
    {
        public static Version version = Assembly.GetExecutingAssembly().GetName().Version;

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

        /*
         * 
        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        static string[] ScintillaLibs = new string[] { "Scintilla.dll", "Lexilla.dll" };


        static bool CompressLibraries()
        {
            string src = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "x64");
            string dest = Path.GetFullPath(Path.Combine(src, @"..\..\..\Lib"));

            bool ok = true;
            foreach (var lib in ScintillaLibs)
                ok &= Compress(Path.Combine(src, lib), Path.Combine(dest, Path.ChangeExtension(lib, ".gz")));

            return ok;
        }

        static bool Compress(string src, string dest)
        {
            if (!File.Exists(src)) return false;

            var destInfo = new FileInfo(dest);
            var srcInfo = new FileInfo(src);
            if (destInfo.Exists && srcInfo.Exists && destInfo.LastWriteTime == srcInfo.LastWriteTime)
                return true;

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dest));
                using (var output = File.Create(dest))
                using (var gzip = new GZipStream(output, CompressionMode.Compress))
                using (var input = File.OpenRead(src))
                    input.CopyTo(gzip);

                File.SetLastWriteTime(dest, srcInfo.LastWriteTime);
                return true;
            }
            catch { }
            return false;
        }

        static void ExtractLibraries()
        {
            string dest = Path.Combine(Path.GetTempPath(), "ScintillaNET");
            Directory.CreateDirectory(dest);

            foreach (var lib in ScintillaLibs)
            {
                string dll = Path.Combine(dest, lib);
                Util.ExtractResource(Path.ChangeExtension(lib, ".gz"), dll, true, true);
                var handle = LoadLibrary(dll);
                if (handle == IntPtr.Zero)
                {
                    MessageBox.Show("Failed to load required DLL dependencies! Check your TEMP folder variable");
                    Application.Exit();
                }
            }
        }

        */
    }
}
