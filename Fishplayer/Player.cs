﻿using System;
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
    }
}
