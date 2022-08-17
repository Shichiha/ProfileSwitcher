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
            this.Tab1 = new System.Windows.Forms.Button();
            this.Tab2 = new System.Windows.Forms.Button();
            this.Tab3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Default = new ProfileSwitcher.Tabs.Default();
            this.Settings = new ProfileSwitcher.Tabs.Settings();
            this.General = new ProfileSwitcher.Tabs.General();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            // Tab1
            // 
            this.Tab1.FlatAppearance.BorderSize = 0;
            this.Tab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab1.ForeColor = System.Drawing.Color.Transparent;
            this.Tab1.Location = new System.Drawing.Point(3, 3);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(110, 38);
            this.Tab1.TabIndex = 3;
            this.Tab1.Text = "General";
            this.Tab1.UseVisualStyleBackColor = true;
            this.Tab1.Click += new System.EventHandler(this.SwitchTab);
            // 
            // Tab2
            // 
            this.Tab2.FlatAppearance.BorderSize = 0;
            this.Tab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab2.ForeColor = System.Drawing.Color.Transparent;
            this.Tab2.Location = new System.Drawing.Point(3, 47);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(110, 38);
            this.Tab2.TabIndex = 4;
            this.Tab2.Text = "Settings";
            this.Tab2.UseVisualStyleBackColor = true;
            this.Tab2.Click += new System.EventHandler(this.SwitchTab);
            // 
            // Tab3
            // 
            this.Tab3.FlatAppearance.BorderSize = 0;
            this.Tab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab3.ForeColor = System.Drawing.Color.Transparent;
            this.Tab3.Location = new System.Drawing.Point(3, 91);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(110, 38);
            this.Tab3.TabIndex = 6;
            this.Tab3.Text = "Debug";
            this.Tab3.UseVisualStyleBackColor = true;
            this.Tab3.Click += new System.EventHandler(this.SwitchTab);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Default
            // 
            this.Default.BackColor = System.Drawing.Color.Transparent;
            this.Default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Default.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default.ForeColor = System.Drawing.Color.White;
            this.Default.Location = new System.Drawing.Point(113, 0);
            this.Default.Margin = new System.Windows.Forms.Padding(6);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(512, 370);
            this.Default.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(113, 0);
            this.Settings.Margin = new System.Windows.Forms.Padding(6);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(512, 370);
            this.Settings.TabIndex = 4;
            this.Settings.Visible = false;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.Transparent;
            this.General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.General.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.General.Location = new System.Drawing.Point(113, 0);
            this.General.Margin = new System.Windows.Forms.Padding(6);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(512, 370);
            this.General.TabIndex = 3;
            this.General.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(625, 370);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Sidebar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Profile Switcher";
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button Tab1;
        private System.Windows.Forms.Button Tab2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tabs.General General;
        private Tabs.Settings Settings;
        private Tabs.Default Default;
        private System.Windows.Forms.Button Tab3;
    }
}

