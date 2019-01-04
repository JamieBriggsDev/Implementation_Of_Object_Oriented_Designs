namespace View.View
{
    partial class RegisterJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterJob));
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ExistingMachineComboBox = new System.Windows.Forms.ComboBox();
            this.FaultDescriptionLabel = new System.Windows.Forms.Label();
            this.FaultDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.UrgencyLabel = new System.Windows.Forms.Label();
            this.UrgencyComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CreateNewMachine = new System.Windows.Forms.Button();
            this.BrowsePictureButton = new System.Windows.Forms.Button();
            this.RemoveImageButton = new System.Windows.Forms.PictureBox();
            this.JobPicture = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(45, 11);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(88, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(137, 7);
            this.ClientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(291, 24);
            this.ClientComboBox.TabIndex = 1;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(67, 43);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Machine:";
            // 
            // ExistingMachineComboBox
            // 
            this.ExistingMachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingMachineComboBox.FormattingEnabled = true;
            this.ExistingMachineComboBox.Location = new System.Drawing.Point(137, 39);
            this.ExistingMachineComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExistingMachineComboBox.Name = "ExistingMachineComboBox";
            this.ExistingMachineComboBox.Size = new System.Drawing.Size(291, 24);
            this.ExistingMachineComboBox.TabIndex = 5;
            // 
            // FaultDescriptionLabel
            // 
            this.FaultDescriptionLabel.AutoSize = true;
            this.FaultDescriptionLabel.Location = new System.Drawing.Point(16, 146);
            this.FaultDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FaultDescriptionLabel.Name = "FaultDescriptionLabel";
            this.FaultDescriptionLabel.Size = new System.Drawing.Size(118, 17);
            this.FaultDescriptionLabel.TabIndex = 7;
            this.FaultDescriptionLabel.Text = "Fault Description:";
            // 
            // FaultDescriptionTextBox
            // 
            this.FaultDescriptionTextBox.Location = new System.Drawing.Point(144, 146);
            this.FaultDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FaultDescriptionTextBox.Name = "FaultDescriptionTextBox";
            this.FaultDescriptionTextBox.Size = new System.Drawing.Size(284, 164);
            this.FaultDescriptionTextBox.TabIndex = 8;
            this.FaultDescriptionTextBox.Text = "";
            this.FaultDescriptionTextBox.TextChanged += new System.EventHandler(this.FaultDescriptionTextBox_TextChanged);
            // 
            // UrgencyLabel
            // 
            this.UrgencyLabel.AutoSize = true;
            this.UrgencyLabel.Location = new System.Drawing.Point(68, 581);
            this.UrgencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UrgencyLabel.Name = "UrgencyLabel";
            this.UrgencyLabel.Size = new System.Drawing.Size(65, 17);
            this.UrgencyLabel.TabIndex = 9;
            this.UrgencyLabel.Text = "Urgency:";
            // 
            // UrgencyComboBox
            // 
            this.UrgencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrgencyComboBox.FormattingEnabled = true;
            this.UrgencyComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.UrgencyComboBox.Location = new System.Drawing.Point(144, 577);
            this.UrgencyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UrgencyComboBox.Name = "UrgencyComboBox";
            this.UrgencyComboBox.Size = new System.Drawing.Size(71, 24);
            this.UrgencyComboBox.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(329, 612);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(221, 612);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(100, 28);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CreateNewMachine
            // 
            this.CreateNewMachine.Location = new System.Drawing.Point(289, 73);
            this.CreateNewMachine.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewMachine.Name = "CreateNewMachine";
            this.CreateNewMachine.Size = new System.Drawing.Size(140, 28);
            this.CreateNewMachine.TabIndex = 13;
            this.CreateNewMachine.Text = "New Machine...";
            this.CreateNewMachine.UseVisualStyleBackColor = true;
            this.CreateNewMachine.Click += new System.EventHandler(this.CreateNewMachine_Click);
            // 
            // BrowsePictureButton
            // 
            this.BrowsePictureButton.Location = new System.Drawing.Point(33, 320);
            this.BrowsePictureButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowsePictureButton.Name = "BrowsePictureButton";
            this.BrowsePictureButton.Size = new System.Drawing.Size(100, 28);
            this.BrowsePictureButton.TabIndex = 15;
            this.BrowsePictureButton.Text = "Browse...";
            this.BrowsePictureButton.UseVisualStyleBackColor = true;
            this.BrowsePictureButton.Click += new System.EventHandler(this.BrowsePictureButton_Click);
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.Enabled = false;
            this.RemoveImageButton.Image = global::View.Properties.Resources.cancel;
            this.RemoveImageButton.Location = new System.Drawing.Point(93, 356);
            this.RemoveImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(40, 37);
            this.RemoveImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveImageButton.TabIndex = 16;
            this.RemoveImageButton.TabStop = false;
            this.RemoveImageButton.Click += new System.EventHandler(this.RemoveImageButton_Click);
            // 
            // JobPicture
            // 
            this.JobPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JobPicture.Image = global::View.Properties.Resources.NoJobPicture;
            this.JobPicture.InitialImage = global::View.Properties.Resources.NoJobPicture;
            this.JobPicture.Location = new System.Drawing.Point(144, 320);
            this.JobPicture.Margin = new System.Windows.Forms.Padding(4);
            this.JobPicture.Name = "JobPicture";
            this.JobPicture.Size = new System.Drawing.Size(285, 249);
            this.JobPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JobPicture.TabIndex = 14;
            this.JobPicture.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(91, 112);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 17);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(137, 108);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(291, 22);
            this.DatePicker.TabIndex = 18;
            // 
            // RegisterJob
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 655);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.RemoveImageButton);
            this.Controls.Add(this.BrowsePictureButton);
            this.Controls.Add(this.JobPicture);
            this.Controls.Add(this.CreateNewMachine);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UrgencyComboBox);
            this.Controls.Add(this.UrgencyLabel);
            this.Controls.Add(this.FaultDescriptionTextBox);
            this.Controls.Add(this.FaultDescriptionLabel);
            this.Controls.Add(this.ExistingMachineComboBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterJob_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox ExistingMachineComboBox;
        private System.Windows.Forms.Label FaultDescriptionLabel;
        private System.Windows.Forms.RichTextBox FaultDescriptionTextBox;
        private System.Windows.Forms.Label UrgencyLabel;
        private System.Windows.Forms.ComboBox UrgencyComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button CreateNewMachine;
        private System.Windows.Forms.PictureBox JobPicture;
        private System.Windows.Forms.Button BrowsePictureButton;
        private System.Windows.Forms.PictureBox RemoveImageButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}