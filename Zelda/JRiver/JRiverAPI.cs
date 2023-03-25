using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Zelda
{
    // talks to JRiver - opens JRiver as a background app if needed (OLE automation)
    // gets list of playlists, list of fields
    // reads and writes Fields from Files (movies)
    public class JRiverAPI
    {
        static string _installFolder;
        public static string MCFolder {
            get { if (_installFolder == null)
                    _installFolder = getInstallFolder();
                return _installFolder;
            } }

        public static string TooltipFolder { get { return Path.Combine(MCFolder ?? "", "data\\tooltip"); } }

        static IJRiverAPI api;

        public bool Connected => api == null ? false : api.Connected;
        public string MCVersion => api?.MCVersion;
        public string Library => api?.Library;
        public string LibraryPath => api?.LibraryPath;
        public int APIlevel => api == null ? 0 : api.APIlevel;
        public string Server { get; private set; }

        public List<JRPlaylist> Playlists { get; set; }
        public List<JRField> Fields { get; set; }
        public Dictionary<string, string> FieldMap { get; set; }     // displayName -> name
        public List<string> FieldsHighlight { get; set; }            // names + display names (highlight)
        public List<string> FieldDisplayNames { get; set; }          // display names


        public JRiverAPI()
        {
            api = new JAutomation();
            Server = "Automation@localhost";
        }

        public JRiverAPI(string server, string user, string pass)
        {
            api = new MCWS(server, user, pass);
            Server = $"MCWS@{server}";
        }

        public bool Connect()
        {
            return api.Connect();
        }

        public void Disconnect()
        {
            api?.Disconnect();
        }

        public static string getInstallFolder()
        {
            string path = null;
            try
            {
                using (var root = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                using (var jr = root.OpenSubKey("Software\\J. River"))
                {
                    string latest = jr?.GetSubKeyNames()?
                        .Where(n=>n.StartsWith("Media Center"))
                        .OrderByDescending(n => n)
                        .FirstOrDefault();
                    if (latest != null)
                        using (var mc = jr.OpenSubKey($"{latest}\\installer"))
                            path = mc?.GetValue("Install Directory", null)?.ToString();

                }
            }
            catch (Exception ex) { Logger.Log(ex, "getInstallFolder"); }

            // fallback: get path of running process
            try
            {
                if (string.IsNullOrEmpty(path))
                {

                    var proc = Process.GetProcesses().Where(p => p.ProcessName.ToLower().StartsWith("media center ")).OrderByDescending(p => p.ProcessName).FirstOrDefault();
                    if (proc != null)
                        path = Path.GetDirectoryName(proc.MainModule.FileName);
                }
            }
            catch (Exception ex) { Logger.Log(ex, "getInstallFolder"); }
            Logger.Log($"Detected MC install folder: {path}");
            return path;
        }

        public List<JRField> getFields()
        {
            Fields = new List<JRField>();
            FieldMap = new Dictionary<string, string>();
            FieldsHighlight = new List<string>();
            FieldDisplayNames = new List<string>();
            
            try
            {
                Fields = api.GetFields();
                foreach (var f in Fields)
                {
                    if (!string.IsNullOrEmpty(f.displayName) && !string.IsNullOrEmpty(f.name) && !FieldMap.ContainsKey(f.displayName.ToLower()))
                    {
                        FieldMap[f.displayName.ToLower()] = f.name;
                        FieldsHighlight.Add(f.displayName);
                        FieldsHighlight.Add(f.name);
                        FieldDisplayNames.Add(f.displayName);
                    }
                }
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFields()"); }
            FieldsHighlight = FieldsHighlight.Distinct().ToList();
            FieldsHighlight.Sort();
            FieldDisplayNames.Sort();
            return Fields;
        }

        public IEnumerable<JRPlaylist> getPlaylists(string filter = null, bool countFiles = true)
        {
            var filters = filter?.Split(';').Select(f => f.Trim()).Where(f => !string.IsNullOrEmpty(f));
            var iFilter = filters?.Where(f => !f.StartsWith("!")).ToList();
            var xFilter = filters?.Where(f => f.StartsWith("!")).ToList();
            if (iFilter != null && iFilter.Count == 0) iFilter = null;
            if (xFilter != null && xFilter.Count == 0) xFilter = null;

            Playlists = new List<JRPlaylist>();
            foreach (var pl in api.GetPlaylists(countFiles))
            {
                if (iFilter != null && iFilter.All(f => pl.FullName.IndexOf(f, StringComparison.CurrentCultureIgnoreCase) < 0))
                    continue;
                if (xFilter != null && xFilter.Any(f => pl.FullName.IndexOf(f, StringComparison.CurrentCultureIgnoreCase) >= 0))
                    continue;

                Playlists.Add(pl);
                yield return pl;
            }
        }

        public IEnumerable<JRFile> getFiles(JRPlaylist playlist, List<string> fields = null, string filter = null)
        {
            foreach (var file in api.GetPlaylistFiles(playlist, fields, filter))
                yield return file;
          
        }

        public void updateFile(JRFile file, bool allFields = true, bool formatted = true)
        {
            List<string> fields = allFields ? FieldMap.Keys.ToList() : file.fields.Keys.ToList();
            if (allFields && api is MCWS) fields = null;
            var updated = api.GetFile(file.Key, fields, formatted);
            file.copyFrom(updated);
        }

        public string resolveExpression(JRFile jrFile, string expression, bool stripComments = true)
        {
            if (stripComments)
                expression = Regex.Replace(expression ?? "", @"^##.*$\r?\n?", "", RegexOptions.Multiline);

            if (jrFile == null) return null;
            return api.ResolveExpression(jrFile.Key, expression);
        }

     }

}
