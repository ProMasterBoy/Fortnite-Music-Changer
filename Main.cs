using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using ProSwapperMusic.Properties;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using WMPLib;
using MaterialSkin;
using System.Threading;
using System.Web.Script.Serialization;
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
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            string fileversion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            version = fileversion.Substring(0, fileversion.Length - 4);
            versionlabel.Text = "Version: " + version;
            Icon = appIcon;
            notifyIcon1.Icon = appIcon;


            string logfile = getLogFile().Replace("FortniteGame.log", "");

            logReader = new LogReader(logfile);
            if (Settings.Default.PlayInBackground == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

            if (Settings.Default.InMatch == true)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;


            string proswapperfolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ProSwapperMusic";

            if (!Directory.Exists(proswapperfolder))
                Directory.CreateDirectory(proswapperfolder);

            if (!Directory.Exists(songsfolder))
                Directory.CreateDirectory(songsfolder);

            trackBar2.Value = Settings.Default.Volume;
            status.Start();

            string[] savedsongs = Settings.Default.Songs.Split('?');
            string[] files = Directory.GetFiles(songsfolder, "*.mp3*", SearchOption.AllDirectories);
            titlemenu.Items.AddRange(files);
            lobbymenu.Items.AddRange(files);
            victory.Items.AddRange(files);


            titlemenu.Text = savedsongs[0];
                lobbymenu.Text = savedsongs[1];
                victory.Text = savedsongs[2];

                TitleMusic = savedsongs[0];
                LobbyMusic = savedsongs[1];
                VictoryMusic = savedsongs[2];

          
            RefreshSongs();



            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + AppDomain.CurrentDomain.FriendlyName))
            {
                launchOnPCStartupToolStripMenuItem.Checked = true;
                string thisexe = AppDomain.CurrentDomain.FriendlyName;
                string file = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + thisexe;
                File.Copy(thisexe, file, true);//Shortcut doesnt exist
            }
            else
                launchOnPCStartupToolStripMenuItem.Checked = false;
        }
        public static string TitleMusic { get; set; }
        public static string LobbyMusic { get; set; }
        public static string VictoryMusic { get; set; }

        private string getLogFile()
        {
            if (Settings.Default.LogFile.Length > 1)
                return Settings.Default.LogFile; // If path already exists
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
                    using (OpenFileDialog o = new OpenFileDialog())
                    {
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
                            return string.Empty;
                        }
                    }
                    
                }
            }
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PlayInBackground = checkBox1.Checked;
            Settings.Default.InMatch = checkBox2.Checked;
            Settings.Default.Songs = titlemenu.Text + "?" + lobbymenu.Text + "?" + victory.Text;
            Settings.Default.Save();
            Environment.Exit(0);
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
            Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        
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
        public class ytapi
        {
            public string title { get; set; }
        }

        public string GetDownloadUrlYT(string vidid)
        {
            using (WebClient web = new WebClient())
            { 
                string url = "https://www.yt-download.org/file/mp3/" + vidid;
                string downloaded = web.DownloadString(url);
                foreach (string line in downloaded.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                    if (line.Contains("https://www.yt-download.org/download/"))
                        return GetURl(line);
                    }
                return string.Empty;
            }
        }

        private static string GetURl(string stringwithurl)
        {
            foreach (Match m in new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase).Matches(stringwithurl))
                return m.Value;

            return "";
        }
        private static string Removeillegal(string var)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(var, "");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)//Don't play in background
            {
                if (Pro.IsFNFocused == false)
                    AudioPlayer.ChangeVolume(0);
                else
                    AudioPlayer.ChangeVolume(Settings.Default.Volume);
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
                    if (Settings.Default.InMatch == true)
                    {
                        AudioPlayer.PlayMusic(LobbyMusic);
                    }
                    else
                    {
                        AudioPlayer.StopMusic();
                    }
                    break;
                case FortniteState.None:
                    AudioPlayer.StopMusic();
                    break;
            }
        }

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
                string[] info = new WebClient().DownloadString("https://proswapper.xyz/music.txt").Split(';');
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
        
        private void launchOnPCStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string thisexe = AppDomain.CurrentDomain.FriendlyName;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + thisexe;
            if (File.Exists(file))
                File.Delete(file); //Shortcut exists
            else
                File.Copy(thisexe, file, true);//Shortcut doesnt exist
        }        
        private void materialCheckBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                AudioPlayer.ChangeVolume(Settings.Default.Volume);
            else
                AudioPlayer.ChangeVolume(0); // to click the button they have to be in the background of fortnite, so just set the volume to 0
        }

        private void materialCheckBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                Settings.Default.InMatch = true;
            else
                Settings.Default.InMatch = false;

            Settings.Default.Save();
            RefreshSongs();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!ytlink.Text.Contains("youtu") || ytlink.Text == "e.g: youtu.be/dQw4w9WgXcQ")
            {
                MessageBox.Show("That isn't a valid youtube link!", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            button2.Text = "Downloading...";
            button2.Enabled = false;
            if (!Directory.Exists(songsfolder))
                Directory.CreateDirectory(songsfolder);
            new Thread(() =>
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread.CurrentThread.IsBackground = true;
                Thread.CurrentThread.Priority = ThreadPriority.Highest;
                try
                {
                    string vidid = ytlink.Text.Substring(ytlink.Text.Length - 11);
                    using (WebClient web = new WebClient())
                    {
                        string title = Removeillegal(new JavaScriptSerializer().Deserialize<ytapi>(web.DownloadString("https://www.youtube.com/oembed?url=https://youtu.be/" + vidid)).title);
                        web.DownloadFile(GetDownloadUrlYT(vidid), songsfolder + @"\" + title + ".mp3");
                    }
                    //https://www.youtube.com/oembed?url=https://youtu.be/JUewJm2ssBw
                    button2.Text = "Download";
                    button2.Enabled = true;
                    MessageBox.Show("Downloaded Song!", "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pro Swapper Music", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ).Start();
        }
        private void ComboBoxMouseEnter(ComboBox combobox)
        {
            string selected = combobox.Text;
            combobox.Items.Clear();
            string[] files = Directory.GetFiles(songsfolder, "*.mp3*", SearchOption.AllDirectories);
            combobox.Items.AddRange(files);
            combobox.Text = selected;
        }
        public static readonly Icon appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        private void materialFlatButton2_Click(object sender, EventArgs e)=> WindowState = FormWindowState.Minimized;
        private void materialFlatButton1_Click(object sender, EventArgs e)=> Application.Exit();
        private void ytlink_Click(object sender, EventArgs e)=> ytlink.Clear();
        private void materialRaisedButton1_Click(object sender, EventArgs e) => Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch");
        private void reloadMusicToolStripMenuItem_Click(object sender, EventArgs e) => RefreshSongs();
        private void comboBox1_MouseEnter(object sender, EventArgs e) => ComboBoxMouseEnter(titlemenu);
        private void comboBox2_MouseEnter(object sender, EventArgs e) => ComboBoxMouseEnter(lobbymenu);
        private void comboBox3_MouseEnter(object sender, EventArgs e) => ComboBoxMouseEnter(victory);
        public static string version { get; set; }
        static string songsfolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\ProSwapperMusic\Songs";
        private void pictureBox3_Click(object sender, EventArgs e) => Process.Start("https://youtube.com/proswapperofficial");
        private void changeLogFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Title = @"Select your FortniteGame.Log,  It should be in AppData\Local\FortniteGame\Saved\Logs\FortniteGame.log";
                if (o.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.LogFile = o.FileName;
                    Settings.Default.Save();
                }
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            AudioPlayer.ChangeVolume(trackBar2.Value);
            Settings.Default.Volume = trackBar2.Value;
            volumelbl.Text = "Volume:" + trackBar2.Value + "%";
            Settings.Default.Save();
        }
    }
    #region AudioPlayer
    class AudioPlayer
    {
        private static WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        /// Uses WMP to play music from a given path
        public static void PlayMusic(string path) // Plays music
        {
            mediaPlayer.settings.setMode("loop", true);
            try // Try / catch is here to prevent crashes when WMP says it's currently in use.
            {
                mediaPlayer.URL = path; // just play it.
                if (mediaPlayer.playState == WMPPlayState.wmppsPaused || mediaPlayer.playState == WMPPlayState.wmppsTransitioning || mediaPlayer.playState == WMPPlayState.wmppsUndefined) // only play if it's not already playing
                {
                    mediaPlayer.controls.play(); // If it's currently paused or swapping tracks, play it.
                }
            }
            catch
            {}
        }
        /// Stop playing music that it's playing.
        public static void StopMusic() // Pauses the music 
        {
            while (true) // loop + try / catch because wmp sometimes doesn't want to play ball.
            {
                try
                {
                    mediaPlayer.controls.stop();
                    if (mediaPlayer.playState == WMPPlayState.wmppsStopped || mediaPlayer.playState == WMPPlayState.wmppsReady || mediaPlayer.playState == WMPPlayState.wmppsUndefined)
                    {
                        break;
                    }
                }
                catch { }
            }
        }
        /// Changes the volume.
        public static void ChangeVolume(int volume)
        {
            mediaPlayer.settings.volume = volume;
        }
    }
    #endregion
}
