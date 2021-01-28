using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProSwapperMusic
{
    public class Pro
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        private const string fnproc = "FortniteClient-Win64-Shipping";
        public static bool IsFNFocused
        {
            get
            {
                try
                {
                    var activatedHandle = GetForegroundWindow();
                    Process[] processes = Process.GetProcessesByName(fnproc);
                    foreach (Process proc in processes)
                    {
                        if (activatedHandle == proc.MainWindowHandle && proc.ProcessName == fnproc)
                        {
                            return true;
                        }
                    }
                }
                catch {}
                return false;
            }
            
        }
    }
}
