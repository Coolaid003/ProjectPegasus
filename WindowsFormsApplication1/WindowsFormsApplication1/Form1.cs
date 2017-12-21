using System;
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
            dlfolder.Text = @"C:\Users\Public\homebrew";
        }
        
        //fdl stands for folder download location and by default sets the download location to the fixed one from before the update
        public string fdl = @"C:\Users\Public\homebrew";

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

      
        /// <summary>
        /// Start Editing the Code Here
        /// </summary>
               
        // If the User Selects CHIP8
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\chip8");         
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_chip8/CHIP8.rar"), fdl + @"\chip8\CHIP8.rar");
            


        }

        // If the User Selects Nesbox
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\nesbox");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_nesbox/Nesbox.zip"), fdl + @"\nesbox\Nesbox.zip");

        }

        // If the User Selects RetriX
        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\RetriX");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_retrix/RetriX_v1.8.zip"), fdl + @"\RetriX\RetriX.zip");

        }

        // If the User Selects PPSSPP
        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\PPSSPP");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_ppsspp/PPSSPP.rar"), fdl + @"\ppsspp\PPSSPP.rar");

        }

        // If the User Selects VBA10
        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\vba10");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_vba10/VBA10.rar"), fdl + @"\vba10\VBA10.rar");

        }

        // If the User Selects Win64e10
        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\win64e10");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_win64e10/Win64e10.zip"), fdl + @"\win64e10\Win64e10.zip");
        }

        // If the User Selects DungeonRUN
        private void button7_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\DungeonRun");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_dungeon_run/DungeonRUN.zip"), fdl + @"\DungeonRun\DungeonRUN.zip");
        }

        // If the User Selects Hedgephysics
        private void button8_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\Hedge-physics");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_hedge_physics/Hedgephysics.zip"), fdl + @"\Hedge-physics\hedgephysics.zip");

        }

        // If the User Selects SonicContinuim
        private void button9_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\SonicContinuim");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_sonic_continuim/sonic_continuim.zip"), fdl + @"\SonicContinuim\sonic_continuim.zip");

        }

        // If the User Selects WinIRC
        private void button10_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\WinIRC");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_winirc/winirc.zip"), fdl + @"\WinIRC\winirc.zip");

        }
        
        // If the User Selects Boxify
        private void button11_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\Boxify");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://github.com/wiired24/ProjectPegasus/releases/download/appx_boxify/boxify.zip"), fdl + @"\Boxify\boxify.zip");

        }

        // If the User Selects UWPStreamer
        private void button12_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(fdl + @"\UWPstreamer");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/wiired24/ProjectPegasus/appx_releases/UWPstreamer.zip"), fdl + @"\UWPstreamer\UWPstreamer.zip");

        }



        // Prints a message and plays a special sound to the user when the Download has completed     
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("Download complete! \nEnjoy Homebrew on Xbox One :)\n\n-the project pegasus team");
            
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlf = new FolderBrowserDialog();
            dlf.Description = " select download path";
            if (dlf.ShowDialog() == DialogResult.OK)
                fdl = dlf.SelectedPath ;
                dlfolder.Text = dlf.SelectedPath;
        }

        private void dlfolder_TextChanged(object sender, EventArgs e)
        {
            fdl = dlfolder.Text;
        }
    }
}
