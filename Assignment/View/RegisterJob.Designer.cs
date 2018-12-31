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
            this.ClientNameLabel.Location = new System.Drawing.Point(34, 9);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(103, 6);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(219, 21);
            this.ClientComboBox.TabIndex = 1;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Machine:";
            // 
            // ExistingMachineComboBox
            // 
            this.ExistingMachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingMachineComboBox.FormattingEnabled = true;
            this.ExistingMachineComboBox.Location = new System.Drawing.Point(103, 32);
            this.ExistingMachineComboBox.Name = "ExistingMachineComboBox";
            this.ExistingMachineComboBox.Size = new System.Drawing.Size(219, 21);
            this.ExistingMachineComboBox.TabIndex = 5;
            // 
            // FaultDescriptionLabel
            // 
            this.FaultDescriptionLabel.AutoSize = true;
            this.FaultDescriptionLabel.Location = new System.Drawing.Point(12, 119);
            this.FaultDescriptionLabel.Name = "FaultDescriptionLabel";
            this.FaultDescriptionLabel.Size = new System.Drawing.Size(89, 13);
            this.FaultDescriptionLabel.TabIndex = 7;
            this.FaultDescriptionLabel.Text = "Fault Description:";
            // 
            // FaultDescriptionTextBox
            // 
            this.FaultDescriptionTextBox.Location = new System.Drawing.Point(108, 119);
            this.FaultDescriptionTextBox.Name = "FaultDescriptionTextBox";
            this.FaultDescriptionTextBox.Size = new System.Drawing.Size(214, 134);
            this.FaultDescriptionTextBox.TabIndex = 8;
            this.FaultDescriptionTextBox.Text = "";
            this.FaultDescriptionTextBox.TextChanged += new System.EventHandler(this.FaultDescriptionTextBox_TextChanged);
            // 
            // UrgencyLabel
            // 
            this.UrgencyLabel.AutoSize = true;
            this.UrgencyLabel.Location = new System.Drawing.Point(51, 472);
            this.UrgencyLabel.Name = "UrgencyLabel";
            this.UrgencyLabel.Size = new System.Drawing.Size(50, 13);
            this.UrgencyLabel.TabIndex = 9;
            this.UrgencyLabel.Text = "Urgency:";
            // 
            // UrgencyComboBox
            // 
            this.UrgencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrgencyComboBox.FormattingEnabled = true;
            this.UrgencyComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.UrgencyComboBox.Location = new System.Drawing.Point(108, 469);
            this.UrgencyComboBox.Name = "UrgencyComboBox";
            this.UrgencyComboBox.Size = new System.Drawing.Size(54, 21);
            this.UrgencyComboBox.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(247, 497);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(166, 497);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CreateNewMachine
            // 
            this.CreateNewMachine.Location = new System.Drawing.Point(217, 59);
            this.CreateNewMachine.Name = "CreateNewMachine";
            this.CreateNewMachine.Size = new System.Drawing.Size(105, 23);
            this.CreateNewMachine.TabIndex = 13;
            this.CreateNewMachine.Text = "New Machine...";
            this.CreateNewMachine.UseVisualStyleBackColor = true;
            this.CreateNewMachine.Click += new System.EventHandler(this.CreateNewMachine_Click);
            // 
            // BrowsePictureButton
            // 
            this.BrowsePictureButton.Location = new System.Drawing.Point(25, 260);
            this.BrowsePictureButton.Name = "BrowsePictureButton";
            this.BrowsePictureButton.Size = new System.Drawing.Size(75, 23);
            this.BrowsePictureButton.TabIndex = 15;
            this.BrowsePictureButton.Text = "Browse...";
            this.BrowsePictureButton.UseVisualStyleBackColor = true;
            this.BrowsePictureButton.Click += new System.EventHandler(this.BrowsePictureButton_Click);
            // 
            // RemoveImageButton
            // 
            this.RemoveImageButton.Enabled = false;
            this.RemoveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveImageButton.Image")));
            this.RemoveImageButton.Location = new System.Drawing.Point(70, 289);
            this.RemoveImageButton.Name = "RemoveImageButton";
            this.RemoveImageButton.Size = new System.Drawing.Size(30, 30);
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
            this.JobPicture.Location = new System.Drawing.Point(108, 260);
            this.JobPicture.Name = "JobPicture";
            this.JobPicture.Size = new System.Drawing.Size(214, 203);
            this.JobPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JobPicture.TabIndex = 14;
            this.JobPicture.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(68, 91);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(103, 88);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(219, 20);
            this.DatePicker.TabIndex = 18;
            // 
            // RegisterJob
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 532);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterJob";
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