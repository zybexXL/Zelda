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
    public class Settings
    {
        public bool isDefault = true;

        [DataMember] public bool SaveExpressions = true;
        [DataMember] public bool SaveState = true;
        [DataMember] public bool ReloadPlaylist = true;
        [DataMember] public bool StartMaximized = false;
        [DataMember] public bool ShowLineNumbers = true;
        [DataMember] public bool WrapIndent = true;
        [DataMember] public bool ReplaceTabs = true;
        [DataMember] public bool ShowAPICallTime = true;

        [DataMember] public int EvaluateDelay = 500;
        [DataMember] public bool HighlightSyntax = true;
        [DataMember] public bool HighlightFunction = true;
        [DataMember] public bool HighlightDelimiters = true;
        [DataMember] public List<string> ExtraFunctions = new List<string>();

        [DataMember] public CustomFont EditorFont;
        [DataMember] public CustomFont OutputFont;
        [DataMember] public CustomFont RenderFont;

        [DataMember] public string CurrentProfile;
        [DataMember] public List<SyntaxProfile> SyntaxProfiles;

        public Settings()
        {
        }

        public static Settings DefaultSettings()
        {
            Settings settings = new Settings();
            return settings;
        }

        public static Settings Load()
        {
            try
            {
                if (File.Exists(Constants.SettingsFile))
                {
                    string json = File.ReadAllText(Constants.SettingsFile);
                    var settings = Util.JsonDeserialize<Settings>(json);
                    settings.isDefault = false;
                    return settings;
                }
            }
            catch { }
            return DefaultSettings();
        }

        public bool Save()
        {
            try
            {
                Directory.CreateDirectory(Constants.DataFolder);
                if (File.Exists(Constants.SettingsFile))
                {
                    string bak = Path.ChangeExtension(Constants.SettingsFile, ".bak");
                    File.Delete(bak);
                    File.Move(Constants.SettingsFile, bak);
                }

                isDefault = false;
                string json = Util.JsonSerialize(this, indent: true);
                File.WriteAllText(Constants.SettingsFile, json);
                return true;
            }
            catch { }    // errors are handled by the caller when settings is null
            return false;
        }
    }

    [DataContract]
    public class CustomFont
    {
        [DataMember] public Font font;
        [DataMember] public string family;
        [DataMember] public string style;
        [DataMember] public int size;
        [DataMember] public Color foreground;
        [DataMember] public Color background;
    }

    [DataContract]
    public class SyntaxProfile
    {
        [DataMember] public string name;
        [DataMember] public List<SyntaxElement> elements;
    }

    [DataContract]
    public class SyntaxElement
    {
        [DataMember] public ELTokenType element;
        [DataMember] public Color foreground;
        [DataMember] public Color background;
    }
}
