using System.Diagnostics;

namespace ProfileSwitcher.Utility
{
    internal class Utils
    {
        public static bool PopularAnimeGameIsRunning()
        {
            foreach (Process p in Process.GetProcessesByName("Yuanshen"))
                if (p.MainWindowTitle.Equals("Genshin Impact"))
                    return true;
            return false;
        }
    }
}
