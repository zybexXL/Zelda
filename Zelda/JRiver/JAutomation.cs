using MediaCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Zelda
{
    // talks to JRiver - opens JRiver as a background app if needed (OLE automation)
    // gets list of playlists, list of fields
    // reads and writes Fields from Files (movies)
    public class JAutomation: IJRiverAPI, IDisposable
    {
        IMJAutomation jr;

        public bool Connected { get; set; }
        public string MCVersion { get; set; }
        public string Library { get; set; }
        public int APIlevel { get; set; }
        public string LibraryPath { get; set; }
        public bool ReadOnly { get { return false; } set { } }

        public JAutomation()
        {
        }

        ~JAutomation()
        {
            Disconnect();
        }

        public void Dispose()
        {
            Disconnect();
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
            try
            {
                Connected = false;
                if (jr != null)
                    Marshal.FinalReleaseComObject(jr);
                jr = null;
            }
            catch { }
        }



        public List<JRField> GetFields()
        {
            var fields = new List<JRField>();
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
                    if (!string.IsNullOrEmpty(display) && !string.IsNullOrEmpty(name))
                        fields.Add(new JRField(name, display));
                }
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFields()"); }
            return fields;
        }
        public bool CreateField(JRField field)
        {
            return false;       // not supported, only on MCWS
        }

        public IEnumerable<JRPlaylist> GetPlaylists(bool countFiles = true)
        {
            var Playlists = new List<JRPlaylist>();
            DateTime limit = DateTime.Now.AddSeconds(10);                           // max playlist loadtime

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
                    int id = list.GetID();
                    var playlist = new JRPlaylist(id, name, -1, list.Path);

                    // get file count - except for "audio - task - missing files" which may take a loooong time (isMissing() slowness)
                    // get the file count in a separate thread with timeout to prevent hanging due to slow smartlists
                    if (countFiles && !name.ToLower().Contains("missing files"))
                    {
                        playlist.Count = -2;
                        Task getCount = new Task(() =>
                        {
                            IMJFilesAutomation iFiles = list.GetFiles();
                            playlist.Count = iFiles.GetNumberFiles();
                        });
                        
                        getCount.Start();
                        if (!getCount.Wait(2000))
                            Logger.Log($"Warning - Slow playlist! Can't get filecount for playlist '{list.Name}'");
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

        public IEnumerable<JRFile> GetPlaylistFiles(JRPlaylist playlist, List<string> fields = null, string filter = null)
        {
            IMJPlaylistAutomation pl = jr.GetPlaylistByID(playlist.ID);
            IMJFilesAutomation files = pl.GetFiles();
            if (!string.IsNullOrWhiteSpace(filter))
                files.Filter(filter);
            int num = files.GetNumberFiles();
            playlist.Count = num;
            for (int i = 0; i < num; i++)
            {
                var file = files.GetFile(i);
                if (file != null)
                    yield return getFile(file, fields);
                else
                    playlist.Count--;
            }
        }

        public string ResolveExpression(int fileKey, string expression)
        {
            try
            {
                if (string.IsNullOrEmpty(expression)) return string.Empty;
                IMJFileAutomation file = jr.GetFileByKey(fileKey);
                return file.GetFilledTemplate(expression);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.resolveExpression()"); }
            return "[JRiver Exception!]";
        }

        // get single field value (by key)
        public string getFieldValue(int fileKey, string field, bool formatted = true)
        {
            try
            {
                IMJFileAutomation file = jr.GetFileByKey(fileKey);
                string value = file.Get(field, formatted);
                return value;
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return "[JRiver Exception!]";
        }

        // get the field values for a given file (by key)
        public List<JRField> GetFieldValues(int fileKey, List<string> fields, bool formatted = true)
        {
            var values = new List<JRField>();
            try
            {
                IMJFileAutomation file = jr.GetFileByKey(fileKey);
                foreach (var f in fields)
                    values.Add(new JRField(f, null, file.Get(f, formatted)));
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return values;
        }

        // get a file with all field values (by key)
        public JRFile GetFile(int fileKey, List<string> fields = null, bool formatted = true)
        {
            try
            {
                IMJFileAutomation file = jr.GetFileByKey(fileKey);
                return getFile(file, fields, formatted);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return null;
        }

        #region private methods

        bool CheckConnection()
        {
            try
            {
                Logger.Log("Checking connection");
                if (jr == null) return false;
                MCVersion = jr.GetVersion().Version;
                APIlevel = jr.IVersion;
                string path = null;
                string library = null;
                jr.GetLibrary(ref library, ref path);
                Library = library;
                LibraryPath = path;
                Logger.Log($"MediaCenter version {MCVersion}, APILevel={APIlevel}");
                Logger.Log($"MediaCenter library is '{Library}', path={path}");

                return true;
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.CheckConnection()"); }
            return false;
        }

        // get a file with all field values (by Interface object)
        private JRFile getFile(IMJFileAutomation file, List<string> fields = null, bool formatted = true)
        {
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
            }
            return null;
        }

        // get single field value (by interface object)
        private string getFieldValue(IMJFileAutomation file, string field, bool formatted = true)
        {
            try
            {
                return file.Get(field, formatted);
            }
            catch (Exception ex) { Logger.Log(ex, "JRiverAPI.getFieldValue()"); }
            return "[JRiver Exception!]";
        }

        private bool setFieldValue(IMJFileAutomation file, string jrField, string value)
        {
            try
            {
                bool ok = file.Set(jrField, value);
                if (!ok)
                    if (file.Get(jrField, false) == value)
                        ok = true;
                return ok;
            }
            catch { }
            return false;
        }

        #endregion
    }
}
