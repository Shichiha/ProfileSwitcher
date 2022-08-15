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
            var reservedNames = new[]
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
            if (reservedNames.Contains(text.ToLower()))
                return false;
            return true;
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
