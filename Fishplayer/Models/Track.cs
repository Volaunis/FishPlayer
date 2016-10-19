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

        public Track(string filePath)
        {
            FileReader = new AudioFileReader(filePath);
        }

        ~Track()
        {
            FileReader.Dispose();
        }
    }
}
