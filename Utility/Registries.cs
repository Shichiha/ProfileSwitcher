﻿using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ProfileSwitcher.Properties;

namespace ProfileSwitcher.Utility
{
    internal static class Registries
    {
        // Making it clear that there's no support for China Genshin yet
        public static bool Exists(string name) => Registry.CurrentUser.OpenSubKey($"Software\\miHoYo\\{name}") != null;

        public static string GetStringFromRegedit(string key, bool forceStringFromByteArray = true)
        {
            var value = Registry.GetValue(Constants.GenshinRegPath, key, "");
            if (value == null)
                return null;
            if (value.GetType() == typeof(byte[]) || !forceStringFromByteArray)
                return Encoding.UTF8.GetString((byte[])value);
            return value.ToString();
        }

        private static void SetRegeditKey(string key, string value)
        {
            Registry.SetValue(Constants.GenshinRegPath, key, Encoding.UTF8.GetBytes(value));
        }

        public static void SetRegeditKey(string key, int value)
        {
            Registry.SetValue(Constants.GenshinRegPath, key, value);
        }

        public static Array GetKeyArray()
        {
            var key = Registry.CurrentUser.OpenSubKey("Software\\miHoYo\\Genshin Impact");
            return key?.GetValueNames();
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
                MessageBox.Show(Resources.SwitchSuccess);
            }
            else
            {
                MessageBox.Show(
                    Resources.AccountNotFound,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            }
        }
    }
}
