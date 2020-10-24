using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProSwapperMusic
{
    public class Pro
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        private static readonly string fnname = "FortniteClient-Win64-Shipping";
        public static bool IsFNFocused()
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process proc in processlist)
            {
                if (proc.ProcessName.Equals(fnname))
                {
                    string focused = getActiveWindowName();
                    if (focused == fnname)
                        return true;
                    else
                        return false;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        private static string getActiveWindowName()
        {
            try
            {
                var activatedHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {

                    if (activatedHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;

                        return processName;
                    }
                }
            }
            catch { }
            return "a";
        }
    }
}
