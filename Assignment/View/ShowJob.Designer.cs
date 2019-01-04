namespace View
{
    partial class ShowJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowJob));
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.JobRegisteredLabel = new System.Windows.Forms.Label();
            this.JobDueLabel = new System.Windows.Forms.Label();
            this.FaultDescriptionLabel = new System.Windows.Forms.Label();
            this.AttachmentLabel = new System.Windows.Forms.Label();
            this.UrgencyLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.MachineNameTextBox = new System.Windows.Forms.TextBox();
            this.FaultDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.JobRegisteredDateTime = new System.Windows.Forms.DateTimePicker();
            this.JobDueDateTime = new System.Windows.Forms.DateTimePicker();
            this.AttachmentPictureBox = new System.Windows.Forms.PictureBox();
            this.UrgencyComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.JobIDLabel = new System.Windows.Forms.Label();
            this.JobIDTextBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.OpenCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(57, 53);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(88, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Location = new System.Drawing.Point(37, 86);
            this.MachineNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(106, 17);
            this.MachineNameLabel.TabIndex = 1;
            this.MachineNameLabel.Text = "Machine Name:";
            // 
            // JobRegisteredLabel
            // 
            this.JobRegisteredLabel.AutoSize = true;
            this.JobRegisteredLabel.Location = new System.Drawing.Point(37, 121);
            this.JobRegisteredLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobRegisteredLabel.Name = "JobRegisteredLabel";
            this.JobRegisteredLabel.Size = new System.Drawing.Size(108, 17);
            this.JobRegisteredLabel.TabIndex = 2;
            this.JobRegisteredLabel.Text = "Job Registered:";
            // 
            // JobDueLabel
            // 
            this.JobDueLabel.AutoSize = true;
            this.JobDueLabel.Location = new System.Drawing.Point(79, 154);
            this.JobDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobDueLabel.Name = "JobDueLabel";
            this.JobDueLabel.Size = new System.Drawing.Size(65, 17);
            this.JobDueLabel.TabIndex = 3;
            this.JobDueLabel.Text = "Job Due:";
            // 
            // FaultDescriptionLabel
            // 
            this.FaultDescriptionLabel.AutoSize = true;
            this.FaultDescriptionLabel.Location = new System.Drawing.Point(453, 18);
            this.FaultDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FaultDescriptionLabel.Name = "FaultDescriptionLabel";
            this.FaultDescriptionLabel.Size = new System.Drawing.Size(118, 17);
            this.FaultDescriptionLabel.TabIndex = 4;
            this.FaultDescriptionLabel.Text = "Fault Description:";
            // 
            // AttachmentLabel
            // 
            this.AttachmentLabel.AutoSize = true;
            this.AttachmentLabel.Location = new System.Drawing.Point(487, 222);
            this.AttachmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttachmentLabel.Name = "AttachmentLabel";
            this.AttachmentLabel.Size = new System.Drawing.Size(83, 17);
            this.AttachmentLabel.TabIndex = 5;
            this.AttachmentLabel.Text = "Attachment:";
            // 
            // UrgencyLabel
            // 
            this.UrgencyLabel.AutoSize = true;
            this.UrgencyLabel.Location = new System.Drawing.Point(80, 185);
            this.UrgencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UrgencyLabel.Name = "UrgencyLabel";
            this.UrgencyLabel.Size = new System.Drawing.Size(65, 17);
            this.UrgencyLabel.TabIndex = 6;
            this.UrgencyLabel.Text = "Urgency:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(156, 49);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = true;
            this.ClientNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.ClientNameTextBox.TabIndex = 7;
            // 
            // MachineNameTextBox
            // 
            this.MachineNameTextBox.Location = new System.Drawing.Point(156, 82);
            this.MachineNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MachineNameTextBox.Name = "MachineNameTextBox";
            this.MachineNameTextBox.ReadOnly = true;
            this.MachineNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.MachineNameTextBox.TabIndex = 8;
            // 
            // FaultDescriptionTextBox
            // 
            this.FaultDescriptionTextBox.Location = new System.Drawing.Point(585, 15);
            this.FaultDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FaultDescriptionTextBox.Name = "FaultDescriptionTextBox";
            this.FaultDescriptionTextBox.ReadOnly = true;
            this.FaultDescriptionTextBox.Size = new System.Drawing.Size(284, 198);
            this.FaultDescriptionTextBox.TabIndex = 9;
            this.FaultDescriptionTextBox.Text = "";
            // 
            // JobRegisteredDateTime
            // 
            this.JobRegisteredDateTime.Enabled = false;
            this.JobRegisteredDateTime.Location = new System.Drawing.Point(156, 116);
            this.JobRegisteredDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobRegisteredDateTime.Name = "JobRegisteredDateTime";
            this.JobRegisteredDateTime.Size = new System.Drawing.Size(284, 22);
            this.JobRegisteredDateTime.TabIndex = 10;
            // 
            // JobDueDateTime
            // 
            this.JobDueDateTime.Enabled = false;
            this.JobDueDateTime.Location = new System.Drawing.Point(156, 149);
            this.JobDueDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobDueDateTime.Name = "JobDueDateTime";
            this.JobDueDateTime.Size = new System.Drawing.Size(284, 22);
            this.JobDueDateTime.TabIndex = 11;
            // 
            // AttachmentPictureBox
            // 
            this.AttachmentPictureBox.Location = new System.Drawing.Point(585, 222);
            this.AttachmentPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttachmentPictureBox.Name = "AttachmentPictureBox";
            this.AttachmentPictureBox.Size = new System.Drawing.Size(285, 223);
            this.AttachmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttachmentPictureBox.TabIndex = 12;
            this.AttachmentPictureBox.TabStop = false;
            // 
            // UrgencyComboBox
            // 
            this.UrgencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrgencyComboBox.Enabled = false;
            this.UrgencyComboBox.FormattingEnabled = true;
            this.UrgencyComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.UrgencyComboBox.Location = new System.Drawing.Point(156, 181);
            this.UrgencyComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrgencyComboBox.Name = "UrgencyComboBox";
            this.UrgencyComboBox.Size = new System.Drawing.Size(67, 24);
            this.UrgencyComboBox.TabIndex = 13;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(16, 469);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 28);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit...";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(733, 473);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(625, 473);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(843, 473);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // JobIDLabel
            // 
            this.JobIDLabel.AutoSize = true;
            this.JobIDLabel.Location = new System.Drawing.Point(91, 18);
            this.JobIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobIDLabel.Name = "JobIDLabel";
            this.JobIDLabel.Size = new System.Drawing.Size(52, 17);
            this.JobIDLabel.TabIndex = 18;
            this.JobIDLabel.Text = "Job ID:";
            // 
            // JobIDTextBox
            // 
            this.JobIDTextBox.Location = new System.Drawing.Point(156, 15);
            this.JobIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JobIDTextBox.Name = "JobIDTextBox";
            this.JobIDTextBox.ReadOnly = true;
            this.JobIDTextBox.Size = new System.Drawing.Size(284, 22);
            this.JobIDTextBox.TabIndex = 19;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(99, 222);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(45, 17);
            this.StateLabel.TabIndex = 20;
            this.StateLabel.Text = "State:";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(153, 218);
            this.StateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.ReadOnly = true;
            this.StateTextBox.Size = new System.Drawing.Size(284, 22);
            this.StateTextBox.TabIndex = 21;
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Location = new System.Drawing.Point(99, 256);
            this.OpenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(47, 17);
            this.OpenLabel.TabIndex = 22;
            this.OpenLabel.Text = "Open:";
            // 
            // OpenCheckBox
            // 
            this.OpenCheckBox.AutoSize = true;
            this.OpenCheckBox.Enabled = false;
            this.OpenCheckBox.Location = new System.Drawing.Point(155, 256);
            this.OpenCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenCheckBox.Name = "OpenCheckBox";
            this.OpenCheckBox.Size = new System.Drawing.Size(18, 17);
            this.OpenCheckBox.TabIndex = 23;
            this.OpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(124, 469);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete...";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 516);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenCheckBox);
            this.Controls.Add(this.OpenLabel);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.JobIDTextBox);
            this.Controls.Add(this.JobIDLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UrgencyComboBox);
            this.Controls.Add(this.AttachmentPictureBox);
            this.Controls.Add(this.JobDueDateTime);
            this.Controls.Add(this.JobRegisteredDateTime);
            this.Controls.Add(this.FaultDescriptionTextBox);
            this.Controls.Add(this.MachineNameTextBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.UrgencyLabel);
            this.Controls.Add(this.AttachmentLabel);
            this.Controls.Add(this.FaultDescriptionLabel);
            this.Controls.Add(this.JobDueLabel);
            this.Controls.Add(this.JobRegisteredLabel);
            this.Controls.Add(this.MachineNameLabel);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowJob_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label JobRegisteredLabel;
        private System.Windows.Forms.Label JobDueLabel;
        private System.Windows.Forms.Label FaultDescriptionLabel;
        private System.Windows.Forms.Label AttachmentLabel;
        private System.Windows.Forms.Label UrgencyLabel;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox MachineNameTextBox;
        private System.Windows.Forms.RichTextBox FaultDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker JobRegisteredDateTime;
        private System.Windows.Forms.DateTimePicker JobDueDateTime;
        private System.Windows.Forms.PictureBox AttachmentPictureBox;
        private System.Windows.Forms.ComboBox UrgencyComboBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label JobIDLabel;
        private System.Windows.Forms.TextBox JobIDTextBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.CheckBox OpenCheckBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}