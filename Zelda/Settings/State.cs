using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zelda
{
    [DataContract]
    public class TabExpression
    {
        [DataMember] public string name;
        [DataMember] public string content;
        [DataMember] public int position;

        public TabExpression(string title, string text, int pos)
        {
            name = title;
            content = text;
            position = pos;
        }
    }

    [DataContract]
    public class State
    {
        public bool isDefault = true;

        [DataMember] public List<TabExpression> Tabs = new List<TabExpression>();
        [DataMember] public int CurrentTab = 0;
        [DataMember] public int OutputTab = 0;
        [DataMember] public bool FunctionHelper = true;
        [DataMember] public bool LineWrap = false;
        [DataMember] public bool Whitespace = false;
        [DataMember] public bool TableShowAll = false;
        [DataMember] public List<string> TableFields = new List<string>();
        [DataMember] public int Zoom = 0;
        [DataMember] public string Playlist;
        [DataMember] public string Filename;

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
                string json = Util.JsonSerialize(this, indent: true);
                File.WriteAllText(Constants.StateFile, json);
                return true;
            }
            catch { }
            return false;
        }
    }
}
