using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;

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
            if (Utility.IsValid(InputBox.Text) && InputBox.Text != "Default")
                Close();
        }

        public string Text_()
        {
            return InputBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
