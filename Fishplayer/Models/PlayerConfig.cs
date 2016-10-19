using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fishplayer.Helpers;
using System.IO;

namespace Fishplayer.Models
{
    public class PlayerConfig
    {

        public float Volume { get; set; }
        public string DirectoryPath { get; set; }

        public void Save()
        {
            var data = JsonHelper.Serialize<PlayerConfig>(this);
            File.WriteAllText(getConfigFile(), data);
        }

        public static PlayerConfig Load()
        {

            var data = File.ReadAllText(getConfigFile());
            return JsonHelper.DeSerialize<PlayerConfig>(data);
        }

        private static string getConfigFile()
        {
            return Path.Combine(Environment.CurrentDirectory, "settings.json");
        }
    }
}
