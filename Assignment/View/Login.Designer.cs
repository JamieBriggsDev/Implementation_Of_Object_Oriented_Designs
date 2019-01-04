namespace View
{
    partial class Login
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
            this.StaffComboBox = new System.Windows.Forms.ComboBox();
            this.StaffLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffComboBox
            // 
            this.StaffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.Location = new System.Drawing.Point(53, 20);
            this.StaffComboBox.Name = "StaffComboBox";
            this.StaffComboBox.Size = new System.Drawing.Size(202, 21);
            this.StaffComboBox.TabIndex = 0;
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Location = new System.Drawing.Point(12, 23);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(35, 13);
            this.StaffLabel.TabIndex = 1;
            this.StaffLabel.Text = "Staff: ";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 52);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(243, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 84);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.StaffComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StaffComboBox;
        private System.Windows.Forms.Label StaffLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}