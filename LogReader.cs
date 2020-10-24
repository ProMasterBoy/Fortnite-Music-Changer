using ProSwapperMusic.Properties;
using System.Collections.Generic;
using System.IO;

namespace ProSwapperMusic
{
    public class LogReader
    {
        public static FortniteState FortniteState { get; set; }
        private StreamReader streamReader;
        public LogReader(string fortniteLogDirectory)
        {
            FileStream fileStream = File.Open(fortniteLogDirectory + @"\FortniteGame.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            streamReader = new StreamReader(fileStream);

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Filter = "FortniteGame.log";
            watcher.Path = fortniteLogDirectory;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += readNewLines; // Once the file changes, read the new lines
            watcher.EnableRaisingEvents = true;

            AudioPlayer.ChangeVolume(0); // prevent blasting people's speakers for a second while it's still going through the logs (especially on startup)
            readNewLines(new object(), new FileSystemEventArgs(WatcherChangeTypes.Changed, "", "")); // run it to catch up if fortnite is open.
            AudioPlayer.ChangeVolume(Settings.Default.Volume); // prevent blasting people's speakers while it's still going through the logs (especially on startup)
        }
        /// <summary>
        /// Reads all of the new lines in a log file
        /// </summary>
        private void readNewLines(object source, FileSystemEventArgs e) // When fortnite writes to the file, run this - vastly more efficient than getting screenshots :)
        {
            string CurrentLine = "";
            List<string> NewLines = new List<string>(); // holds the new lines that were just written to the file

            if (isLogFileEmpty()) // this is true when fortnite has started up and has cleared the existing log file 
            {
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin); // reset log position
            }

            while ((CurrentLine = streamReader.ReadLine()) != null)
            {
                if (CurrentLine != "") // if the line is new, add it to the list.
                {
                    NewLines.Add(CurrentLine); // list because it can usually be 2 or more per update.
                }
            }

            foreach (string i in NewLines) // go through the new lines.
            {
                if (i.Contains("to [UI.State.Startup.SubgameSelect]")) // Title menu
                {
                    FortniteState = FortniteState.Title;
                    Main.RefreshSongs();
                }

                if (i.Contains("to [UI.State.Athena.Frontend]") || i.Contains("to FrontEnd")) // Main Menu // "to FrontEnd" is for STW support.
                {
                    FortniteState = FortniteState.Lobby;
                    Main.RefreshSongs();
                }

                if (i.Contains("NewState: Finished")) // Matchmaking finished
                {
                    FortniteState = FortniteState.InGame;
                    Main.RefreshSongs();
                }

                if (i.Contains("current=WaitingPostMatch")) // game end
                {
                    FortniteState = FortniteState.GameEnd;
                    Main.RefreshSongs();
                }

                if (i.Contains("Preparing to exit")) // Fortnite closed
                {
                    FortniteState = FortniteState.None;
                    Main.RefreshSongs();
                }
            }
        }


        /// <summary>
        /// Checks if the fortnite log file has been reset, and tells you if fortnite has just launched
        /// </summary>
        /// <returns>Whether the log file is empty</returns>
        private bool isLogFileEmpty()
        {
            long oldPosition = streamReader.BaseStream.Position;
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            bool isReset = streamReader.ReadLine() == null; // check if the start of the log file is null

            streamReader.BaseStream.Seek(oldPosition, SeekOrigin.Begin); // reset position

            return isReset;
        }
    }
    public enum FortniteState
    {
        None,
        Title,
        Lobby,
        InGame,
        GameEnd
    }
}
