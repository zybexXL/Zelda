using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zelda
{
    public class ELImg
    {
        public string src = null;
        public string path = null;
        public int width = -1;
        public int height = -1;

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

            return img;
        }

        public static string ELSrcToPath(string src)
        {
            if (src == null) return null;
            src = (src ?? "").Trim() + ".png";
            if (src.ToLower().StartsWith("tooltip:"))
                return Path.Combine(JRiverAPI.InstallFolder ?? "", "data\\tooltip", src.Substring(8));
            return src;
        }

        public static string PathToELSrc(string path)
        {
            if (path == null) return null;
            path = Path.ChangeExtension((path ?? "").Trim(), null) + " ";
            string tooltip = Path.Combine(JRiverAPI.InstallFolder ?? "", "data\\tooltip");
            if (path.StartsWith(tooltip + "\\", StringComparison.InvariantCultureIgnoreCase))
                path = "tooltip:" + path.Substring(tooltip.Length + 1);
            return path.Trim();
        }

        public string ToHTML()
        {
            string style = "<img ";
            string file = path ?? ELSrcToPath(src);
            if (file != null) style += $" src=\"{file}\"";
            if (width >= 0) style += $" width=\"{width}\"";
            if (height >= 0) style += $" height=\"{height}\"";
            return style + " \" />";
        }

        public string ToExpression()
        {
            string style = "<img";
            string file = src ?? PathToELSrc(path);
            if (file != null) style += $" src=\"{file}\"";
            if (width >= 0) style += $" width=\"{width}\"";
            if (height >= 0) style += $" height=\"{height}\"";
            return style + ">";
        }
    }
}
