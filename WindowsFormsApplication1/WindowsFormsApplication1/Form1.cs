﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           
              



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        str downloadFolderChoice = "";

        // Allow user to select directory for downloads
        private void downloadDirectorySelect(object sender, EventArgs e)
        {
            this.folderSelectDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.folderSelectDownload.ShowNewFolderButton = true;
            this.folderSelectDownload.Description = "Select a folder to download to.";
            str downloadFolderChoice = this.folderSelectDownload.SelectedPath;
        }

      
        /// <summary>
        /// Start Editing the Code Here
        /// </summary>

              
        
        // If the User Selects CHIP8
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\chip8"); old code kept, new code untested        
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_chip8/CHIP8.rar"), @"C:\Users\Public\homebrew\chip8\CHIP8.rar");
            }
        }

        // If the User Selects Nesbox
        private void button1_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\nesbox");        
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_nesbox/Nesbox.zip"), @"C:\Users\Public\homebrew\nesbox\Nesbox.zip");

        }

        // If the User Selects RetriX
        private void button3_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\retrix"); old code         
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_retrix/RetriX_v1.8.zip"), @"C:\Users\Public\homebrew\RetriX\RetriX.zip");

        }

        // If the User Selects PPSSPP
        private void button4_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\PPSSPP"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_ppsspp/PPSSPP.rar"), @"C:\Users\Public\homebrew\ppsspp\PPSSPP.rar");
            }
        }

        // If the User Selects VBA10
        private void button5_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\VBA10"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_vba10/VBA10.rar"), @"C:\Users\Public\homebrew\vba10\VBA10.rar");
            }
        }

        // If the User Selects Win64e10
        private void button6_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Win64e10"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_win64e10/Win64e10.zip"), @"C:\Users\Public\homebrew\win64e10\Win64e10.zip");
            }
        }

        // If the User Selects DungeonRUN
        private void button7_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\DungeonRUN"); old code         
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_dungeon_run/DungeonRUN.zip"), @"C:\Users\Public\homebrew\DungeonRun\DungeonRUN.zip");
            }
        }

        // If the User Selects Hedgephysics
        private void button8_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Hedge-physics"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_hedge_physics/Hedgephysics.zip"), @"C:\Users\Public\homebrew\Hedge-physics\hedgephysics.zip");
            }
        }

        // If the User Selects SonicContinuim
        private void button9_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\sonic-continuum"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_sonic_continuim/sonic_continuim.zip"), @"C:\Users\Public\homebrew\SonicContinuim\sonic_continuim.zip");
            }
        }

        // If the User Selects WinIRC
        private void button10_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\winirc"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_winirc/winirc.zip"), @"C:\Users\Public\homebrew\WinIRC\winirc.zip");
            }
        }

        // If the User Selects Boxify
        private void button11_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\boxify"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_boxify/boxify.zip"), @"C:\Users\Public\homebrew\Boxify\boxify.zip");
            }
        }

        // If the User Selects UWPStreamer
        private void button12_Click(object sender, EventArgs e)
        {
            downloadDirectorySelect();
            if (System.IO.Directory.Exists(downloadFolderChoice) == false) {
                System.IO.Directory.CreateDirectory(@downloadFolderChoice);
            } else {
                // System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\UWPStreamer"); old code         
                WebClient Client = new WebClient();
                Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                Client.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/wiired24/ProjectPegasus/appx_releases/UWPstreamer.zip"), @"C:\Users\Public\homebrew\UWPstreamer\UWPstreamer.zip");
            }
        }

        // Prints a message and plays a special sound to the user when the Download has completed     
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("Download complete! \nEnjoy Homebrew on Xbox One :)");
            
        }
        
        // Updates the Progress Bar as the Download progresses
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }   
        
        /// <summary>
        /// Stop Here
        /// </summary>
       

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
