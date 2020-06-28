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
        public int JRKey { get; set; }
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

        Dictionary<string, string> fields = new Dictionary<string, string>();       // current values

        public string this[string field]
        {
            get { if (fields.TryGetValue(field.ToLower(), out string val)) return val; else return null; }
            set { fields[field.ToLower()] = value; }
        }


        public JRFile(int key, Dictionary<string, string> values)
        {
            JRKey = key;
            if (values != null)
                foreach (var pair in values)
                    fields[pair.Key.ToLower()] = pair.Value;
        }

        public void updateFields(List<string> names, JRiverAPI api, bool formatted = true, bool refreshAll = false)
        {
            try
            {
                List<string> fetch = refreshAll ? names : new List<string>();
                if (!refreshAll)
                    foreach (var field in names)
                        if (!fields.ContainsKey(field.ToLower()))
                            fetch.Add(field.ToLower());

                if (fetch.Count > 0)
                {
                    Dictionary<string, string> values = api.getFieldValues(JRKey, fetch, formatted);
                    if (values == null) return;
                    foreach (var key in values.Keys)
                        fields[key.ToLower()] = values[key];
                }
            }
            catch { }
        }

        public override string ToString()
        {
            return $"{Name} ({Year})";
        }
    }
}
