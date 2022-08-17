using System;
using System.Windows.Forms;
using System.IO;

namespace ProfileSwitcher.Tabs
{
    public partial class General : UserControl
    {
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            AccountView.Items.Clear();
            string path = Utility.Constants.UserDataFolder;
            if (Directory.Exists(path))
                foreach (string file in Directory.GetFiles(path))
                    AccountView.Items.Add(Path.GetFileNameWithoutExtension(file));
        }

        public General()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utility.Constants.UserDataFolder);
        }
    }
}
