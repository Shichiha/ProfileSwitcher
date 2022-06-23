using System;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProfileSwitcher
{
    public class Utility
    {
        // Utility Things
        public string Log(string format, params object[] args)
        {
            return string.Format(format, args);
        }

        // userdata path
        private static string userDataPath = Path.Combine(Application.StartupPath, "UserData");
        public static string Name { get; set; }
        public string MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 { get; set; }
        public static string UserDataPath { get => userDataPath; set => userDataPath = value; }
        public static string genshinRegPath = "HKEY_CURRENT_USER\\Software\\miHoYo\\Genshin Impact";

        // Disk
        public static Utility ReadFromDisk(string name)
        {
            string input = File.ReadAllText(Path.Combine(Application.StartupPath, "UserData", name));
            return new JavaScriptSerializer().Deserialize<Utility>(input);
        }

        public static void WriteToDisk()
        { File.WriteAllText(Path.Combine(Application.StartupPath, "UserData", Name), new JavaScriptSerializer().Serialize(new Utility())); }

        public static void DeleteFromDisk(string name)
        { File.Delete(Path.Combine(Application.StartupPath, "UserData", name)); }

        public static bool IsValid(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            if (text.Length > 20)
                return false;
            if (Regex.IsMatch(text, @"[<>:""/\\|?*]"))
               return false;
            var reservedNames = new string[]
            {
                "con",
                "nul",
                "aux",
                "com1",
                "com2",
                "com3",
                "com4",
                "com5",
                "com6",
                "com7",
                "com8",
                "com9",
                "lpt1",
                "lpt2",
                "lpt3",
                "lpt4",
                "lpt5",
                "lpt6",
                "lpt7",
                "lpt8",
                "lpt9"
            };
            // anti windows reserved name bypasss 100% working undetected
            if (reservedNames.Contains(text.ToLower()))
                return false;
            return true;
        }

        public string GetUserDataPath() => userDataPath;

        public static void InitializeDirectory(string userDataPath)
        {
            if (!Directory.Exists(userDataPath))
                Directory.CreateDirectory(userDataPath);
        }

        public static void LoadDirectory(ListView listView)
        {
            if (Directory.Exists(userDataPath))
            {
                foreach (string file in Directory.GetFiles(userDataPath))
                {
                    listView.Items.Add(Path.GetFileName(file), 0);
                }
            }
        }

        // Registries
        public static string GetStringFromRegedit(string key)
        {
            // WTF is a System.Byte[]?????????
            var value = Registry.GetValue(genshinRegPath, key, "");
            if (value == null)
                return null;
            if (value.GetType() == typeof(byte[]))
                return Encoding.UTF8.GetString((byte[])value);
            return value.ToString();
        }

        private static void SetStringToRegedit(string key, string value)
        {
            Registry.SetValue(genshinRegPath, key, Encoding.UTF8.GetBytes(value));
        }

        public static Array GetKeyArray()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\miHoYo\\Genshin Impact");
            return key.GetValueNames();
        }

        public static void ArrayToList(ListView list, Array array)
        {
            foreach (string item in array)
            {
                list.Items.Add(item, 0);
            }
        }
        
        // Load Utility
        public static Utility ReadFromRegedit()
        {
            return new Utility
            {MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 = Utility.GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810")};
        }

        public void WriteToRegedit()
        {
            if (string.IsNullOrWhiteSpace(this.MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810))
            {
                MessageBox.Show("Account not found", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            SetStringToRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", this.MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810);
            MessageBox.Show(this.Log("Switched to account [{0}]", Name), "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Process Utility
        public static bool YuanShenIsRunning()
        {
            foreach (Process p in Process.GetProcessesByName("Yuanshen"))
                if (p.MainWindowTitle == "Genshin Impact")
                    return true;
            return false;
        }

        // String Format Utility
        public static string format(string format, params object[] args)
        {
            return string.Format(format, args);
        }

    }
}
