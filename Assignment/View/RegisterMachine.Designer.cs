namespace View.View
{
    partial class RegisterMachine
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
            this.ClientLabel = new System.Windows.Forms.Label();
            this.MachineComplexityLabel = new System.Windows.Forms.Label();
            this.MachineDescriptionLabel = new System.Windows.Forms.Label();
            this.ClientsComboBox = new System.Windows.Forms.ComboBox();
            this.ComplexityComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(80, 17);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(36, 13);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Client:";
            // 
            // MachineComplexityLabel
            // 
            this.MachineComplexityLabel.AutoSize = true;
            this.MachineComplexityLabel.Location = new System.Drawing.Point(12, 40);
            this.MachineComplexityLabel.Name = "MachineComplexityLabel";
            this.MachineComplexityLabel.Size = new System.Drawing.Size(104, 13);
            this.MachineComplexityLabel.TabIndex = 1;
            this.MachineComplexityLabel.Text = "Machine Complexity:";
            // 
            // MachineDescriptionLabel
            // 
            this.MachineDescriptionLabel.AutoSize = true;
            this.MachineDescriptionLabel.Location = new System.Drawing.Point(53, 66);
            this.MachineDescriptionLabel.Name = "MachineDescriptionLabel";
            this.MachineDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.MachineDescriptionLabel.TabIndex = 2;
            this.MachineDescriptionLabel.Text = "Description:";
            // 
            // ClientsComboBox
            // 
            this.ClientsComboBox.FormattingEnabled = true;
            this.ClientsComboBox.Location = new System.Drawing.Point(123, 13);
            this.ClientsComboBox.Name = "ClientsComboBox";
            this.ClientsComboBox.Size = new System.Drawing.Size(178, 21);
            this.ClientsComboBox.TabIndex = 3;
            // 
            // ComplexityComboBox
            // 
            this.ComplexityComboBox.FormattingEnabled = true;
            this.ComplexityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComplexityComboBox.Location = new System.Drawing.Point(123, 37);
            this.ComplexityComboBox.Name = "ComplexityComboBox";
            this.ComplexityComboBox.Size = new System.Drawing.Size(51, 21);
            this.ComplexityComboBox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 158);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(226, 266);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(145, 266);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 7;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Location = new System.Drawing.Point(34, 234);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(82, 13);
            this.MachineNameLabel.TabIndex = 8;
            this.MachineNameLabel.Text = "Machine Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MACHINENAME";
            // 
            // RegisterMachine
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(307, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MachineNameLabel);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ComplexityComboBox);
            this.Controls.Add(this.ClientsComboBox);
            this.Controls.Add(this.MachineDescriptionLabel);
            this.Controls.Add(this.MachineComplexityLabel);
            this.Controls.Add(this.ClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterMachine";
            this.Text = "Register Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterMachine_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label MachineComplexityLabel;
        private System.Windows.Forms.Label MachineDescriptionLabel;
        private System.Windows.Forms.ComboBox ClientsComboBox;
        private System.Windows.Forms.ComboBox ComplexityComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label label1;
    }
}