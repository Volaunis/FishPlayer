using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Fishplayer
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWavePlayer wo = new WaveOut();
            AudioFileReader ar = new AudioFileReader(@"d:\Data\Documents\Repositories\FishPlayer\Examples\01 - Donald Fagen - Morph The Cat.mp3");

            wo.Init(ar);

            wo.Play();


            System.Threading.Thread.Sleep(3000);

            wo.Stop();
        }
    }
}
