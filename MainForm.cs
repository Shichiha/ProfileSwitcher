using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfileSwitcher
{
    public partial class MainForm : Form
    {
        private float lerp(float a, float b, float f)
        {
            return a + f * (b - a);
        }

        public MainForm()
        {
            InitializeComponent();
            General.Visible = false;
            Settings.Visible = false;
            Debug.Visible = false;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = new Point(dragFormPoint.X + dif.X, dragFormPoint.Y + dif.Y);
            }
        }

        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            var z = CloseButton.BackColor;
            var dark = 50;
            CloseButton.BackColor = Color.FromArgb(z.R + dark, z.G + dark, z.B + dark);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(179, 48, 48);
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            for (float f = 0; f < 1; f += 0.1f)
            {
                Opacity = lerp(1, 0, f);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            Opacity = 0;
            System.Threading.Thread.Sleep(50);
            Close();
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            var z = MinimizeButton.BackColor;
            var dark = 50;
            MinimizeButton.BackColor = Color.FromArgb(z.R + dark, z.G + dark, z.B + dark);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.BackColor = System.Drawing.Color.Gray;
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SwitchTab(object sender, EventArgs e)
        {
            Default.Visible = false;
            General.Visible = sender == Tab1;
            Settings.Visible = sender == Tab2;
            Debug.Visible = sender == Tab3;
        }

        private void Tab1_Click(object sender, EventArgs e)
        {
            SwitchTab(sender, e);
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            SwitchTab(sender, e);
        }

        private void Tab3_Click(object sender, EventArgs e)
        {
            SwitchTab(sender, e);
        }
    }
}
