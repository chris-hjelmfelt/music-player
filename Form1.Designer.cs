
namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            this.SongList = new System.Windows.Forms.ListBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.WindowsMediaPlayerEmbed = new AxWMPLib.AxWindowsMediaPlayer();
            this.Footer = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerEmbed)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.Logo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(802, 35);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(2, 4);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(138, 27);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Music Player";
            // 
            // SongList
            // 
            this.SongList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 17;
            this.SongList.Location = new System.Drawing.Point(513, 47);
            this.SongList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(281, 259);
            this.SongList.TabIndex = 1;
            this.SongList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectButton.Location = new System.Drawing.Point(513, 323);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(112, 33);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select Songs";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // WindowsMediaPlayerEmbed
            // 
            this.WindowsMediaPlayerEmbed.Enabled = true;
            this.WindowsMediaPlayerEmbed.Location = new System.Drawing.Point(11, 47);
            this.WindowsMediaPlayerEmbed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WindowsMediaPlayerEmbed.Name = "WindowsMediaPlayerEmbed";
            this.WindowsMediaPlayerEmbed.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayerEmbed.OcxState")));
            this.WindowsMediaPlayerEmbed.Size = new System.Drawing.Size(465, 309);
            this.WindowsMediaPlayerEmbed.TabIndex = 3;
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.Location = new System.Drawing.Point(684, 343);
            this.Footer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(110, 13);
            this.Footer.TabIndex = 4;
            this.Footer.Text = "Developed by Chris H";
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 371);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.WindowsMediaPlayerEmbed);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SongList);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerEmbed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Button SelectButton;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayerEmbed;
        private System.Windows.Forms.Label Footer;
    }
}

