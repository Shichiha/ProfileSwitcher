namespace ProfileSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Tab1 = new System.Windows.Forms.Button();
            this.Tab2 = new System.Windows.Forms.Button();
            this.Topbar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Tab3 = new System.Windows.Forms.Button();
            this.Debug = new ProfileSwitcher.Tabs.Debug();
            this.Default = new ProfileSwitcher.Tabs.Default();
            this.Settings = new ProfileSwitcher.Tabs.Settings();
            this.General = new ProfileSwitcher.Tabs.General();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Controls.Add(this.Tab1);
            this.Sidebar.Controls.Add(this.Tab2);
            this.Sidebar.Controls.Add(this.Tab3);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(6);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(113, 370);
            this.Sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 35);
            this.panel1.TabIndex = 5;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(4, 6);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(97, 17);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Profile Switcher";
            // 
            // Tab1
            // 
            this.Tab1.FlatAppearance.BorderSize = 0;
            this.Tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab1.ForeColor = System.Drawing.Color.Transparent;
            this.Tab1.Location = new System.Drawing.Point(3, 44);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(103, 38);
            this.Tab1.TabIndex = 3;
            this.Tab1.Text = "General";
            this.Tab1.UseVisualStyleBackColor = true;
            this.Tab1.Click += new System.EventHandler(this.Tab1_Click);
            // 
            // Tab2
            // 
            this.Tab2.FlatAppearance.BorderSize = 0;
            this.Tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab2.ForeColor = System.Drawing.Color.Transparent;
            this.Tab2.Location = new System.Drawing.Point(3, 88);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(103, 38);
            this.Tab2.TabIndex = 4;
            this.Tab2.Text = "Settings";
            this.Tab2.UseVisualStyleBackColor = true;
            this.Tab2.Click += new System.EventHandler(this.Tab2_Click);
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Topbar.Controls.Add(this.MinimizeButton);
            this.Topbar.Controls.Add(this.CloseButton);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(113, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(512, 17);
            this.Topbar.TabIndex = 0;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Location = new System.Drawing.Point(312, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(100, 17);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Location = new System.Drawing.Point(412, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 17);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            this.CloseButton.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Tab3
            // 
            this.Tab3.FlatAppearance.BorderSize = 0;
            this.Tab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab3.ForeColor = System.Drawing.Color.Transparent;
            this.Tab3.Location = new System.Drawing.Point(3, 132);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(103, 38);
            this.Tab3.TabIndex = 6;
            this.Tab3.Text = "Debug";
            this.Tab3.UseVisualStyleBackColor = true;
            this.Tab3.Click += new System.EventHandler(this.Tab3_Click);
            // 
            // Debug
            // 
            this.Debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Debug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Debug.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debug.Location = new System.Drawing.Point(113, 17);
            this.Debug.Margin = new System.Windows.Forms.Padding(6);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(512, 353);
            this.Debug.TabIndex = 5;
            // 
            // Default
            // 
            this.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Default.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default.ForeColor = System.Drawing.Color.White;
            this.Default.Location = new System.Drawing.Point(113, 17);
            this.Default.Margin = new System.Windows.Forms.Padding(6);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(512, 353);
            this.Default.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(113, 17);
            this.Settings.Margin = new System.Windows.Forms.Padding(6);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(512, 353);
            this.Settings.TabIndex = 4;
            // 
            // General
            // 
            this.General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.General.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.General.Location = new System.Drawing.Point(113, 17);
            this.General.Margin = new System.Windows.Forms.Padding(6);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(512, 353);
            this.General.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(625, 370);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Topbar);
            this.Controls.Add(this.Sidebar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button Tab1;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Button Tab2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CloseButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tabs.General General;
        private Tabs.Settings Settings;
        private Tabs.Default Default;
        private System.Windows.Forms.Panel MinimizeButton;
        private Tabs.Debug Debug;
        private System.Windows.Forms.Button Tab3;
    }
}

