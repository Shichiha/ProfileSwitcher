using System;
using MaterialSkin.Controls;
using ProfileSwitcher.Properties;
using ProfileSwitcher.Utility;

namespace ProfileSwitcher
{
    public partial class InputForm : MaterialForm
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputBox_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!Disk.IsValid(InputBox.Text) || InputBox.Text == Resources.Default)
                return;
            Close();
        }

        public string Text_() => InputBox.Text;
        private void CancelButton_Click(object sender, EventArgs e) => Close();
    }
}
