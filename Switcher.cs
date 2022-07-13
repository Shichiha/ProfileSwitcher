using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ProfileSwitcher.Properties;
using ProfileSwitcher.Utility;
using static System.Int32;

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

            Disk.InitializeDirectory(Constants.UserDataFolder);
            Registries.ArrayToList(RegistryList, Registries.GetKeyArray());
            Disk.LoadDirectory(ProfileList);

            versionCount.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            profileCount.Text = string.Format(Resources.ProfilesLoaded, ProfileList.Items.Count);

            FullscreenToggle.Checked =
                Registries.GetStringFromRegedit("Screenmanager Is Fullscreen mode_h3981298716") == "1";
            ScreenHeight.Text = Registries.GetStringFromRegedit("Screenmanager Resolution Height_h2627697771");
            ScreenWidth.Text = Registries.GetStringFromRegedit("Screenmanager Resolution Width_h182942802");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            inputForm.Text = Resources.NameTheProfile;
            inputForm.ShowDialog();
            if (Disk.IsValid(inputForm.Text_()))
            {
                var usDt = new UserData
                {
                    AccountName = null,
                    AccountDataList = null
                };
                usDt.AccountName = inputForm.Text_();
                Disk.WriteToDisk(usDt.AccountName);
            }
            else
                MessageBox.Show(Resources.InvalidText);

            Disk.LoadUserDataToList(ProfileList);
            profileCount.Text = string.Format(Resources.ProfilesLoaded, ProfileList.Items.Count);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show(Resources.NoAccountsLoaded);
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    Resources.SelectAccount,
                    Resources.Account,
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
                    Resources.SelectAccount,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            if (Utils.PopularAnimeGameIsRunning())
            {
                MessageBox.Show(
                    Resources.GameOpenError,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }


            if (
                MessageBox.Show(
                    string.Format(Resources.SwitchTo, text),
                    Resources.Account,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                UserData usDt = Disk.ReadFromDisk(text);
                Registries.WriteToRegedit(usDt);
            }
        }

        private void RegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistryList.SelectedItems.Count > 0)
            {
                string selected = RegistryList.SelectedItems[0].Text;
                string binaryData = Registries.GetStringFromRegedit(selected);
                if (BinaryData == null)
                    MessageBox.Show(Resources.BinaryDataNull);
                if (BinaryData != null) BinaryData.Text = binaryData;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show(Resources.NoAccountsLoaded);
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    Resources.SelectAccount,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            string text = ProfileList.SelectedItems[0]?.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(
                    Resources.SelectAccount,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            if (Utils.PopularAnimeGameIsRunning())
            {
                // Just In Case!
                MessageBox.Show(
                    Resources.GameOpenError2,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            if (
                MessageBox.Show(
                    string.Format(Resources.Delete, text),
                    Resources.Account,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                Disk.DeleteFromDisk(text);
                Disk.LoadUserDataToList(ProfileList);
                profileCount.Text = string.Format(Resources.ProfilesLoaded, ProfileList.Items.Count);
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (ProfileList.Items.Count <= 0)
            {
                MessageBox.Show(Resources.NoAccountsLoaded);
                return;
            }

            if (ProfileList.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    Resources.SelectAccount,
                    Resources.Account,
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
                    Resources.SelectAccount,
                    Resources.Account,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                return;
            }

            var inpForm = new InputForm();
            inpForm.Text = Resources.Rename;
            inpForm.ShowDialog();

            if (!Disk.IsValid(inpForm.Text_()))
                MessageBox.Show(Resources.InvalidText);
            else
            {
                Disk.RenameFromDisk(text, inpForm.Text_());
                Disk.LoadUserDataToList(ProfileList);
                profileCount.Text = string.Format(Resources.ProfilesLoaded, ProfileList.Items.Count);
            }
        }

        private void OpenFolderButton_Click(object sender, EventArgs e) =>
            Process.Start("explorer.exe", Constants.UserDataFolder);

        private void FullscreenToggle_CheckedChanged(object sender, EventArgs e) =>
            Registries.SetRegeditKey(
                "Screenmanager Is Fullscreen mode_h3981298716",
                FullscreenToggle.Checked ? 1 : 0
            );


        private void ScreenWidth_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ScreenHeight.Text))
                return;
            if (Parse(ScreenWidth.Text) < 0 || Parse(ScreenWidth.Text) > 3840)
            {
                MessageBox.Show(Resources.InvalidWidth);
                ScreenWidth.Text = @"1920";
            }
            else
                Registries.SetRegeditKey("Screenmanager Resolution Width_h182942802", Parse(ScreenWidth.Text));
        }

        private void ScreenHeight_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ScreenHeight.Text))
                return;
            if (Parse(ScreenHeight.Text) < 0 || Parse(ScreenHeight.Text) > 2160)
            {
                MessageBox.Show(Resources.InvalidHeight);
                ScreenHeight.Text = @"1080";
            }
            else
                Registries.SetRegeditKey("Screenmanager Resolution Height_h2627697771", Parse(ScreenHeight.Text));
        }

        private void MakeDemoWindow_Click(object sender, EventArgs e)
        {
            var f = new Form();
            f.Size = new Size(Convert.ToInt32(ScreenWidth.Text), Convert.ToInt32(ScreenHeight.Text));
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.Show();
        }
    }
}