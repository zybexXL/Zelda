using System;
using System.Drawing;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace Zelda
{
    public enum SkinElement
    {
        Token, Whitespace, EditorText, EditorBack, OutputText, OutputBack, RenderText, RenderBack,
        Selection, HighlightSelection, HighlightFunction, HighlightSeparator
    }

    public enum SkinTheme { Auto, Light, Dark }

    public class Skin : ConfigFile
    {
        [JsonIgnore]
        public string Filename { get; set; }
        
        public string ExpressionText { get; set; }
        public string ExpressionFunction { get; set; }
        public string ExpressionMath { get; set; }
        public string ExpressionField { get; set; }
        public string ExpressionVariable { get; set; }
        public string ExpressionNumber { get; set; }
        public string ExpressionHTML { get; set; }
        public string ExpressionSymbol { get; set; }
        public string ExpressionEscaped { get; set; }
        public string ExpressionLiteral { get; set; }
        public string ExpressionComment { get; set; }
        public string ExpressionWhitespace { get; set; }

        public string Selection { get; set; }
        public string HighlightFunction { get; set; }
        public string HighlightSeparator { get; set; }
        public string HighlightSelection { get; set; }

        public string EditorText { get; set; }
        public string EditorBack { get; set; }
        public string OutputText { get; set; }
        public string OutputBack { get; set; }
        public string RenderText { get; set; }
        public string RenderBack { get; set; }

        
        public Skin() { }

        public static Skin LoadTheme(SkinTheme theme, bool loadDefault = false)
        {
            bool dark = false;
            switch (theme)
            {
                default:
                case SkinTheme.Auto: dark = Native.isWindowsDarkTheme(); break;
                case SkinTheme.Dark: dark = true; break;
                case SkinTheme.Light: dark = false; break;
            }

            Skin skin = dark ? Constants.DarkSkin : Constants.LightSkin;
            if (!loadDefault)
            {
                var loaded = Load(skin.Filename);
                if (loaded != null) skin = loaded;
            }

            if (!File.Exists(skin.Filename))
                skin.Save();

            return skin;
        }

        public static Skin Load(string filename)
        {
            Skin skin = Load<Skin>(filename);
            if (skin != null)
                skin.Filename = filename;
            return skin;
        }

        public bool Save()
        {
            return Save(Filename);
        }

        public Color GetColor(ELTokenType element)
        {
            switch (element)
            {
                case ELTokenType.Function: return ParseColor(ExpressionFunction);
                case ELTokenType.Math: return ParseColor(ExpressionMath);
                case ELTokenType.Field: return ParseColor(ExpressionField);
                case ELTokenType.Variable: return ParseColor(ExpressionVariable);
                case ELTokenType.Number: return ParseColor(ExpressionNumber);
                case ELTokenType.HTML: return ParseColor(ExpressionHTML);
                case ELTokenType.Symbol: return ParseColor(ExpressionSymbol);
                case ELTokenType.Escaped: return ParseColor(ExpressionEscaped);
                case ELTokenType.Literal: return ParseColor(ExpressionLiteral);
                case ELTokenType.Comment: return ParseColor(ExpressionComment);
                default:
                case ELTokenType.Default: return ParseColor(ExpressionText);
            }
        }

        public Color GetColor(SkinElement element)
        {
            switch (element)
            {
                case SkinElement.Token: return ParseColor(ExpressionText);
                case SkinElement.Whitespace: return ParseColor(ExpressionWhitespace);
                case SkinElement.EditorText: return ParseColor(EditorText);
                case SkinElement.EditorBack: return ParseColor(EditorBack, KnownColor.White);
                case SkinElement.OutputText: return ParseColor(OutputText);
                case SkinElement.OutputBack: return ParseColor(OutputBack, KnownColor.White);
                case SkinElement.RenderText: return ParseColor(RenderText, KnownColor.White);
                case SkinElement.RenderBack: return ParseColor(RenderBack, KnownColor.Black);
                case SkinElement.Selection: return ParseColor(Selection, KnownColor.PaleGoldenrod);
                case SkinElement.HighlightSelection: return ParseColor(HighlightSelection, KnownColor.Blue, 32);
                case SkinElement.HighlightFunction: return ParseColor(HighlightFunction, KnownColor.Red, 64);
                case SkinElement.HighlightSeparator: return ParseColor(HighlightSeparator, KnownColor.Cyan, 96);
                default:
                    return Color.Black;
            }
        }

        public Color ParseColor(string colorname, KnownColor defaultColor = KnownColor.Black, int defaultAlpha = 0xFF)
        {
            if (!string.IsNullOrWhiteSpace(colorname))
                try
                {
                    colorname = colorname.Trim();
                    if (colorname.Contains(','))
                    {
                        var m = Regex.Match(colorname, @",\s*(\d+)(%?)");
                        colorname = colorname.Split(',')[0].Trim();
                        if (m.Success) defaultAlpha = int.Parse(m.Groups[1].Value);
                        if (m.Groups[2].Value == "%") defaultAlpha = defaultAlpha * 255 / 100;
                        if (defaultAlpha > 255) defaultAlpha = 255;
                    }

                    // color name
                    if (colorname.StartsWith('#') || !Enum.TryParse(colorname, true, out defaultColor))
                    {
                        // hex color
                        colorname = colorname.Trim('#');
                        if (uint.TryParse(colorname, System.Globalization.NumberStyles.HexNumber, null, out uint value))
                        {
                            if (colorname.Length <= 6) value = ((uint)defaultAlpha << 24) + value;
                            return Color.FromArgb((int)value);
                        }
                    }

                    //return Color.FromArgb(value >> 24, (value >> 16) & 0xFF, (value >> 8) & 0xFF, value & 0xFF);
                    //return Color.FromArgb(int.Parse("FF" + color, System.Globalization.NumberStyles.HexNumber));
                }
                catch { }
            return Color.FromArgb(defaultAlpha, Color.FromKnownColor(defaultColor));
        }
    }
}