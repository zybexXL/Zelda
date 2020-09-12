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
        //[DataMember] public bool SkipPlaylistCount = false;

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
            CheckSettings();
        }

        private void CheckSettings()
        {
            if (EditorFont == null) EditorFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            if (OutputFont == null) OutputFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            if (RenderFont == null) RenderFont = new CustomFont("Segoe UI", 9F, Color.White, Color.FromArgb(0, 48, 48));
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
                    settings.CheckSettings();
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
        Font _font;
        public Font font { get { return getFont(); } set { setFont(value); } }
        public Color ForeColor { get { return getColor(fgcolor, Color.Black); } set { fgcolor = hexColor(value); } }
        public Color BackColor { get { return getColor(bgcolor, Color.White); } set { bgcolor = hexColor(value); } }
        public bool isBold { get { return style != null && style.ToLower().Contains("bold"); } }
        public bool isItalic { get { return style != null && style.ToLower().Contains("italic"); } }
        public bool isRegular { get { return !isBold && !isItalic; } }

        [DataMember] public string family;
        [DataMember] public string style;
        [DataMember] public float size;
        [DataMember] public string fgcolor;
        [DataMember] public string bgcolor;

        public CustomFont()
        { }

        public CustomFont(string family, float size, Color foreground, Color background)
        {
            _font = null;
            this.family = family;
            this.size = size;
            this.style = "Regular";
            ForeColor = foreground;
            BackColor = background;
        }

        public CustomFont(Font font, Color foreground, Color background)
        {
            this.font = font;
            ForeColor = foreground;
            BackColor = background;
        }

        private Font getFont()
        {
            if (_font != null) return _font;

            try
            {
                if (!Enum.TryParse<FontStyle>(style, out FontStyle fStyle))
                    fStyle = FontStyle.Regular;
                _font = new Font(family, size, fStyle);
                return _font;
            }
            catch { }
            _font = new Font("Consolas", 10F);
            return _font;
        }

        private void setFont(Font font)
        {
            _font = font;
            family = font.FontFamily.Name;
            size = font.Size;
            style = font.Style.ToString();
        }

        private Color getColor(string color, Color defaultColor)
        {
            if (!string.IsNullOrEmpty(color))
                try
                {
                    return Color.FromArgb(int.Parse("FF" + color, System.Globalization.NumberStyles.HexNumber));
                }
                catch { }
            return defaultColor;
        }

        private string hexColor(Color color)
        {
            return color.ToArgb().ToString("X8").Substring(2);
        }
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
