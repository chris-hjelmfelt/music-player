using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        // Global Variables for track names and paths
        String[] paths, files;

        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            // Select Songs button functionality
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // get multiple files

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                // Display the music titles in the list box
                for(int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(files[i]);
                }
            }
        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Play the music
            WindowsMediaPlayerEmbed.URL = paths[SongList.SelectedIndex];
        }

        private void Play_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close Button functionality
            this.Close();
        }
    }
}
