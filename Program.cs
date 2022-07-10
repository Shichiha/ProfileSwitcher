using System;
using System.Windows.Forms;
using ProfileSwitcher.Utility;

namespace ProfileSwitcher
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // TODO: Add Support for Bilibili server / China
            if (!Registries.IsOversea())
            {
                MessageBox.Show(@"Genshin Impact registry key not found. Please make sure you have installed Genshin Impact on your PC.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Registries.GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810") == "")
            {
                MessageBox.Show(@"Genshin Impact registry key not found. Please make sure you have logged-in to an account beforehand.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Application.Run(new Switcher());
        }
    }
}
