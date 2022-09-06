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
using Fishplayer.Models;
using System.IO;

namespace Fishplayer
{
    public partial class Player : Form
    {
        private IWavePlayer wo;
        public PlayerConfig playerConfig;

        public Player()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wo = new WaveOut();
        }

        private void LoadFiles_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialog.ShowDialog();

            var path = FolderBrowserDialog.SelectedPath;

            var files = Directory.GetFiles(path, "*.mp3");

            listBox1.Items.AddRange(files.Select(f => new Track(f)).ToArray());

            //FileView.Items.AddRange(files.Select(f => new ListViewItem(f)).ToArray());

        }
    }
}
