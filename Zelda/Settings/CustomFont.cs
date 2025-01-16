using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Zelda
{
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
}
