using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using MaterialSkin;
using System.Text;
using System;

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

            var v = Utility.GetStringFromRegedit("Screenmanager Is Fullscreen mode_h3981298716");
            FullscreenToggle.Checked = v == "1";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            inputForm.Text = "Name the Profile";
            inputForm.ShowDialog();
            if (Utility.IsValid(inputForm.Text_()))
            {
                Utility.Name = inputForm.Text_();
                Utility.WriteToDisk();
            }
            else
                MessageBox.Show("Invalid Text");
            Utility.RefreshList(ProfileList);
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

            if (Utility.PopularAnimeGameIsRunning())
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
                Utility.ReadFromDisk(text).WriteToRegedit();
            }
        }

        private void RegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistryList.SelectedItems.Count > 0)
            {
                string selected = RegistryList.SelectedItems[0].Text;
                string BinaryData_ = Utility.GetStringFromRegedit(selected);
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

            if (Utility.PopularAnimeGameIsRunning())
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

            if (!Utility.IsValid(if_.Text_()))
                MessageBox.Show("Invalid Text");
            else
            {
                Utility.RenameFromDisk(text, if_.Text_());
                Utility.RefreshList(ProfileList);
                profileCount.Text = $"{ProfileList.Items.Count} Profile/s Loaded.";
            }
        }

        private void OpenFolderButton_Click(object sender, EventArgs e) =>
            Process.Start("explorer.exe", Utility.UserDataPath);

        private void FullscreenToggle_CheckedChanged(object sender, EventArgs e) =>
            Utility.SetRegeditKey(
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
                Utility.SetRegeditKey("Screenmanager Resolution Width_h182942802", int.Parse(ScreenWidth.Text));
        }
        private void ScreenHeight_TextChanged(object sender, EventArgs e) {
            if (int.Parse(ScreenHeight.Text) < 0 || int.Parse(ScreenHeight.Text) > 2160)
            {
                MessageBox.Show("Invalid Height");
                ScreenHeight.Text = "1080";
            }
            else
                Utility.SetRegeditKey("Screenmanager Resolution Height_h2627697771", int.Parse(ScreenHeight.Text));
        }

    }
}
