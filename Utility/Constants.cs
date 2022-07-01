using System.Windows.Forms;
using System.IO;
namespace ProfileSwitcher.Utility
{
    internal class Constants
    {
        public static string UserDataFolder = Path.Combine(Application.StartupPath, "UserData");
        public static string genshinRegPath = "HKEY_CURRENT_USER\\Software\\miHoYo\\Genshin Impact";
    }
}
