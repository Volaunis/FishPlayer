using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Fishplayer.Models
{
    public class Track
    {
        public AudioFileReader FileReader { get; private set; }
        public TagLib.File TagLibFile { get; set; }

        public Track(string filePath)
        {
            FileReader = new AudioFileReader(filePath);
            TagLibFile = TagLib.File.Create(filePath);
        }

        ~Track()
        {
            FileReader.Dispose();
        }

        public override string ToString()
        {
            return $"{Artist} - {Title} - {Album}";
        }
         
        public string Artist { get { return string.Join(", ", TagLibFile.Tag.AlbumArtists); } }
        public string Title {  get { return TagLibFile.Tag.Title; } }
        public string Album { get { return TagLibFile.Tag.Album; } }
    }
}
