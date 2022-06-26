using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Text;
using System.Linq;
using System.IO;
using System;

namespace ProfileSwitcher
{
    public class Utility
    {
        // Path Utility 
        private static string userDataPath = Path.Combine(Application.StartupPath, "UserData");
        public static string Name { get; set; }
        public string MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 { get; set; }
        public static string UserDataPath { get => userDataPath; set => userDataPath = value; }
        public static string genshinRegPath = "HKEY_CURRENT_USER\\Software\\miHoYo\\Genshin Impact";
        
        public string GetUserDataPath() => userDataPath;

        public static void InitializeDirectory(string userDataPath)
        {
            if (!Directory.Exists(userDataPath))
            {
                Directory.CreateDirectory(userDataPath);
                var info = new DirectoryInfo(userDataPath);
                info.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
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
        public static string GetStringFromRegedit(string key, bool forceStringFromByteArray = true)
        {
            var value = Registry.GetValue(genshinRegPath, key, "");
            if (value == null)
                return null;
            if (value.GetType() == typeof(byte[]) || !forceStringFromByteArray)
                return Encoding.UTF8.GetString((byte[])value);
            return value.ToString();
        }

        public static void SetRegeditKey(string key, string value)
        {
            Registry.SetValue(genshinRegPath, key, Encoding.UTF8.GetBytes(value));
        }

        public static void SetRegeditKey(string key, byte[] value)
        {
            Registry.SetValue(genshinRegPath, key, value);
        }

        public static void SetRegeditKey(string key, int value)
        {
            Registry.SetValue(genshinRegPath, key, value);
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
        public static Utility ReadFromRegedit() => new Utility { MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 = GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", false) };
        public void WriteToRegedit()
        {
            if (!string.IsNullOrWhiteSpace(MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810))
            {
                SetRegeditKey("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810);
                MessageBox.Show($"Loaded Account [{Name}]", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account not found", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        // Process Utility
        public static bool PopularAnimeGameIsRunning()
        {
            foreach (Process p in Process.GetProcessesByName("Yuanshen"))
            if (p.MainWindowTitle.Equals("Genshin Impact"))
                    return true;
            return false;
        }

        // Disk
        public static Utility ReadFromDisk(string name)
        {
            string input = File.ReadAllText(Path.Combine(Application.StartupPath, "UserData", name));
            return new JavaScriptSerializer().Deserialize<Utility>(input);
        }

        public static void WriteToDisk()
        {
            File.WriteAllText(
                Path.Combine(Application.StartupPath, "UserData", Name),
new JavaScriptSerializer().Serialize(ReadFromRegedit()));
        }

        public static void DeleteFromDisk(string name)
        { File.Delete(Path.Combine(Application.StartupPath, "UserData", name)); }

        public static void RenameFromDisk(string name, string NewName)
        {
            File.Move(
                Path.Combine(Application.StartupPath, "UserData", name),
                Path.Combine(Application.StartupPath, "UserData", NewName)
            );
        }

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

        public static void RefreshList(ListView list)
        {
            if (Directory.Exists(userDataPath))
            {
                list.Items.Clear();
                foreach (string file in Directory.GetFiles(userDataPath))
                {
                    list.Items.Add(Path.GetFileName(file), 0);
                }
            }
        }
    }
}
