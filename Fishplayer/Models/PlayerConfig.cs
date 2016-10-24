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

        public PlaylistHelper playlistHelper; 
    }
}
