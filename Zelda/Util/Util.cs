using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zelda
{
    public static class Util
    {
        public static bool isSameExpression(string expression1, string expression2)
        {
            expression1 = StripComments(expression1).Replace("\r\n", "\n");
            expression2 = StripComments(expression2).Replace("\r\n", "\n");

            if (expression1.Contains("1]") || expression2.Contains("1]"))
            {
                expression1 = Regex.Replace(expression1, @"\[(.+?),\s?1]", "[$1]");
                expression2 = Regex.Replace(expression2, @"\[(.+?),\s?1]", "[$1]");
            }

            return expression1.Trim() == expression2.Trim();
        }

        public static string StripComments(string expression)
        {
            expression = expression ?? "";
            if (expression.Contains("##"))
                return Regex.Replace(expression, @"^##.*$\r?\n?", "", RegexOptions.Multiline);
            return expression;
        }

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        // load an Image from file
        public static Image LoadImage(string path)
        {
            try
            {
                if (path == null || !File.Exists(path)) return null;

                byte[] data = File.ReadAllBytes(path);
                using (var ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch { }
            return null;
        }

        public static long NumberValue(string strvalue)
        {
            if (string.IsNullOrEmpty(strvalue)) return 0;
            string num = Regex.Replace(strvalue, @"[^\d]", "");
            if (long.TryParse(num, out long value))
                return value;
            return 0;
        }

        public static DateTime EpochToDateTime(long epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }

        public static long DateTimeToEpoch(DateTime date)
        {
            return (long)date.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        // JRiver seems to have an off-by-1 bug in the dates it uses in this old Lotus123 format
        // epoch is 30.12.1989 instead of 31.12.1899
        public static int DaysSince1900(DateTime date)
        {
            return (int)(date - new DateTime(1899, 12, 30)).TotalDays;
        }

        public static string JsonSerialize<T>(T obj, bool indented = true)
        {
            var options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,             // compatibility encoding
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                WriteIndented = indented,
                IgnoreReadOnlyProperties = true
            };

            options.Converters.Add(new JsonStringEnumConverter());
            string json = JsonSerializer.Serialize(obj, options);
            return json;
        }

        internal static T JsonDeserialize<T>(string json)
        {
            try
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());

                var obj = JsonSerializer.Deserialize<T>(json, options);
                return obj;
            }
            catch { }
            return default(T);
        }

        /*
        public static string OSName()
        {
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (RegistryKey key = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                return (string)key.GetValue("ProductName", "Windows");
        }

        // reads embedded resource file as string
        internal static string getEmbeddedResourceString(string resourcePath, bool isGzip = false)
        {
            Stream resource = getEmbeddedResourceStream(resourcePath, isGzip);
            if (resource == null) return null;

            try
            {
                using (StreamReader reader = new StreamReader(resource))
                    return reader.ReadToEnd();
            }
            catch { }
            finally { if (resource != null && resource.CanRead) try { resource.Close(); } catch { } }
            return null;
        }
        
        internal static Stream getEmbeddedResourceStream(string resourcePath, bool isGzip = false)
        {
            Stream stream = null;
            resourcePath = resourcePath.Replace('\\', '.').Replace('/', '.');
            try
            {
                stream = findResourceStream(Assembly.GetEntryAssembly(), resourcePath);
                if (stream == null) stream = findResourceStream(Assembly.GetExecutingAssembly(), resourcePath);
                if (stream == null) return null;

                if (isGzip)
                {
                    GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress, false);
                    return gzip;
                }
                return stream;
            }
            catch { }
            return null;
        }

        internal static bool ExtractResource(string resource, string fileName, bool isGZip = false, bool overwrite = true)
        {
            Stream resStream = getEmbeddedResourceStream(resource, isGZip);
            if (resStream == null)
                return false;
            try
            {
                FileInfo fi = new FileInfo(fileName);
                if (overwrite || !fi.Exists || fi.Length != resStream.Length)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName));
                    using (StreamWriter sw = new StreamWriter(fileName))
                        resStream.CopyTo(sw.BaseStream);
                }
                else
                {
                    //Console.WriteLine($"Resource '{resource}' is up to date ('{fileName}')");
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (resStream != null) resStream.Close();
            }
        }

        private static Stream findResourceStream(Assembly assembly, string resourcePath)
        {
            try
            {
                Stream stream = assembly.GetManifestResourceStream(resourcePath);
                if (stream == null)
                {
                    string res = assembly.GetManifestResourceNames().Where(r => r.EndsWith(resourcePath)).FirstOrDefault();
                    if (res != null)
                        stream = assembly.GetManifestResourceStream(res);
                }
                return stream;
            }
            catch { }
            return null;
        }
        */
    }
}

