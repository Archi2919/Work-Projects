using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //Gets the music
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
            WindowsPlayer.URL = textBox1.Text;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //play the song that's chosen
            WindowsPlayer.Ctlcontrols.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            WindowsPlayer.Ctlcontrols.pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            WindowsPlayer.Ctlcontrols.stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
