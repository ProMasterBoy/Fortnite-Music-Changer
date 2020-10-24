using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;
using ProSwapperMusic.Properties;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Net;

namespace ProSwapperMusic
{
    public partial class Main : Form
    {
        private LogReader logReader;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            menuStrip1.BackColor = Color.DodgerBlue;
            string fileversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            version = fileversion.Substring(0, fileversion.Length - 4);

            versionlabel.Text = "Version: " + version;
        }
        public static string TitleMusic { get; set; }
        public static string LobbyMusic { get; set; }
        public static string VictoryMusic { get; set; }

        private string getLogFile()
        {
            if (Settings.Default.LogFile != "")
            {
                return Settings.Default.LogFile; // If path already exists
            }
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Logs\FortniteGame.log";
                //Find Log Path
                if (File.Exists(path))
                {
                    Settings.Default.LogFile = path;
                    Settings.Default.Save();
                    return path;
                }
                else
                {
                    OpenFileDialog o = new OpenFileDialog();
                    o.Title = @"Select your FortniteGame.Log,  It should be in AppData\Local\FortniteGame\Saved\Logs\FortniteGame.log";
                    if (o.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default.LogFile = o.FileName;
                        Settings.Default.Save();
                        return o.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Please select your Fortnite Logs Folder!", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                        return "a";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)=> Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch&silent=false");
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Downloading...";
            button2.Enabled = false;
            vid.RunWorkerAsync();
        }
        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            titlemenu.Items.Clear();
            string[] files = Directory.GetFiles(songsfolder, "*.mp3*", SearchOption.AllDirectories);
            titlemenu.Items.AddRange(files);
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            lobbymenu.Items.Clear();
            string[] files = Directory.GetFiles(songsfolder, "*.mp3*", SearchOption.AllDirectories);
            lobbymenu.Items.AddRange(files);
        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {
            victory.Items.Clear();
            string[] files = Directory.GetFiles(songsfolder, "*.mp3*", SearchOption.AllDirectories);
            victory.Items.AddRange(files);
        }
        public static string version { get; set; }
        static string songsfolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ProSwapperMusic\Songs";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        string logfile = getLogFile().Replace("FortniteGame.log", "");

            logReader = new LogReader(logfile);
            if (Settings.Default.PlayInBackground == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

            string proswapperfolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ProSwapperMusic";

            if (!Directory.Exists(proswapperfolder))
                Directory.CreateDirectory(proswapperfolder);

            if (!Directory.Exists(songsfolder))
                Directory.CreateDirectory(songsfolder);

            trackBar1.Value = Settings.Default.Volume;
            status.Start();
            if (Settings.Default.Songs.Length >= 30)
            {
                string[] savedsongs = Settings.Default.Songs.Split('>');
                titlemenu.Text = savedsongs[0];
                lobbymenu.Text = savedsongs[1];
                victory.Text = savedsongs[2];

                TitleMusic = savedsongs[0];
                LobbyMusic = savedsongs[1];
                VictoryMusic = savedsongs[2];
            }
            
            RefreshSongs();
            


            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + AppDomain.CurrentDomain.FriendlyName))
                launchOnPCStartupToolStripMenuItem.Checked = true;
            else
                launchOnPCStartupToolStripMenuItem.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PlayInBackground = checkBox1.Checked;
            Settings.Default.Songs = titlemenu.Text + ">" + lobbymenu.Text + ">" + victory.Text;
            Settings.Default.Save();
            Environment.Exit(0);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            AudioPlayer.ChangeVolume(trackBar1.Value);
            Settings.Default.Volume = trackBar1.Value;
            Settings.Default.Save();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                AudioPlayer.ChangeVolume(Settings.Default.Volume);
            else
                AudioPlayer.ChangeVolume(0); // to click the button they have to be in the background of fortnite, so just set the volume to 0
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleMusic = titlemenu.Text;
            RefreshSongs();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LobbyMusic = lobbymenu.Text;
            RefreshSongs();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            VictoryMusic = victory.Text;
            RefreshSongs();
        }

        private void minimiseToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void reloadMusicToolStripMenuItem_Click(object sender, EventArgs e)=> RefreshSongs();
        private void songsFolderInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long foldersize = DirSize(new DirectoryInfo(songsfolder));
            double a = ConvertBytesToMegabytes(foldersize);
            a = Math.Round(a, 2);
            int fCount = Directory.GetFiles(songsfolder, "*", SearchOption.AllDirectories).Length;
            MessageBox.Show("Songs folder is " + a + " mb with " + fCount + " songs");
        }

        public static long DirSize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(fi => fi.Length) +
                   dir.GetDirectories().Sum(di => DirSize(di));
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void openSongsFolderToolStripMenuItem1_Click(object sender, EventArgs e)=> Process.Start(songsfolder);
        private void deleteAllSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fCount = Directory.GetFiles(songsfolder, "*", SearchOption.AllDirectories).Length;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all " + fCount + " of your downloaded songs?", "Delete all songs?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Directory.Delete(songsfolder);
                if (!Directory.Exists(songsfolder))
                    Directory.CreateDirectory(songsfolder);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("phew that was a close one there, almost deleting all your favourite tunes :3", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vid_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!ytlink.Text.Contains("youtu") && !ytlink.Text.Contains("http"))
            {
                MessageBox.Show("That isn't a valid youtube link!");
                return;
            }
            redo: try
            {
                if (!Directory.Exists(songsfolder))
                    Directory.CreateDirectory(songsfolder);

                var source = songsfolder + @"\";
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(ytlink.Text);
                File.WriteAllBytes(source + vid.FullName, vid.GetBytes());
                var inputFile = new MediaFile { Filename = source + vid.FullName };
                var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    engine.Convert(inputFile, outputFile);
                }
                if (File.Exists(source + vid.FullName))
                {
                    File.Delete((source + vid.FullName));//Deletes mp4 file
                }
                MessageBox.Show("Downloaded Song!", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                goto redo;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

           // label7.Text = "State: " + LogFileReader.FortniteState.ToString();
            if (checkBox1.Checked == false)//Don't play in background
            {
                if (Pro.IsFNFocused() == false)
                {
                    AudioPlayer.ChangeVolume(0);
                }
                else
                {
                    AudioPlayer.ChangeVolume(Settings.Default.Volume);
                }   
            }
        }

        public static void RefreshSongs()
        {
            AudioPlayer.StopMusic();
            switch (LogReader.FortniteState)
            {
                case FortniteState.Title:
                    AudioPlayer.PlayMusic(TitleMusic);
                    break;
                case FortniteState.Lobby:
                    AudioPlayer.PlayMusic(LobbyMusic);
                    break;
                case FortniteState.GameEnd:
                    AudioPlayer.PlayMusic(VictoryMusic);
                    break;
                case FortniteState.InGame:
                case FortniteState.None:
                    AudioPlayer.StopMusic();
                    break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)=> this.WindowState = FormWindowState.Minimized;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           using (WebClient a = new WebClient())
            {
                string discord = "https://discord.gg/proswapper";
                if (a.DownloadString(discord) == "Join")
                {
                    //If Discord link is valid
                    Process.Start(discord);
                }
                else
                {
                    //If discord link is invalid
                    string[] info = a.DownloadString("https://proswapper.xyz/music.txt").Split(';');
                    Process.Start(info[1]);
                }
            }
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WebClient web = new WebClient();
                string[] info = web.DownloadString("https://proswapper.xyz/music.txt").Split(';');
                if (version == info[0])
                {
                    MessageBox.Show("You are currently on the newest version of Pro Swapper Music!", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There is a new update for Pro Swapper Music (Version: " + info[0] + ")", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("https://proswapper.xyz/music");
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)=> Process.Start("https://youtube.com/proswapperofficial");

        private void launchOnPCStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string thisexe = AppDomain.CurrentDomain.FriendlyName;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + thisexe;
            if (File.Exists(file))
                File.Delete(file); //Shortcut exists
            else
                File.Copy(thisexe, file, true);//Shortcut doesnt exist
        }

        private void vid_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            button2.Text = "Download";
            button2.Enabled = true;
        }
    }
}
