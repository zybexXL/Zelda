using System;
using System.Drawing;
using System.Text.Json.Serialization;

namespace Zelda
{
    [Obsolete]
    public class CustomFont
    {
        [JsonIgnore] Font _font;
        [JsonIgnore] public Font font { get { return getFont(); } set { setFont(value); } }
        [JsonIgnore] public bool isBold { get { return style != null && style.ToLower().Contains("bold"); } }
        [JsonIgnore] public bool isItalic { get { return style != null && style.ToLower().Contains("italic"); } }
        [JsonIgnore] public bool isRegular { get { return !isBold && !isItalic; } }

        public string family { get; set; }
        public string style { get; set; }
        public float size { get; set; }

        public override string ToString()
        {
            return $"{family}, {size}, {style ?? "Regular"}";
        }

        public CustomFont()
        { }

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
    }
}
