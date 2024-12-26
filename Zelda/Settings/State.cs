using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Zelda
{
    public class TabExpression
    {
        public string name { get; set; }
        public string content { get; set; }
        public int position { get; set; }
        public string linkedField { get; set; }

        public TabExpression() { }

        public TabExpression(string title, string text, int pos, string field = null)
        {
            name = title;
            content = text;
            position = pos;
            linkedField = field;
        }
    }

    public class State
    {
        [JsonIgnore]
        public bool isDefault = true;

        public List<TabExpression> Tabs { get; set; } = new List<TabExpression>();
        public int CurrentTab { get; set; } = 0;
        public int OutputTab { get; set; } = 0;
        public bool FunctionHelper { get; set; } = true;
        public bool LineWrap { get; set; } = false;
        public bool Whitespace { get; set; } = false;
        public bool TableShowAll { get; set; } = false;
        public List<string> TableFields { get; set; } = new List<string>();
        public int Zoom { get; set; } = 0;
        public string Playlist { get; set; }
        public string Filename { get; set; }
        public Rectangle Dimensions { get; set; } = Rectangle.Empty;
        public bool Maximized { get; set; } = false;
        public int SplitPosition { get; set; } = 0;

        public State()
        {
        }

        public static State Load()
        {
            try
            {
                if (File.Exists(Constants.StateFile))
                {
                    string json = File.ReadAllText(Constants.StateFile);
                    var state = Util.JsonDeserialize<State>(json);
                    state.isDefault = false;
                    return state;
                }
            }
            catch { }
            return new State();
        }

        public bool Save()
        {
            try
            {
                Directory.CreateDirectory(Constants.DataFolder);
                if (File.Exists(Constants.StateFile))
                {
                    string bak = Path.ChangeExtension(Constants.StateFile, ".bak");
                    File.Delete(bak);
                    File.Move(Constants.StateFile, bak);
                }
                isDefault = false;
                string json = Util.JsonSerialize(this, indented: true);
                File.WriteAllText(Constants.StateFile, json);
                return true;
            }
            catch { }
            return false;
        }
    }
}
