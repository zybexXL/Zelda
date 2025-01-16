using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Zelda
{
    public class Settings : ConfigFile
    {
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

        [JsonIgnore]
        public Skin Skin { get; set; }

        public Settings()
        {
            // defaults for deserialization
            SafeMode = true;
            HighlightComments = true;
            EditorFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            OutputFont = new CustomFont("Consolas", 11.25F, Color.Black, Color.White);
            RenderFont = new CustomFont("Segoe UI", 9F, Color.White, Color.FromArgb(0, 48, 48));
        }

        public static Settings Load()
        {
            var settings = Load<Settings>(Constants.SettingsFile) ?? new Settings();

            settings.Skin = Skin.Load();
            if (settings.Skin.isDefault)
                settings.SaveSkin();
            else
                settings.ApplySkin();

            if (settings.isDefault || settings.version < 2)
            {
                settings.version = 2;
                settings.Save();
            }

            return settings;
        }

        public bool Save()
        {
            return Save(Constants.SettingsFile);
        }

        public void ApplySkin()
        {
            RenderFont.ForeColor = GetColor(SkinElement.RenderText);
            RenderFont.BackColor = GetColor(SkinElement.RenderBack);
            OutputFont.ForeColor = GetColor(SkinElement.OutputText);
            OutputFont.BackColor = GetColor(SkinElement.OutputBack);
            EditorFont.ForeColor = GetColor(SkinElement.EditorText);
            EditorFont.BackColor = GetColor(SkinElement.EditorBack);
        }

        public bool SaveSkin()
        {
            Skin.RenderText = "#" + RenderFont.fgcolor;
            Skin.RenderBack = "#" + RenderFont.bgcolor;
            Skin.OutputText = "#" + OutputFont.fgcolor;
            Skin.OutputBack = "#" + OutputFont.bgcolor;
            Skin.EditorText = "#" + EditorFont.fgcolor;
            Skin.EditorBack = "#" + EditorFont.bgcolor;
            return Skin.Save();
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

        public int GetAlpha(SkinElement element)
        {
            uint value = (uint)(Skin?.GetColor(element).ToArgb() ?? 0) >> 24;
            return (int)value;
        }
    }
}
