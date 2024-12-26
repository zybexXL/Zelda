using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json.Serialization;

namespace Zelda
{
    public class Settings
    {
        public bool isDefault = true;

        public int version { get; set; } = 2;
        public bool SaveExpressions { get; set; } = true;
        public bool SaveState { get; set; } = true;
        public bool ReloadPlaylist { get; set; } = true;
        public bool StartMaximized { get; set; } = false;        // deprecated, Zelda saves/restores last state
        public bool ShowLineNumbers { get; set; } = true;
        public bool WrapIndent { get; set; } = true;
        public bool ReplaceTabs { get; set; } = true;
        public bool ShowAPICallTime { get; set; } = true;
        public bool FastStart { get; set; } = false;
        public bool UseMCWS { get; set; } = false;
        public string MCWSServer { get; set; } = "http://localhost:52199";
        public string MCWSUsername { get; set; } = null;
        public string MCWSPassword { get; set; } = null;

        public int EvaluateDelay { get; set; } = 500;
        public bool HighlightSyntax { get; set; } = true;
        public bool HighlightFunction { get; set; } = true;
        public bool HighlightDelimiters { get; set; } = true;
        public bool HighlightComments { get; set; } = true;
        public bool SafeMode { get; set; } = true;
        public List<string> ExtraFunctions { get; set; } = new List<string>();
        public string TooltipFolder { get; set; } = null;
        public string PlaylistFilter { get; set; } = null;

        [JsonPropertyOrder(101)] public CustomFont EditorFont { get; set; }
        [JsonPropertyOrder(102)] public CustomFont OutputFont { get; set; }
        [JsonPropertyOrder(103)] public CustomFont RenderFont { get; set; }

        //public string CurrentProfile { get; set; }
        //public List<SyntaxProfile> SyntaxProfiles { get; set; }

        public Settings()
        {
            // defaults for deserialization
            SafeMode = true;
            HighlightComments = true;
            EditorFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            OutputFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            RenderFont = new CustomFont("Segoe UI", 9F, Color.White, Color.FromArgb(0, 48, 48));
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
                    if (settings.version < 2)
                    {
                        settings.version = 2;
                        settings.Save();
                    }
                    return settings;
                }
            }
            catch { }

            var newSettings = DefaultSettings();
            newSettings.Save();

            return newSettings;
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
                string json = Util.JsonSerialize(this, indented: true);
                File.WriteAllText(Constants.SettingsFile, json);
                return true;
            }
            catch { }    // errors are handled by the caller when settings is null
            return false;
        }
    }

    public class CustomFont
    {
        [JsonIgnore] Font _font;
        [JsonIgnore] public Font font { get { return getFont(); } set { setFont(value); } }
        [JsonIgnore] public Color ForeColor { get { return getColor(fgcolor, Color.Black); } set { fgcolor = hexColor(value); } }
        [JsonIgnore] public Color BackColor { get { return getColor(bgcolor, Color.White); } set { bgcolor = hexColor(value); } }
        [JsonIgnore] public bool isBold { get { return style != null && style.ToLower().Contains("bold"); } }
        [JsonIgnore] public bool isItalic { get { return style != null && style.ToLower().Contains("italic"); } }
        [JsonIgnore] public bool isRegular { get { return !isBold && !isItalic; } }

        public string family { get; set; }
        public string style { get; set; }
        public float size { get; set; }
        public string fgcolor { get; set; }
        public string bgcolor { get; set; }

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

    public class SyntaxProfile
    {
        public string name { get; set; }
        public List<SyntaxElement> elements { get; set; }
    }

    public class SyntaxElement
    {
        public ELTokenType element { get; set; }
        public Color foreground { get; set; }
        public Color background { get; set; }
    }
}
