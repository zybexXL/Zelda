using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zelda
{
    public class ELFont
    {
        public string font = null;
        public int size = -1;
        public int alpha = -1;
        public Color color = Color.Empty;
        public Color bgcolor = Color.Empty;

        public ELFont() { }

        public ELFont(string face, int sz, int opacity, Color fg, Color bg)
        {
            font = face;
            size = sz;
            alpha = opacity;
            color = fg;
            bgcolor = bg;
        }

        public static ELFont Parse(string tag)
        {
            ELFont font = new ELFont();
            if (tag == null) return font;

            var p = Regex.Match(tag, @"\bsize\s*=\s*""?(\d+)%?""?", RegexOptions.IgnoreCase);
            if (p.Success)
                font.size = int.Parse(p.Groups[1].Value);

            p = Regex.Match(tag, @"\bcolor\s*=\s*""?#?([a-f0-9]+)""?", RegexOptions.IgnoreCase);
            if (p.Success)
                font.color = ParseColor(p.Groups[1].Value);

            p = Regex.Match(tag, @"\bbgcolor\s*=\s*""?#?([a-f0-9]+)""?", RegexOptions.IgnoreCase);
            if (p.Success)
                font.bgcolor = ParseColor(p.Groups[1].Value);

            p = Regex.Match(tag, @"\bface\s*=\s*""?([\w\s]+)""?", RegexOptions.IgnoreCase);
            if (p.Success)
                font.font = p.Groups[1].Value;

            p = Regex.Match(tag, @"\balpha\s*=\s*""?(\d+)%?""?", RegexOptions.IgnoreCase);
            if (p.Success)
                font.alpha = int.Parse(p.Groups[1].Value);

            return font;
        }

        public string ToHTML()
        {
            string style = "<span style=\"";
            if (font != null) style += $@" font-family: '{font}';";
            if (size >= 0) style += $" font-size: {size}%;";
            if (alpha >= 0) style += $" opacity: {(alpha / 100.0).ToString("0.0", CultureInfo.InvariantCulture)};";
            if (color != Color.Empty) style += $" color: #{color.R:X2}{color.G:X2}{color.B:X2};";
            if (bgcolor != Color.Empty) style += $" background-color: #{bgcolor.R:X2}{bgcolor.G:X2}{bgcolor.B:X2};";

            return style + "\">";
        }

        public string ToExpression()
        {
            string style = "<font";
            if (font != null) style += $" face=\"{font}\"";
            if (size >= 0) style += $" size=\"{size}\"";
            if (alpha >= 0) style += $" alpha=\"{alpha}\"";
            if (color != Color.Empty) style += $" color=\"#{color.R:X2}{color.G:X2}{color.B:X2}\"";
            if (bgcolor != Color.Empty) style += $" bgcolor=\"#{bgcolor.R:X2}{bgcolor.G:X2}{bgcolor.B:X2}\"";

            return style + ">";
        }

        public static Color ParseColor(string color)
        {
            string hex="0123456789abcdef";
            color = color.PadLeft(6, '0').ToLower();
            int r = hex.IndexOf(color[0]) * 16 + hex.IndexOf(color[1]);
            int g = hex.IndexOf(color[2]) * 16 + hex.IndexOf(color[3]);
            int b = hex.IndexOf(color[4]) * 16 + hex.IndexOf(color[5]);
            return Color.FromArgb(r, g, b);
        }
    }
}
