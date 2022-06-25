namespace ProfileSwitcher
{
    partial class Switcher
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switcher));
            this.ProfileList = new System.Windows.Forms.ListView();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoadButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.OpenFolderButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RenameButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.profileCount = new MaterialSkin.Controls.MaterialLabel();
            this.versionCount = new MaterialSkin.Controls.MaterialLabel();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.SettingsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.SettingsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ScreenWidth = new System.Windows.Forms.TextBox();
            this.ScreenHeight = new System.Windows.Forms.TextBox();
            this.FullscreenToggle = new MaterialSkin.Controls.MaterialCheckBox();
            this.AdViewPage = new System.Windows.Forms.TabPage();
            this.BinaryData = new System.Windows.Forms.RichTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.RegistryList = new System.Windows.Forms.ListView();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SettingsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AdViewPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileList
            // 
            resources.ApplyResources(this.ProfileList, "ProfileList");
            this.ProfileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProfileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfileList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ProfileList.HideSelection = false;
            this.ProfileList.MultiSelect = false;
            this.ProfileList.Name = "ProfileList";
            this.ProfileList.UseCompatibleStateImageBehavior = false;
            this.ProfileList.View = System.Windows.Forms.View.List;
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Depth = 0;
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            resources.ApplyResources(this.LoadButton, "LoadButton");
            this.LoadButton.Depth = 0;
            this.LoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Primary = false;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MainPage);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Controls.Add(this.AdViewPage);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl.Depth = 0;
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPage.Controls.Add(this.OpenFolderButton);
            this.MainPage.Controls.Add(this.RenameButton);
            this.MainPage.Controls.Add(this.DeleteButton);
            this.MainPage.Controls.Add(this.profileCount);
            this.MainPage.Controls.Add(this.versionCount);
            this.MainPage.Controls.Add(this.LoadButton);
            this.MainPage.Controls.Add(this.ProfileList);
            this.MainPage.Controls.Add(this.SaveButton);
            resources.ApplyResources(this.MainPage, "MainPage");
            this.MainPage.Name = "MainPage";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // OpenFolderButton
            // 
            resources.ApplyResources(this.OpenFolderButton, "OpenFolderButton");
            this.OpenFolderButton.Depth = 0;
            this.OpenFolderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Primary = false;
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // RenameButton
            // 
            resources.ApplyResources(this.RenameButton, "RenameButton");
            this.RenameButton.Depth = 0;
            this.RenameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Primary = false;
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Depth = 0;
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // profileCount
            // 
            resources.ApplyResources(this.profileCount, "profileCount");
            this.profileCount.Depth = 0;
            this.profileCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileCount.Name = "profileCount";
            // 
            // versionCount
            // 
            resources.ApplyResources(this.versionCount, "versionCount");
            this.versionCount.Depth = 0;
            this.versionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionCount.Name = "versionCount";
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.SettingsTabSelector);
            this.SettingsPage.Controls.Add(this.SettingsTabControl);
            resources.ApplyResources(this.SettingsPage, "SettingsPage");
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // SettingsTabSelector
            // 
            this.SettingsTabSelector.BaseTabControl = this.SettingsTabControl;
            this.SettingsTabSelector.Depth = 0;
            resources.ApplyResources(this.SettingsTabSelector, "SettingsTabSelector");
            this.SettingsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsTabSelector.Name = "SettingsTabSelector";
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.tabPage1);
            this.SettingsTabControl.Depth = 0;
            resources.ApplyResources(this.SettingsTabControl, "SettingsTabControl");
            this.SettingsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ScreenWidth);
            this.tabPage1.Controls.Add(this.FullscreenToggle);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.ScreenHeight);
            this.tabPage1.Controls.Add(this.materialLabel1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // ScreenWidth
            // 
            this.ScreenWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ScreenWidth, "ScreenWidth");
            this.ScreenWidth.Name = "ScreenWidth";
            this.ScreenWidth.TextChanged += new System.EventHandler(this.ScreenWidth_TextChanged);
            // 
            // ScreenHeight
            // 
            this.ScreenHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ScreenHeight, "ScreenHeight");
            this.ScreenHeight.Name = "ScreenHeight";
            this.ScreenHeight.TextChanged += new System.EventHandler(this.ScreenHeight_TextChanged);
            // 
            // FullscreenToggle
            // 
            resources.ApplyResources(this.FullscreenToggle, "FullscreenToggle");
            this.FullscreenToggle.Depth = 0;
            this.FullscreenToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FullscreenToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.FullscreenToggle.Name = "FullscreenToggle";
            this.FullscreenToggle.Ripple = true;
            this.FullscreenToggle.UseVisualStyleBackColor = true;
            this.FullscreenToggle.CheckedChanged += new System.EventHandler(this.FullscreenToggle_CheckedChanged);
            // 
            // AdViewPage
            // 
            this.AdViewPage.Controls.Add(this.BinaryData);
            this.AdViewPage.Controls.Add(this.materialDivider1);
            this.AdViewPage.Controls.Add(this.RegistryList);
            resources.ApplyResources(this.AdViewPage, "AdViewPage");
            this.AdViewPage.Name = "AdViewPage";
            this.AdViewPage.UseVisualStyleBackColor = true;
            // 
            // BinaryData
            // 
            this.BinaryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.BinaryData, "BinaryData");
            this.BinaryData.Name = "BinaryData";
            this.BinaryData.ReadOnly = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            resources.ApplyResources(this.materialDivider1, "materialDivider1");
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            // 
            // RegistryList
            // 
            this.RegistryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RegistryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistryList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegistryList.HideSelection = false;
            resources.ApplyResources(this.RegistryList, "RegistryList");
            this.RegistryList.MultiSelect = false;
            this.RegistryList.Name = "RegistryList";
            this.RegistryList.UseCompatibleStateImageBehavior = false;
            this.RegistryList.View = System.Windows.Forms.View.List;
            this.RegistryList.SelectedIndexChanged += new System.EventHandler(this.RegistryList_SelectedIndexChanged);
            // 
            // TabSelector
            // 
            resources.ApplyResources(this.TabSelector, "TabSelector");
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabSelector.Depth = 0;
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            // 
            // Switcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Switcher";
            this.Sizable = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AdViewPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProfileList;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
        private MaterialSkin.Controls.MaterialFlatButton LoadButton;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private System.Windows.Forms.TabPage AdViewPage;
        private System.Windows.Forms.ListView RegistryList;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.RichTextBox BinaryData;
        private MaterialSkin.Controls.MaterialLabel versionCount;
        private MaterialSkin.Controls.MaterialLabel profileCount;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private MaterialSkin.Controls.MaterialFlatButton RenameButton;
        private MaterialSkin.Controls.MaterialFlatButton OpenFolderButton;
        private MaterialSkin.Controls.MaterialCheckBox FullscreenToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox ScreenWidth;
        private System.Windows.Forms.TextBox ScreenHeight;
        private MaterialSkin.Controls.MaterialTabSelector SettingsTabSelector;
        private MaterialSkin.Controls.MaterialTabControl SettingsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

