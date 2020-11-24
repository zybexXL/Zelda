using MediaCenter;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Zelda
{
    // talks to JRiver - opens JRiver as a background app if needed (OLE automation)
    // gets list of playlists, list of fields
    // reads and writes Fields from Files (movies)
    public class JRiverAPI
    {
        static string InstallFolder;
        public static string MCFolder {
            get { if (InstallFolder == null)
                    InstallFolder = getInstallFolder();
                return InstallFolder;
            } }

        public static string TooltipFolder { get { return Path.Combine(MCFolder ?? "", "data\\tooltip"); } }

        static IMJAutomation jr;
        public bool Connected;
        public string Version;
        public string Library;
        public int APIlevel;
        public List<JRPlaylist> Playlists;
        public Dictionary<string, string> FieldMap;     // displayName -> name
        public List<string> FieldsHighlight;            // names + display names (highlight)
        public List<string> FieldDisplayNames;          // display names
        public Exception lastException;
        string lastFile = null;

        public JRiverAPI()
        {
        }

        ~JRiverAPI()
        {   try
            {
                Disconnect();
                if (lastFile != null && File.Exists(lastFile))
                    File.Delete(lastFile);
            }
            catch { }
        }

        public bool Connect()
        {
            Logger.Log("Connecting to JRiver");
            Connected = CheckConnection();
            if (Connected) return true;

            try
            {
                // connect to existing instance
                Logger.Log("Connect: getting existing MediaCenter instance");
                jr = (IMJAutomation)Marshal.GetActiveObject("MediaJukebox Application");
                Connected = CheckConnection();
                if (Connected) return true;
                else Logger.Log("Connect to existing instance failed!");
            }
            catch { Logger.Log("JRiverAPI.Connect() - MediaCenter is probably not running"); }

            try
            {
                Logger.Log("Connect: creating new MediaCenter instance");
                jr = new MCAutomation();
                Connected = CheckConnection();
                if (!Connected)
                    Logger.Log("Connect via MCAutomation object failed!");
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.Connect() - failed to create new instance"); }
            return Connected;
        }

        public void Disconnect()
        {
            if (jr != null)
                Marshal.FinalReleaseComObject(jr);
            jr = null;
        }

        public bool CheckConnection()
        {
            try
            {
                Logger.Log("Checking connection");
                if (jr == null) return false;
                Version = jr.GetVersion().Version;
                APIlevel = jr.IVersion;
                Logger.Log($"MediaCenter version {Version}, APILevel={APIlevel}");
                string path=null;
                jr.GetLibrary(ref Library, ref path);
                Logger.Log($"MediaCenter library is '{Library}', path={path}");

                return true;
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.CheckConnection()"); }
            return false;
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

        public Dictionary<string, string> getFields()
        {
            FieldMap = new Dictionary<string, string>();
            FieldsHighlight = new List<string>();
            FieldDisplayNames = new List<string>();
            try
            {
                IMJFieldsAutomation iFields = jr.GetFields();
                int count = iFields.GetNumberFields();
                Logger.Log($"getFields: loading {count} fields");
                for (int i = 0; i < count; i++)
                {
                    IMJFieldAutomation field = iFields.GetField(i);
                    string display = field.GetName(true);
                    string name = field.GetName(false);
                    if (!string.IsNullOrEmpty(display) && !string.IsNullOrEmpty(name) && !FieldMap.ContainsKey(display.ToLower()))
                    {
                        FieldMap[display.ToLower()] = name;
                        FieldsHighlight.Add(display);
                        FieldsHighlight.Add(name);
                        FieldDisplayNames.Add(display);
                    }
                }
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFields()"); }
            FieldsHighlight = FieldsHighlight.Distinct().ToList();
            FieldsHighlight.Sort();
            FieldDisplayNames.Sort();
            return FieldMap;
        }

        public IEnumerable<JRPlaylist> getPlaylists(string filter = null, bool countFiles = true)
        {
            Playlists = new List<JRPlaylist>();
            DateTime limit = DateTime.Now.AddSeconds(10);                           // max playlist loadtime
            List<string> plFilter = filter?.Split(';').Select(f => f.Trim()).Where(f => !string.IsNullOrEmpty(f)).ToList();
            if (plFilter != null && plFilter.Count == 0) plFilter = null;

            try
            {
                IMJPlaylistsAutomation iList = jr.GetPlaylists();
                int count = iList.GetNumberPlaylists();

                Logger.Log($"getPlaylists: loading {count} playlists");
                for (int i = 0; i < count; i++)
                {
                    if (countFiles && DateTime.Now > limit) countFiles = false;         // disable getPLFileCount() if it's taking too long
                    IMJPlaylistAutomation list = iList.GetPlaylist(i);
                    
                    if (list.Get("type") == "1") continue;      // 0 = playlist, 1 = playlist group, 2 = smartlist
                    string name = list.Name ?? "playlist";
                    string fullname = $"{list.Path}\\{name}";
                    if (plFilter != null && plFilter.All(f => fullname.IndexOf(f, StringComparison.CurrentCultureIgnoreCase) < 0))
                        continue;

                    var playlist = new JRPlaylist(list.GetID(), name, -1, list.Path);
                    
                    // get file count - except for "audio - task - missing files" which may take a loooong time (isMissing() slowness)
                    if (countFiles && !name.ToLower().Contains("missing files"))
                    {
                        playlist.Count = getPLFileCount(playlist.ID);
                        if (playlist.Count < 0)
                            Logger.Log($"Warning - Slow playlist! Can't get filecount for playlist '{list.Name}'");
                        //else Logger.Log($"      playlist {i} has {fcount} files");
                    }
                    if (playlist.Count != 0)
                    {
                        Playlists.Add(playlist);
                        yield return playlist;
                    }
                }
            }
            finally
            {
                Playlists = Playlists.OrderBy(p => p.Name.ToLower()).ToList();
            }
            Logger.Log("getPlaylists: finished");
        }

        public int getPLFileCount(int listID, string filter = null)
        {
            int count = -1;
            try
            {
                Task t = Task.Run(() =>
                {
                   IMJPlaylistAutomation iList = jr.GetPlaylistByID(listID);
                   IMJFilesAutomation iFiles = iList.GetFiles();
                   if (!string.IsNullOrEmpty(filter))
                       iFiles.Filter(filter);

                   count = iFiles.GetNumberFiles();
                });
                if (!t.Wait(1000))
                    return -2;  // timeout, slow playlist
            }
            catch { }
            return count;
        }

        public IEnumerable<JRFile> getFiles(JRPlaylist playlist, List<string> fields = null, string filter = null, int start = 0, int step = 1)
        {
            IMJPlaylistAutomation pl = jr.GetPlaylistByID(playlist.ID);
            IMJFilesAutomation files = pl.GetFiles();
            if (!string.IsNullOrWhiteSpace(filter))
                files.Filter(filter);
            int num = files.GetNumberFiles();
            playlist.Count = num;
            for (int i = start; i < num; i += step)
            {
                var file = files.GetFile(i);
                if (file != null)
                    yield return getFieldValues(file, fields);
                else
                    playlist.Count--;
            }
        }

        public string resolveExpression(JRFile jrFile, string expression)
        {
            try
            {
                if (jr == null || jrFile == null || string.IsNullOrEmpty(expression)) return string.Empty;
                IMJFileAutomation file = jr.GetFileByKey(jrFile.JRKey);
                return file.GetFilledTemplate(expression);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.resolveExpression()"); }
            return "[JRiver Exception!]";
        }

        public string getFieldValue(int key, string field, bool formatted = true)
        {
            try
            {
                IMJFileAutomation file = jr.GetFileByKey(key);
                string value = file.Get(field, formatted);
                return value;
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return "[JRiver Exception!]";
        }

        public Dictionary<string, string> getFieldValues(int key, List<string> fields, bool formatted = true)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            try
            {
                IMJFileAutomation file = jr.GetFileByKey(key);
                foreach (var f in fields)
                    values[f] = file.Get(f, formatted);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return values;
        }

        private JRFile getFieldValues(IMJFileAutomation file, List<string> fields = null, bool formatted = true)
        {
            lastException = null;
            try
            {
                // get fields
                Dictionary<string, string> JRfields = new Dictionary<string, string>();

                JRfields["date imported"] = getFieldValue(file, "date imported", formatted);    // datetime / epoch
                JRfields["date (release)"] = getFieldValue(file, "date (release)", formatted);  // date / days since 1900
                JRfields["date"] = getFieldValue(file, "date", formatted);                      // date / days since 1900
                JRfields["date (year)"] = getFieldValue(file, "date (year)", formatted);        // year

                JRfields["name"] = getFieldValue(file, "name", formatted);
                JRfields["filename"] = getFieldValue(file, "filename", formatted);
                JRfields["file size"] = getFieldValue(file, "file size", formatted);
                JRfields["media sub type"] = getFieldValue(file, "media sub type", formatted);
                JRfields["media type"] = getFieldValue(file, "media type", formatted);

                if (fields != null && fields.Count > 0)
                    foreach (string f in fields)
                        if (!JRfields.ContainsKey(f.ToLower()))
                            JRfields[f.ToLower()] = getFieldValue(file, f, formatted);

                JRFile info = new JRFile(file.GetKey(), JRfields);
                return info;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "JRiverAPI.getMovieInfo()");
                lastException = ex;
            }
            return null;
        }

        private string getFieldValue(IMJFileAutomation file, string field, bool formatted = true)
        {
            try
            {
                return file.Get(field, formatted);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return "[JRiver Exception!]";
        }

        private bool setFieldValue(IMJFileAutomation file, string jrField, string value, bool isDisplayName = false)
        {
            try
            {
                if (isDisplayName)
                    FieldMap.TryGetValue(jrField.ToLower(), out jrField);
                bool ok = file.Set(jrField, value);
                if (!ok)
                    if (file.Get(jrField, false) == value)
                        ok = true;
                return ok;

            }
            catch { }
            return false;
        }
    }

}
