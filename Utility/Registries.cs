using System.Windows.Forms;
using Microsoft.Win32;
using System.Text;
using System;
namespace ProfileSwitcher.Utility
{
    internal class Registries
    {
        public static string GetStringFromRegedit(string key, bool forceStringFromByteArray = true)
        {
            var value = Registry.GetValue(Constants.genshinRegPath, key, "");
            if (value == null)
                return null;
            if (value.GetType() == typeof(byte[]) || !forceStringFromByteArray)
                return Encoding.UTF8.GetString((byte[])value);
            return value.ToString();
        }

        public static void SetRegeditKey(string key, string value)
        {
            Registry.SetValue(Constants.genshinRegPath, key, Encoding.UTF8.GetBytes(value));
        }

        public static void SetRegeditKey(string key, byte[] value)
        {
            Registry.SetValue(Constants.genshinRegPath, key, value);
        }

        public static void SetRegeditKey(string key, int value)
        {
            Registry.SetValue(Constants.genshinRegPath, key, value);
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
        public static UserData ReadFromRegedit() => new UserData
        { AccountDataList = GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", false) };

        public static void WriteToRegedit(UserData usDt)
        {
            if (!string.IsNullOrWhiteSpace(usDt.AccountDataList))
            {
                SetRegeditKey(
                    "MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810",
                    usDt.AccountDataList
                );
                MessageBox.Show("Switch Success!");
            }
            else
            {
                MessageBox.Show(
                    "Account not found",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
                return;
            }
        }
    }
}
