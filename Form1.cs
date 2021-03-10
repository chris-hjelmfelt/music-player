using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        // Global Variables for track names and paths
        String[] paths, files;
        private bool aiPlayer = false;
        SoundPlayer tone1 = new SoundPlayer(@"C:\Users\Chris\source\repos\MusicPlayer\Tones\C5.wav");
        SoundPlayer tone2 = new SoundPlayer(@"C:\Users\Chris\source\repos\MusicPlayer\Tones\A5.wav");
        SoundPlayer tone3 = new SoundPlayer(@"C:\Users\Chris\source\repos\MusicPlayer\Tones\F5.wav");

        public MusicPlayer()
        {
            InitializeComponent();
        }

        private async void PlayAiMusic()
        {
            await Task.Delay(1000);
            tone1.Play();
            await Task.Delay(2000);
            tone3.Play();
            await Task.Delay(1000);
            tone2.Play();
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

        private void AiMusic_Click(object sender, EventArgs e)
        {
            PlayAiMusic();
            /*
            if (!aiPlayer)
            {
                aiPlayer = true;
                PlayAiMusic();
            } 
            else
            {
                aiPlayer = false;
            }
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close Button functionality
            this.Close();
        }
    }
}
