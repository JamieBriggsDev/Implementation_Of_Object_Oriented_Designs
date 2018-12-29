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
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.StaffNameComboBox = new System.Windows.Forms.ComboBox();
            this.JobLabel = new System.Windows.Forms.Label();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Location = new System.Drawing.Point(12, 9);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(63, 13);
            this.StaffNameLabel.TabIndex = 0;
            this.StaffNameLabel.Text = "Staff Name:";
            // 
            // StaffNameComboBox
            // 
            this.StaffNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffNameComboBox.FormattingEnabled = true;
            this.StaffNameComboBox.Location = new System.Drawing.Point(81, 6);
            this.StaffNameComboBox.Name = "StaffNameComboBox";
            this.StaffNameComboBox.Size = new System.Drawing.Size(237, 21);
            this.StaffNameComboBox.TabIndex = 1;
            this.StaffNameComboBox.SelectedIndexChanged += new System.EventHandler(this.StaffNameComboBox_SelectedIndexChanged);
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(48, 33);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(27, 13);
            this.JobLabel.TabIndex = 2;
            this.JobLabel.Text = "Job:";
            // 
            // JobComboBox
            // 
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(81, 30);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(237, 21);
            this.JobComboBox.TabIndex = 3;
            this.JobComboBox.SelectedIndexChanged += new System.EventHandler(this.JobComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(243, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignButton.Enabled = false;
            this.AssignButton.Location = new System.Drawing.Point(162, 58);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(75, 23);
            this.AssignButton.TabIndex = 5;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // AssignStaffToJob
            // 
            this.AcceptButton = this.AssignButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 93);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.StaffNameComboBox);
            this.Controls.Add(this.StaffNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignStaffToJob";
            this.Text = "Assign Staff To Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignStaffToJobForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.ComboBox StaffNameComboBox;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AssignButton;
    }
}