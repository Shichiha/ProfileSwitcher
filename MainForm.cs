using System;
using System.Windows.Forms;

namespace ProfileSwitcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void SwitchTab(object sender, EventArgs e)
        {
            Default.Visible = false;
            General.Visible = sender == Tab1;
            Settings.Visible = sender == Tab2;
        }
    }
}
