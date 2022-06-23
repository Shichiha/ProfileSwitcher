using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;

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
            profileCount.Text = Utility.format("{0} Profile/s Loaded.", ProfileList.Items.Count.ToString());
        }

        private void Switcher_Load(object sender, EventArgs e) { }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var if_ = new InputForm();
            if_.Text = "Name the Profile";
            if_.ShowDialog();
            if (Utility.IsValid(if_.Text_()))
            {
                Utility YSAccount = Utility.ReadFromRegedit();
                Utility.Name = if_.Text_();
                Utility.WriteToDisk();
            }
            else MessageBox.Show("Invalid Text");
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

            if (MessageBox.Show("Switch to [" + text + "]", "Account Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
