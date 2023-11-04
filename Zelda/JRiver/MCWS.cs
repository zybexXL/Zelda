using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Zelda
{
    public class MCWS : IJRiverAPI, IDisposable
    {
        string hostURL;
        string authToken;

        HttpClient http;
        bool debug = false;

        public int status { get; set; }
        public bool Connected { get; set; }
        public string MCVersion { get; set; }
        public string Library { get; set; }
        public int APIlevel { get; set; }
        public string LibraryPath { get; set; }
        public string Platform { get; set; }
        public string ServerName { get; set; }


        public MCWS(string server, string username, string password, bool verbose = false)
        {
            hostURL = server.ToLower();
            authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

            debug = verbose;

            if (!hostURL.Contains(":") && !hostURL.EndsWith("/"))
                hostURL = hostURL.StartsWith("https:") ? $"{hostURL}:52200" : $"{hostURL}:52199";

            if (!hostURL.StartsWith("http"))
                hostURL = $"http://{hostURL}";

            hostURL = hostURL.TrimEnd('/') + "/MCWS/v1/";
        }

        ~MCWS()
        {
            Disconnect();
        }

        public void Dispose()
        {
            Disconnect();
        }

        public bool Connect()
        {
            HttpClientHandler handler = new HttpClientHandler();
            http = new HttpClient();
            http.BaseAddress = new Uri(hostURL);
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
            http.DefaultRequestHeaders.ConnectionClose = true;      // MC is slow with connection=keep-alive

            Connected = CheckConnection();
            return Connected;
        }

        public void Disconnect()
        {
            http?.Dispose();
            Connected = false;
        }

        public List<JRField> GetFields()
        {
            if (HttpGet("Library/Fields", out string xml) != 200)
                return null;

            var matches = Regex.Matches(xml, "<Field Name=\"(.+?)\".+?DisplayName=\"(.+?)\"", RegexOptions.Singleline);
            return matches.Cast<Match>().Select(f => new JRField(f.Groups[1].Value, f.Groups[2].Value)).ToList();
        }

        public IEnumerable<JRPlaylist> GetPlaylists(bool countFiles = true)
        {
            if (HttpGet("Playlists/List", out string xml) != 200)
                yield break;

            var ids = Regex.Matches(xml, @"<Field Name=""ID"">(-?\d+)").Cast<Match>().Select(m => int.Parse(m.Groups[1].Value)).ToList();
            var names = Regex.Matches(xml, @"<Field Name=""Name"">(.+?)<").Cast<Match>().Select(m => m.Groups[1].Value).ToList();
            var paths = Regex.Matches(xml, @"<Field Name=""Path"">(.+?)<").Cast<Match>().Select(m => m.Groups[1].Value).ToList();
            var types = Regex.Matches(xml, @"<Field Name=""Type"">(.+?)<").Cast<Match>().Select(m => m.Groups[1].Value).ToList();

            for (int i = 0; i < ids.Count; i++)
            {
                if (types[i] == "Group") continue;

                string path = Regex.Replace(paths[i], @"([/\\])?[^/\\]+$", "");
                var pl = new JRPlaylist(ids[i], names[i], -1, path);

                // get file count - except for "audio - task - missing files" which may take a loooong time (isMissing() slowness)
                // get the file count in a separate thread with timeout to prevent hanging due to slow smartlists
                if (countFiles && !names[i].ToLower().Contains("missing files"))
                {
                    pl.Count = -2;
                    Task getCount = new Task(() => {
                        if (HttpGet($"Playlist/Files?playlist={ids[i]}&action=json&fields=key", out string keyList) == 200)
                            pl.Count = Regex.Matches(keyList, "Key", RegexOptions.IgnoreCase).Count;
                        else
                            pl.Count = -1; 
                    });
                    getCount.Start();
                    if (!getCount.Wait(2000))
                        Logger.Log($"Warning - Slow playlist! Can't get filecount for playlist '{pl.Name}'");
                }

                yield return pl;
            }
        }

        public IEnumerable<JRFile> GetPlaylistFiles(JRPlaylist playlist, List<string> fields = null, string filter = null)
        {
            if (fields == null) fields = new List<string>();
            fields.AddRange(new string[] { "key", "date", "date imported", "date (release)", "date (year)", "name", "filename", "file size", "media sub type", "media type" });
            fields = fields.Distinct(StringComparer.InvariantCultureIgnoreCase).ToList();

            string fieldList = $"&fields={string.Join(",", fields.Select(f => Uri.EscapeDataString(f)))}";
            if (HttpGet($"Playlist/Files?playlist={playlist.ID}&action=JSON{fieldList}", out string json) != 200)
                yield break;

            var files = JRFile.FromJsonArray(json);
            
            foreach (var file in files)
                yield return file;
        }

        public string ResolveExpression(int filekey, string expression)
        {
            string result = "";
            expression = Uri.EscapeDataString(expression);
            string url = $"File/GetFilledTemplate?File={filekey}&Expression={expression}";
            if (HttpGet(url, out string xml, false) != 200)
                return null;
            var match = Regex.Match(xml ?? "", @"<Item Name=""Value"">(.*?)</Item>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (match.Success) result = HttpUtility.HtmlDecode(match.Groups[1].Value.Replace("+"," "));
            return result;
        }

        public JRFile GetFile(int fileKey, List<string> fields = null, bool formatted = true)
        {
            string fieldList = fields == null ? "&fields=calculated" : $"&fields={string.Join(",", fields.Select(f=>HttpUtility.UrlEncode(f)))}";
            string format = formatted ? "&formatted=1" : "";

            if (HttpGet($"File/GetInfo?file={fileKey}&action=JSON{format}{fieldList}", out string json) != 200)
                return null;

            return JRFile.FromJson(json);
        }

        private int HttpGet(string url, out string answer, bool printDebug = true)
        {
            answer = null;
            try
            {
                string debugstr = url;
                if (debugstr.Length > 75) debugstr = debugstr.Substring(0, 75) + "(...)";
                if (debug && printDebug) Console.WriteLine($"  -> MCWS call: {debugstr}");

                using (HttpResponseMessage response = http.GetAsync(url).Result)
                {
                    answer = response.Content.ReadAsStringAsync().Result;

                    debugstr = answer != null && answer.Length < 75 ? $"'{answer.Replace('\r', '.').Replace('\n', '.')}'" : $"{answer.Length} bytes";
                    if (debug && printDebug) Console.WriteLine($"  <- MCWS says: {response.StatusCode}, {debugstr}");

                    status = (int)(response.StatusCode);
                    return status;
                }
            }
            catch (Exception ex)
            {
                if (debug)
                    Console.WriteLine($"  HTTP Exception: {ex.Message} :: {ex.InnerException?.Message}");
            }
            status = 0;
            return 0;
        }

        private bool CheckConnection()
        {
            if (HttpGet("Alive", out string xml) != 200)
                return false;
            if (!Authenticate())
                return false;
            
            var props = parseXMLData(xml);
            Platform = props.TryGetValue("Platform", out string value) ? value : null;      // Windows/Mac/Linux
            APIlevel = props.TryGetValue("LibraryVersion", out value) && int.TryParse(value, out int num) ? num : 0;
            ServerName = props.TryGetValue("FriendlyName", out value) ? value : null;
            MCVersion = props.TryGetValue("ProgramVersion", out value) ? value : null;

            GetLibraryName();
            return true;
        }

        private bool Authenticate()
        {
            return HttpGet("Authenticate", out string xml) == 200;
        }

        private bool GetLibraryName()
        {
            if (HttpGet("Library/List", out string xml) != 200)
                return false;

            var props = parseXMLData(xml);
            foreach (var prop in props)
            {
                Match m = Regex.Match(prop.Key, @"(Library\d+)Loaded");
                if (!m.Success || prop.Value != "1")
                    continue;

                Library = props.TryGetValue($"{m.Groups[1].Value}Name", out string name) ? name : "Unknown Library";
                props.TryGetValue(m.Groups[1].Value, out string info);
                Match m2 = Regex.Match(info ?? "", "located at (.+)");
                if (m2.Success)
                    LibraryPath = m2.Success ? m2.Groups[1].Value : "Unknown Location";
                return true;
            }
            return false;
        }

        private Dictionary<string, string> parseXMLData(string xml)
        {
            return Regex.Matches(xml, "<Item Name=\"(.+?)\">(.+?)</Item>").Cast<Match>().ToDictionary(m => m.Groups[1].Value, m => m.Groups[2].Value);
        }

        #region unused
        /*
        public string SearchFiles(string filter, List<string> fields)
        {
            string url = "Files/Search?Action=JSON";
            if (fields != null && fields.Count > 0)
                url += $"&Fields={Uri.EscapeUriString(string.Join(",", fields))}";
            if (!string.IsNullOrEmpty(filter))
                url += $"&Query={Uri.EscapeUriString(filter)}";

            return HttpGet(url, out string result) == 200 ? result : null;
        }

        public bool SetField(int filekey, string field, string value, bool formattedValue = true)
        {
            value = Uri.EscapeUriString(value);
            field = Uri.EscapeUriString(field);
            string formatted = formattedValue ? "1" : "0";
            HttpGet($"File/SetInfo?File={filekey}&Field={field}&Value={value}&Formatted={formatted}", out string xml, false);
            if (xml != null && xml.Contains("Information=\"No changes.\""))
                status = 200;
            return status == 200;
        }

        public bool DeletePlaylist(string name)
        {
            return HttpGet($"Playlist/Delete?PlaylistType=Path&Playlist={Uri.EscapeUriString(name)}", out _) == 200;
        }

        public bool DeletePlaylist(int id)
        {
            return HttpGet($"Playlist/Delete?PlaylistType=ID&Playlist={id}", out _) == 200;
        }

        public bool ClearPlaylist(int id)
        {
            return HttpGet($"Playlist/Clear?PlaylistType=ID&Playlist={id}", out _) == 200;
        }

        public bool RemovePlaylistDuplicates(int id)
        {
            return HttpGet($"Playlist/RemoveDuplicates?PlaylistType=ID&Playlist={id}", out _) == 200;
        }

        public bool CreatePlaylist(string name, out int playlistID, bool overwrite = true)
        {
            playlistID = 0;
            string mode = overwrite ? "Overwrite" : "Rename";
            if (HttpGet($"Playlists/Add?Type=Playlist&Path={Uri.EscapeUriString(name)}&CreateMode={mode}", out string xml) != 200)
                return false;
            var m = Regex.Match(xml ?? "", @"""PlaylistID"">(-?\d+)<");
            return m.Success && int.TryParse(m.Groups[1].Value, out playlistID);
        }

        public bool AddPlaylistFiles(int id, List<int> fileIDs, bool removeDuplicates = false)
        {
            if (fileIDs == null || fileIDs.Count == 0)
                return true;

            string keys = string.Join(",", fileIDs);
            bool ok = (HttpGet($"Playlist/AddFiles?PlaylistType=ID&Playlist={id}&Keys={keys}", out string xml) == 200);
            if (ok && removeDuplicates)
                ok &= RemovePlaylistDuplicates(id);
            return ok;
        }

        public bool BuildPlaylist(string name, List<int> fileIDs, out int playlistID)
        {
            playlistID = 0;
            if (fileIDs == null || fileIDs.Count == 0)
                return CreatePlaylist(name, out playlistID);

            string keys = string.Join(",", fileIDs);
            if (HttpGet($"Playlist/Build?Playlist={Uri.EscapeUriString(name)}&Keys={keys}", out string xml) != 200)
                return false;
            var m = Regex.Match(xml ?? "", @"""PlaylistID"">(-?\d+)<");
            return m.Success && int.TryParse(m.Groups[1].Value, out playlistID);
        }

        public bool CreateField(string name)
        {
            Console.WriteLine($"  Creating field '{name}'");
            name = Uri.EscapeUriString(name);
            return HttpGet($"Library/CreateField?Name={name}", out string xml) == 200;
        }

        */
        #endregion
    }
}
