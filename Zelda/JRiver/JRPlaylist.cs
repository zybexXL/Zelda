﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda
{
    // holds info about JRiver playlist
    public class JRPlaylist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Path { get; set; }

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
            return $"{Path}{Name} ({Count} files)";
        }
    }
}