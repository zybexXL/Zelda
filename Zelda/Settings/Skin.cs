using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Zelda
{
    public enum SkinElement
    {
        Token, Whitespace, EditorText, EditorBack, OutputText, OutputBack, RenderText, RenderBack,
        Selection, HighlightSelection, HighlightFunction, HighlightSeparator
    }

    public class Skin : ConfigFile
    {
        public string ExpressionText { get; set; } = "Black";
        public string ExpressionFunction { get; set; } = "Blue";
        public string ExpressionMath { get; set; } = "DarkCyan";
        public string ExpressionField { get; set; } = "Green";
        public string ExpressionVariable { get; set; } = "MediumSeaGreen";
        public string ExpressionNumber { get; set; } = "Brown";
        public string ExpressionHTML { get; set; } = "DeepPink";
        public string ExpressionSymbol { get; set; } = "Red";
        public string ExpressionEscaped { get; set; } = "DarkBlue";
        public string ExpressionLiteral { get; set; } = "DarkOrange";
        public string ExpressionComment { get; set; } = "Gray";
        public string ExpressionWhitespace { get; set; } = "DimGray";

        public string Selection { get; set; } = "PaleGoldenrod";
        public string HighlightFunction { get; set; } = "Blue,13%";     // 13% ~~ 32/256
        public string HighlightSeparator { get; set; } = "Red,25%";     // 25% ~~ 64/256
        public string HighlightSelection { get; set; } = "Cyan,38%";    // 38% ~~ 96/256

        public string EditorText { get; set; } = "Black";
        public string EditorBack { get; set; } = "White";
        public string OutputText { get; set; } = "Black";
        public string OutputBack { get; set; } = "White";
        public string RenderText { get; set; } = "White";
        public string RenderBack { get; set; } = "#252525";

        
        public Skin() { }

        public static Skin Load()
        {
            return Load<Skin>(Constants.SkinFile) ?? new Skin();
        }

        public bool Save()
        {
            return Save(Constants.SkinFile);
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

        public string hexColor(Color color, bool removeNoTransparency = true, bool addHash = true)
        {
            string hex = color.ToArgb().ToString("X8").Substring(2);
            if (removeNoTransparency && hex.Length == 8 && hex.StartsWith("FF"))
                hex = hex.Substring(2);
            return addHash ? "#" + hex : hex;
        }
    }
}