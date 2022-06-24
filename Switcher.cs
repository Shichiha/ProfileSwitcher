using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;
using System.Diagnostics;

namespace ProfileSwitcher
{
    public partial class Switcher : MaterialForm
    {
        public Switcher()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            Utility.InitializeDirectory(Utility.UserDataPath);
            Utility.ArrayToList(RegistryList, Utility.GetKeyArray());
            Utility.LoadDirectory(ProfileList);

            versionCount.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
        }

        private void Switcher_Load(object sender, EventArgs e) { }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var if_ = new InputForm();
            if_.Text = "Name the Profile";
            if_.ShowDialog();
            if (Utility.IsValid(if_.Text_()))
            {
                Utility.Name = if_.Text_();
                Utility.WriteToDisk();
            }
            else MessageBox.Show("Invalid Text");
            Utility.RefreshList(ProfileList);
            profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
        }
            
        

        private void LoadButton_Click(object sender, EventArgs e) {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show("No Accounts Loaded");
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            ListViewItem item = ProfileList.SelectedItems[0];
            string text = (item != null) ? item.Text : null;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (Utility.YuanShenIsRunning())
            {
                MessageBox.Show("Close the game before switching accounts", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Switch to [{text}]", "Account Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.ReadFromDisk(text).WriteToRegedit();
            }
        }

        private void TabSelector_Click(object sender, EventArgs e) { }

        private void RegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistryList.SelectedItems.Count > 0)
            {
                String selected = RegistryList.SelectedItems[0].Text;
                String BinaryData_ = Utility.GetStringFromRegedit(selected);
                if (BinaryData == null)
                    MessageBox.Show("BinaryData is Null");
                BinaryData.Text = BinaryData_;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show("No Accounts Loaded");
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            ListViewItem item = ProfileList.SelectedItems[0];
            string text = (item != null) ? item.Text : null;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (Utility.YuanShenIsRunning())
            {
                // Just In Case!
                MessageBox.Show("Close the game before Deleting accounts", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Delete [{text}]", "Account Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.DeleteFromDisk(text);
                Utility.RefreshList(ProfileList);
                profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show("No Accounts Loaded");
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            ListViewItem item = ProfileList.SelectedItems[0];
            string text = (item != null) ? item.Text : null;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please select account", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var if_ = new InputForm();
            if_.Text = "Rename the Profile";
            if_.ShowDialog();
            if (Utility.IsValid(if_.Text_()))
            {
                Utility.RenameFromDisk(text, if_.Text_());    
                Utility.RefreshList(ProfileList);
                profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
            }
            else MessageBox.Show("Invalid Text");
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Utility.UserDataPath);
        }
    }
}
