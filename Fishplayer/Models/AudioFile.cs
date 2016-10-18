using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Fishplayer.Models
{
    public class AudioFile
    {
        public AudioFileReader FileReader { get; private set; }

        public AudioFile(string filePath)
        {
            FileReader = new AudioFileReader(filePath);
        }

        ~AudioFile()
        {
            FileReader.Dispose();
        }
    }
}
