using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using MaterialSkin;
using System.Text;
using System;
using System.IO;

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

            Utility.Disk.InitializeDirectory(Utility.Constants.UserDataFolder);
            Utility.Registries.ArrayToList(RegistryList, Utility.Registries.GetKeyArray());
            Utility.Disk.LoadDirectory(ProfileList);
            versionCount.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";

            FullscreenToggle.Checked = Utility.Registries.GetStringFromRegedit("Screenmanager Is Fullscreen mode_h3981298716") == "1";
            ScreenHeight.Text = Utility.Registries.GetStringFromRegedit("Screenmanager Resolution Height_h2627697771");
            ScreenWidth.Text = Utility.Registries.GetStringFromRegedit("Screenmanager Resolution Width_h182942802");

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            inputForm.Text = "Name the Profile";
            inputForm.ShowDialog();
            if (Utility.Disk.IsValid(inputForm.Text_()))
            {
                Utility.UserData usDt = new Utility.UserData();
                usDt.AccountName = inputForm.Text_();
                Utility.Disk.WriteToDisk(usDt.AccountName);
            }
            else
                MessageBox.Show("Invalid Text");
            Utility.Disk.LoadUserDataToList(ProfileList);
            profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show("No Accounts Loaded");
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            ListViewItem item = ProfileList.SelectedItems[0];
            string text = item?.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            if (Utility.Utils.PopularAnimeGameIsRunning())
            {
                MessageBox.Show(
                    "Close the game before switching accounts",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            
            if (
                MessageBox.Show(
                    $"Switch to [{text}]",
                    "Account Manager",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                Utility.UserData usDt = Utility.Disk.ReadFromDisk(text);
                Utility.Registries.WriteToRegedit(usDt);
            }
        }

        private void RegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistryList.SelectedItems.Count > 0)
            {
                string selected = RegistryList.SelectedItems[0].Text;
                string BinaryData_ = Utility.Registries.GetStringFromRegedit(selected);
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
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            string text = ProfileList.SelectedItems[0]?.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            if (Utility.Utils.PopularAnimeGameIsRunning())
            {
                // Just In Case!
                MessageBox.Show(
                    "Close the game before Deleting accounts",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            if (
                MessageBox.Show(
                    $"Delete [{text}]",
                    "Account Manager",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                Utility.Disk.DeleteFromDisk(text);
                Utility.Disk.LoadUserDataToList(ProfileList);
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
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            ListViewItem item = ProfileList.SelectedItems[0];
            string text = item?.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(
                    "Please select account",
                    "Account Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }
            var if_ = new InputForm();
            if_.Text = "Rename the Profile";
            if_.ShowDialog();

            if (!Utility.Disk.IsValid(if_.Text_()))
                MessageBox.Show("Invalid Text");
            else
            {
                Utility.Disk.RenameFromDisk(text, if_.Text_());
                Utility.Disk.LoadUserDataToList(ProfileList);
                profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
            }
        }

        private void OpenFolderButton_Click(object sender, EventArgs e) =>
            Process.Start("explorer.exe", Utility.Constants.UserDataFolder);

        private void FullscreenToggle_CheckedChanged(object sender, EventArgs e) =>
            Utility.Registries.SetRegeditKey(
                "Screenmanager Is Fullscreen mode_h3981298716",
                FullscreenToggle.Checked ? 1 : 0
            );


        private void ScreenWidth_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(ScreenWidth.Text) < 0 || int.Parse(ScreenWidth.Text) > 3840)
            {
                MessageBox.Show("Invalid Width");
                ScreenWidth.Text = "1920";
            }
            else
                Utility.Registries.SetRegeditKey("Screenmanager Resolution Width_h182942802", int.Parse(ScreenWidth.Text));
        }
        private void ScreenHeight_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(ScreenHeight.Text))
                return;
            if (int.Parse(ScreenHeight.Text) < 0 || int.Parse(ScreenHeight.Text) > 2160)
            {
                MessageBox.Show("Invalid Height");
                ScreenHeight.Text = "1080";
            }
            else
                Utility.Registries.SetRegeditKey("Screenmanager Resolution Height_h2627697771", int.Parse(ScreenHeight.Text));
        }

        private void ProfileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = ProfileList.SelectedItems[0];
            string text = item?.Text;
            MessageBox.Show(Path.Combine(Application.StartupPath, "UserData", text));
        }
    }
}
