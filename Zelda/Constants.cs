using System;
using System.Drawing;
using System.IO;

namespace Zelda
{
    public class Constants
    {
        static string _dataFolder;
        public static string DataFolder
        {
            get
            {
                if (_dataFolder == null) _dataFolder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Zelda");
                return _dataFolder;
            }
        }

        public static string SettingsFile = Path.Combine(DataFolder, "zelda.json");
        public static string StateFile = Path.Combine(DataFolder, "zeldaState.json");
        public static string LightSkinFile = Path.Combine(DataFolder, "zeldaLight.json");
        public static string DarkSkinFile = Path.Combine(DataFolder, "zeldaDark.json");
        public static string WebView2Data = Path.Combine(DataFolder, "WebView2");

        public static Font DefaultEditorFont = new Font("Consolas", 11.25F, FontStyle.Regular);
        public static Font DefaultOutputFont = new Font("Consolas", 11.25F, FontStyle.Regular);
        public static Font DefaultRenderFont = new Font("Segoe UI", 9F, FontStyle.Regular);

        public static Skin LightSkin = new Skin()
        {
            Filename = LightSkinFile,

            ExpressionText = "Black",
            ExpressionFunction = "Blue",
            ExpressionMath = "DarkCyan",
            ExpressionField = "Green",
            ExpressionVariable = "MediumSeaGreen",
            ExpressionNumber = "Brown",
            ExpressionHTML = "DeepPink",
            ExpressionSymbol = "Red",
            ExpressionEscaped = "DarkBlue",
            ExpressionLiteral = "DarkOrange",
            ExpressionComment = "Gray",
            ExpressionWhitespace = "DimGray",

            Selection = "PaleGoldenrod",
            HighlightFunction = "Blue,13%",     // 13% ~~ 32/256
            HighlightSeparator = "Red,25%",     // 25% ~~ 64/256
            HighlightSelection = "Cyan,38%",    // 38% ~~ 96/256

            EditorText = "Black",
            EditorBack = "White",
            OutputText = "Black",
            OutputBack = "White",
            RenderText = "White",
            RenderBack = "#252525"
        };

        public static Skin DarkSkin = new Skin()
        {
            Filename = DarkSkinFile,

            ExpressionText = "#F0F0F0",
            ExpressionFunction = "DeepSkyBlue",
            ExpressionMath = "Cyan",
            ExpressionField = "LimeGreen",
            ExpressionVariable = "GreenYellow",
            ExpressionNumber = "#D27B53",
            ExpressionHTML = "HotPink",
            ExpressionSymbol = "#FF4040",
            ExpressionEscaped = "#FFFF00",
            ExpressionLiteral = "#FFA500",
            ExpressionComment = "Gray",
            ExpressionWhitespace = "#6D6D6D",

            Selection = "DimGray",
            HighlightFunction = "DarkCyan,40%",
            HighlightSeparator = "Yellow,20%",
            HighlightSelection = "Green,80%",

            EditorText = "Silver",
            EditorBack = "#1E1E1E",
            OutputText = "Chartreuse",
            OutputBack = "#1E1E1E",
            RenderText = "#F5F5F5",
            RenderBack = "#242424"
        };
    }
}
