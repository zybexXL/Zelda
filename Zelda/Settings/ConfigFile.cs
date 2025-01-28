using System.IO;
using System.Text.Json.Serialization;

namespace Zelda
{

    [JsonDerivedType(typeof(Settings))]
    [JsonDerivedType(typeof(State))]
    [JsonDerivedType(typeof(Skin))]
    public abstract class ConfigFile
    {
        [JsonIgnore]
        public bool isDefault = true;

        public ConfigFile() { }

        protected static T Load<T>(string path) where T : ConfigFile
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    var config = Util.JsonDeserialize<T>(json);
                    config.isDefault = false;
                    return config;
                }
            }
            catch { }
            return default;
        }

        protected bool Save(string path)
        {
            try
            {
                string dir = Path.GetDirectoryName(path);
                Directory.CreateDirectory(dir);
                if (File.Exists(path))
                {
                    string bak = Path.ChangeExtension(path, ".bak");
                    File.Delete(bak);
                    File.Move(path, bak);
                }
                isDefault = false;
                string json = Util.JsonSerialize(this, indented: true);
                File.WriteAllText(path, json);
                return true;
            }
            catch { }
            return false;
        }
    }
}
