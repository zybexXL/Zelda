using System;
using System.Collections.Generic;
using System.Linq;

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
                var data = Util.JsonDeserialize<Dictionary<string, object>[]>(json);
                foreach (var dict in data)
                {
                    var values = dict.ToDictionary(p => p.Key.ToLower(), p => p.Value.ToString());
                    if (!values.ContainsKey("key") || !int.TryParse(values["key"], out int key))
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
            return FromJsonArray(json)?.FirstOrDefault();
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
