using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ProfileSwitcher.Utility
{
    internal class Disk
    {
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
            if (Directory.Exists(Constants.UserDataFolder))
            {
                foreach (string file in Directory.GetFiles(Constants.UserDataFolder))
                {
                    listView.Items.Add(Path.GetFileName(file), 0);
                }
            }
        }

        public static UserData ReadFromDisk(string name)
        {
            string input = File.ReadAllText(
                Path.Combine(Application.StartupPath, "UserData", name)
            );
            return new JavaScriptSerializer().Deserialize<UserData>(input);
        }

        public static void WriteToDisk(string name)
        {
            File.WriteAllText(
                Path.Combine(Application.StartupPath, "UserData", name),
                new JavaScriptSerializer().Serialize(Registries.ReadFromRegedit())
            );
        }

        public static void DeleteFromDisk(string name) =>
            File.Delete(Path.Combine(Application.StartupPath, "UserData", name));

        public static void RenameFromDisk(string name, string newName)
        {
            File.Move(
                Path.Combine(Application.StartupPath, "UserData", name),
                Path.Combine(Application.StartupPath, "UserData", newName)
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
            var Reserved = new Regex("con|nul|aux|com[1-9]|lpt[1-9]");
            var Valid = Reserved.IsMatch(text.ToLower()) ? true : false;
            return Valid;
                
        }

        public static void LoadUserDataToList(ListView list)
        {
            if (Directory.Exists(Constants.UserDataFolder))
            {
                list.Items.Clear();
                foreach (string file in Directory.GetFiles(Constants.UserDataFolder))
                {
                    list.Items.Add(Path.GetFileName(file), 0);
                }
            }
        }
    }
}
