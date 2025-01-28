using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Zelda
{
    public class ELImg
    {
        public string src = null;
        public string path = null;
        public int width = -1;
        public int height = -1;
        public string valign = null;

        public ELImg(string file = null, int w = -1, int h = -1, bool isELSrc = false)
        {
            setPath(file, isELSrc);
            width = w;
            height = h;
        }

        public void setPath(string file, bool isELSrc = false)
        {
            if (file == null) src = path = null;
            else
            {
                src = isELSrc ? file : PathToELSrc(file);
                path = isELSrc ? ELSrcToPath(file) : file;
            }
        }

        public static ELImg Parse(string tag)
        {
            ELImg img = new ELImg();
            if (tag == null) return img;

            Match p = Regex.Match(tag, @"\bsrc\s*=\s*""(.+?)""", RegexOptions.IgnoreCase);
            if (p.Success) {
                img.src = p.Groups[1].Value;
                img.path = ELSrcToPath(img.src);
            }

            p = Regex.Match(tag, @"\bwidth\s*=\s*""(\d+)""", RegexOptions.IgnoreCase);
            if (p.Success)
                img.width = int.Parse(p.Groups[1].Value);

            p = Regex.Match(tag, @"\bheight\s*=\s*""(\d+)""", RegexOptions.IgnoreCase);
            if (p.Success)
                img.height = int.Parse(p.Groups[1].Value);

            p = Regex.Match(tag, @"\bsize\s*=\s*""(\d+)\s*x\s*(\d+)""", RegexOptions.IgnoreCase);
            if (p.Success)
            {
                img.width = int.Parse(p.Groups[1].Value);
                img.height = int.Parse(p.Groups[2].Value);
            }

            p = Regex.Match(tag, @"\bvalign\s*=\s*""(.+?)""", RegexOptions.IgnoreCase);
            if (p.Success)
                img.valign = p.Groups[1].Value;

            return img;
        }

        public static string ELSrcToPath(string src)
        {
            if (src == null) return null;
            src = src.Trim();

            string tooltip = ZeldaUI.TooltipDir?.ToLower();
            if (src.ToLower().StartsWith("tooltip:") && src.Length > 8 && !string.IsNullOrEmpty(tooltip))
                return Path.Combine(ZeldaUI.TooltipDir, src.Substring(8)) + ".png";
            return src;
        }

        public static string PathToELSrc(string path)
        {
            if (path == null) return null;
            
            bool isPNG = path.ToLower().EndsWith(".png");
            string tooltip = ZeldaUI.TooltipDir?.ToLower();
            if (isPNG && !string.IsNullOrEmpty(tooltip) && path.ToLower().StartsWith(tooltip + "\\", StringComparison.InvariantCultureIgnoreCase))
                path = "tooltip:" + Path.ChangeExtension((path + " ").Substring(tooltip.Length + 1).Trim(), null);

            return path.Trim();
        }

        public string ToHTML()
        {
            string _valign = "middle";  // default
            switch (valign?.ToLower())
            {
                case "middle":
                case "top":
                case "bottom": _valign = valign; break;
            }

            string tag = "<img ";
            string style = "";
            string file = path ?? ELSrcToPath(src);
            if (file != null) tag += $" src=\"{file}\"";
            if (width > 0) tag += $" width=\"{width}\"";
            if (height > 0) tag += $" height=\"{height}\"";
            //if (height <= 0 && height <= 0) style += $"height:100%; ";
            if (_valign != null) style += $" vertical-align:{_valign}; ";

            if (!string.IsNullOrWhiteSpace(style)) style = $" style=\"{style}\"";
            return $"{tag}{style} />";
        }

        public string ToExpression()
        {
            string style = "<img";
            string file = src ?? PathToELSrc(path);
            if (file != null) style += $" src=\"{file}\"";
            if (width > 0) style += $" width=\"{width}\"";
            if (height > 0) style += $" height=\"{height}\"";
            if (valign != null) style += $" valign=\"{valign}\"";
            return style + ">";
        }
    }
}
