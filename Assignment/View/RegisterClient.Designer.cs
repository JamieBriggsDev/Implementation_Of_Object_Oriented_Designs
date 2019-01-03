namespace View.View
{
    partial class RegisterClient
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
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.TermsConditionsLabel = new System.Windows.Forms.Label();
            this.AgreeTermsConditionsCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(85, 6);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.ClientNameTextBox.TabIndex = 1;
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientNameTextBox_TextChanged);
            // 
            // TermsConditionsLabel
            // 
            this.TermsConditionsLabel.AutoSize = true;
            this.TermsConditionsLabel.Location = new System.Drawing.Point(36, 29);
            this.TermsConditionsLabel.Name = "TermsConditionsLabel";
            this.TermsConditionsLabel.Size = new System.Drawing.Size(173, 13);
            this.TermsConditionsLabel.TabIndex = 2;
            this.TermsConditionsLabel.Text = "Agree to the Terms and Conditions:";
            // 
            // AgreeTermsConditionsCheckBox
            // 
            this.AgreeTermsConditionsCheckBox.AutoSize = true;
            this.AgreeTermsConditionsCheckBox.Location = new System.Drawing.Point(15, 29);
            this.AgreeTermsConditionsCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.AgreeTermsConditionsCheckBox.Name = "AgreeTermsConditionsCheckBox";
            this.AgreeTermsConditionsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AgreeTermsConditionsCheckBox.TabIndex = 3;
            this.AgreeTermsConditionsCheckBox.UseVisualStyleBackColor = true;
            this.AgreeTermsConditionsCheckBox.CheckedChanged += new System.EventHandler(this.agreeTermsConditionsCheckBox_CheckedChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(164, 45);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterCancelButton
            // 
            this.RegisterCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RegisterCancelButton.Location = new System.Drawing.Point(245, 45);
            this.RegisterCancelButton.Name = "RegisterCancelButton";
            this.RegisterCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterCancelButton.TabIndex = 5;
            this.RegisterCancelButton.Text = "Cancel";
            this.RegisterCancelButton.UseVisualStyleBackColor = true;
            this.RegisterCancelButton.Click += new System.EventHandler(this.RegisterCancelButton_Click);
            // 
            // RegisterClient
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RegisterCancelButton;
            this.ClientSize = new System.Drawing.Size(330, 78);
            this.Controls.Add(this.RegisterCancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.AgreeTermsConditionsCheckBox);
            this.Controls.Add(this.TermsConditionsLabel);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label TermsConditionsLabel;
        private System.Windows.Forms.CheckBox AgreeTermsConditionsCheckBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button RegisterCancelButton;
    }
}