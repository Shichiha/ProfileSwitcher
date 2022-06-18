using System;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProfileSwitcher
{
    public class Utility
    {
        public string Name { get; set; }
        public string MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 { get; set; }
        public static Utility ReadFromDisk(string name)
        {
            string input = File.ReadAllText(Path.Combine(Application.StartupPath, "UserData", name));
            return new JavaScriptSerializer().Deserialize<Utility>(input);
        }
        public void WriteToDisk()
        {
            File.WriteAllText(Path.Combine(Application.StartupPath, "UserData", this.Name), new JavaScriptSerializer().Serialize(this));
        }
        public static void DeleteFromDisk(string name)
        {
            File.Delete(Path.Combine(Application.StartupPath, "UserData", name));
        }
        public static Utility ReadFromRegedit()
        {
            return new Utility
            {
                MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 = Utility.GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810")
            };
        }
        public void WriteToRegedit()
        {
            if (string.IsNullOrWhiteSpace(this.MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810))
            {
                MessageBox.Show("Account not found", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Utility.SetStringToRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", this.MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810);
            MessageBox.Show("Account [" + this.Name + "] switched successfully", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private static string GetStringFromRegedit(string key)
        {
            object value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\miHoYo\\Genshin Impact", key, "");
            return Encoding.UTF8.GetString((byte[])value);
        }
        private static void SetStringToRegedit(string key, string value)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\miHoYo\\Genshin Impact", key, Encoding.UTF8.GetBytes(value));
        }
    }
}
