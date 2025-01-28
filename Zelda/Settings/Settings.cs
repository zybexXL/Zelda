using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Zelda
{
    public class Settings : ConfigFile
    {
        public int version { get; set; } = 2;
        public bool SaveExpressions { get; set; } = true;
        public bool SaveState { get; set; } = true;
        public bool ReloadPlaylist { get; set; } = true;
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
        public SkinTheme Theme {  get; set; } = SkinTheme.Auto;

        public string FontEditor { get; set; }
        public string FontOutput { get; set; }
        public string FontRender { get; set; }

        [JsonIgnore] public Font EditorFont { get; set; }
        [JsonIgnore] public Font OutputFont { get; set; }
        [JsonIgnore] public Font RenderFont { get; set; }

        [JsonIgnore] public Skin Skin { get; set; }

        // obsolete properties, to remove on future version
#pragma warning disable CS0612 // Type or member is obsolete
        [JsonPropertyName("EditorFont")]
        public CustomFont ObsoleteEditorFont { get; set; }

        [JsonPropertyName("OutputFont")]
        public CustomFont ObsoleteOutputFont { get; set; }
        [JsonPropertyName("RenderFont")]
        public CustomFont ObsoleteRenderFont { get; set; }
#pragma warning restore CS0612 // Type or member is obsolete

        public Settings()
        {
            // defaults for deserialization
            SafeMode = true;
            HighlightComments = true;
            FontEditor = GetFontString(Constants.DefaultEditorFont);
            FontOutput = GetFontString(Constants.DefaultOutputFont);
            FontRender = GetFontString(Constants.DefaultRenderFont);
        }

        public static Settings Load()
        {
            var settings = Load<Settings>(Constants.SettingsFile) ?? new Settings();
            settings.Skin = Skin.LoadTheme(settings.Theme);
            settings.Migrate();

            return settings;
        }

        private void Migrate()
        {
            if (isDefault || version < 3)
            {
                // migrate font setting
                if (ObsoleteEditorFont != null)
                    EditorFont = ParseFont(ObsoleteEditorFont.ToString());
                if (ObsoleteOutputFont != null)
                    OutputFont = ParseFont(ObsoleteOutputFont.ToString());
                if (ObsoleteRenderFont != null)
                    RenderFont = ParseFont(ObsoleteRenderFont.ToString());

                ObsoleteRenderFont = null;
                ObsoleteOutputFont = null;
                ObsoleteEditorFont = null;

                version = 3;
                Save();
            }

            EditorFont = ParseFont(FontEditor);
            OutputFont = ParseFont(FontOutput);
            RenderFont = ParseFont(FontRender);
        }

        public bool Save()
        {
            FontEditor = GetFontString(EditorFont);
            FontOutput = GetFontString(OutputFont);
            FontRender = GetFontString(RenderFont);
            return Save(Constants.SettingsFile);
        }

        public Font ParseFont(string name)
        {
            string family = Constants.DefaultEditorFont.Name;
            float size = Constants.DefaultEditorFont.Size;
            FontStyle style = Constants.DefaultEditorFont.Style;

            Match m = Regex.Match(name ?? "", @"(.+?),\s*(\d+(\.\d+)?)\s*,?(.*)");
            if (m.Success)
            {
                family = m.Groups[1].Value.Trim();
                float.TryParse(m.Groups[2].Value.Trim(), out size);
                if (!string.IsNullOrEmpty(m.Groups[4].Value))
                    Enum.TryParse(m.Groups[4].Value, out style);
            }
            Font font = new Font(family, size, style);
            return font;
        }

        public string GetFontString(Font font)
        {
            return $"{font.Name}, {font.Size}, {font.Style}";
        }

        public Color GetColor(ELTokenType token)
        {
            return Skin?.GetColor(token) ?? Color.Black;
        }

        public Color GetColor(SkinElement element, bool removeAlpha = false)
        {
            Color color = Skin?.GetColor(element) ?? Color.Black;
            return removeAlpha ? Color.FromArgb(color.ToArgb() & 0x00FFFFFF) : color;
        }

        public string GetHexColor(Color color, bool removeNoTransparency = true, bool addHash = true)
        {
            string hex = color.ToArgb().ToString("X8").Substring(2);
            if (removeNoTransparency && hex.Length == 8 && hex.StartsWith("FF"))
                hex = hex.Substring(2);
            return addHash ? "#" + hex : hex;
        }

        public int GetAlpha(SkinElement element)
        {
            uint value = (uint)(Skin?.GetColor(element).ToArgb() ?? 0) >> 24;
            return (int)value;
        }
    }
}
