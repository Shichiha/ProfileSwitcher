namespace ProfileSwitcher
{
    partial class InputForm
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
            this.InputBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConfirmButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InputBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.InputBox.Depth = 0;
            this.InputBox.Font = new System.Drawing.Font("JetBrains Mono NL", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Hint = "";
            this.InputBox.Location = new System.Drawing.Point(15, 78);
            this.InputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.SelectedText = "";
            this.InputBox.SelectionLength = 0;
            this.InputBox.SelectionStart = 0;
            this.InputBox.Size = new System.Drawing.Size(295, 23);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "Default";
            this.InputBox.UseSystemPasswordChar = false;
            this.InputBox.Click += new System.EventHandler(this.InputBox_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSize = true;
            this.ConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConfirmButton.Depth = 0;
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ConfirmButton.FlatAppearance.BorderSize = 10;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(236, 122);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Primary = false;
            this.ConfirmButton.Size = new System.Drawing.Size(72, 36);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Location = new System.Drawing.Point(15, 122);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(64, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(0, 62);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(321, 111);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // InputForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(321, 173);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.materialDivider1);
            this.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField InputBox;
        private MaterialSkin.Controls.MaterialFlatButton ConfirmButton;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}