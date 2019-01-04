namespace View.View
{
    partial class AssignStaffToJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignStaffToJob));
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.StaffNameComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Location = new System.Drawing.Point(16, 11);
            this.StaffNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(82, 17);
            this.StaffNameLabel.TabIndex = 0;
            this.StaffNameLabel.Text = "Staff Name:";
            // 
            // StaffNameComboBox
            // 
            this.StaffNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffNameComboBox.FormattingEnabled = true;
            this.StaffNameComboBox.Location = new System.Drawing.Point(108, 7);
            this.StaffNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffNameComboBox.Name = "StaffNameComboBox";
            this.StaffNameComboBox.Size = new System.Drawing.Size(315, 24);
            this.StaffNameComboBox.TabIndex = 1;
            this.StaffNameComboBox.SelectedIndexChanged += new System.EventHandler(this.StaffNameComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(324, 46);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignButton.Enabled = false;
            this.AssignButton.Location = new System.Drawing.Point(216, 46);
            this.AssignButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(100, 28);
            this.AssignButton.TabIndex = 5;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // AssignStaffToJob
            // 
            this.AcceptButton = this.AssignButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 86);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StaffNameComboBox);
            this.Controls.Add(this.StaffNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignStaffToJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Staff To Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignStaffToJobForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.ComboBox StaffNameComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AssignButton;
    }
}