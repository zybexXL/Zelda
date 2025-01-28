using System.Collections.Generic;

namespace Zelda
{
    // holds info about JRiver playlist
    public class JRPlaylist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Path { get; set; }
        public string FullName { get { return $"{Path}{Name}"; } }
        public List<JRFile> Files { get; set; }


        public JRPlaylist(int id, string name, int count, string path = null)
        {
            ID = id;
            Name = name;
            Count = count;
            Path = string.IsNullOrEmpty(path) ? null : $"{path}\\";
        }

        public override string ToString()
        {
            if (Count > 0)
                return $"{Path}{Name} ({Count} files)";
            else
                return $"{Path}{Name}";
        }
    }
}
