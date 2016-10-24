using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fishplayer.Models;
using System.IO;

namespace Fishplayer.Helpers
{
    public class ConfigHelper
    {
        public static void Save(PlayerConfig config)
        {
            var data = JsonHelper.Serialize<PlayerConfig>(config);
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
