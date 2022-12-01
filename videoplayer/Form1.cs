using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.Windows;
using System.IO;
using System.Runtime;
using System.Diagnostics;


namespace videoplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Media.MediaPlayer p = new System.Windows.Media.MediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "sample.mp4";
            Uri u = new Uri(Application.StartupPath + "\\" + s);
            Text = u.ToString();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //"C:\\ProgramFiles(x86)\\Windows Media Player\\";
            startInfo.FileName = "wmplayer.exe";
            startInfo.Arguments = Application.StartupPath + "\\" + s;
            Process.Start(startInfo);
            p.Open(u);
            
            p.Play();
        }
    }
}
