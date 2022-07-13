using System;
using System.Windows.Forms;
using ProfileSwitcher.Properties;
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
            if (!Registries.Exists("Genshin Impact")) 
            {
                MessageBox.Show(string.Format(Resources.GameInstallationError, Resources.RegistryKeyNotFound), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Registries.GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810") == "")
            {
                MessageBox.Show(string.Format(Resources.AccountLoginError, Resources.RegistryKeyNotFound), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Application.Run(new Switcher());
        }
    }
}
