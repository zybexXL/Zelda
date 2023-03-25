using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zelda
{
    // holds Movie Info for Datagrid display
    // tracks changes to fields
    // processes info from JRiver, extracts FTitle and FYear from file name/path
    public enum PosterSize { Small, Medium, Large, Original }
    public enum ImageType { Poster, Profile }


    public class JRFile
    {
        public int Key { get; set; }
        public string Name { get { return this["name"]; } }
        public string Year { get { return this["date (year)"]; } }
        public string Filename { get { return this["filename"]; } }
        public string MediaType { get { return this["media type"]; } }
        public string MediaSubType { get { return this["media sub type"]; } }


        //public DateTime DateImported {
        //    get {
        //        if (fields.ContainsKey("date imported") && long.TryParse(fields["date imported"], out long seconds))
        //            return Util.EpochToDateTime(seconds).ToLocalTime();
        //        return DateTime.MinValue;
        //    } }

        //public DateTime DateRelease
        //{
        //    get
        //    {
        //        if (fields.ContainsKey("date (release)") && long.TryParse(fields["date (release)"], out long seconds))
        //            return Util.EpochToDateTime(seconds).ToLocalTime();
        //        return DateTime.MinValue;
        //    }
        //}

        public Dictionary<string, string> fields { get; private set; } = new Dictionary<string, string>();       // current values

        public string this[string field]
        {
            get { if (fields.TryGetValue(field.ToLower(), out string val)) return val; else return null; }
            set { fields[field.ToLower()] = value; }
        }

        public JRFile(int key, Dictionary<string, string> values)
        {
            Key = key;
            if (values != null)
                foreach (var pair in values)
                    fields[pair.Key.ToLower()] = pair.Value;
        }

        public static List<JRFile> FromJsonArray(string json)
        {
            List<JRFile> files = new List<JRFile>();

            try
            {
                if (!json.Trim().StartsWith("[")) json = $"[{json}]";
                var objList = JArray.Parse(json ?? "[ ]");
                foreach (JObject obj in objList)
                {
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    var values = obj.Properties().ToDictionary(p => p.Name.ToLower(), p => p.Value.ToString());
                    if (!int.TryParse(values["key"], out int key))
                        key = 0;
                    files.Add(new JRFile(key, values));
                }
                return files;
            }
            catch (Exception ex) { Logger.Log(ex); }
            return null;
        }
        
        public static JRFile FromJson(string json)
        {
            try
            {
                if (json.Trim().StartsWith("["))
                    return FromJsonArray(json)?.FirstOrDefault();

                var obj = JObject.Parse(json);
                Dictionary<string, string> data = new Dictionary<string, string>();
                var values = obj.Properties().ToDictionary(p => p.Name.ToLower(), p => p.Value.ToString());
                if (!int.TryParse(values["key"], out int key))
                    key = 0;
                return new JRFile(key, values);
            }
            catch (Exception ex) { Logger.Log(ex); }
            return null;
        }

        public void copyFrom(JRFile otherFile)
        {
            if (otherFile != null)
                fields = otherFile.fields;
        }

        public override string ToString()
        {
            return $"{Name} ({Year})";
        }
    }
}
