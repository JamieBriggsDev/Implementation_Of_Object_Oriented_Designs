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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.termsConditionsLabel = new System.Windows.Forms.Label();
            this.agreeTermsConditionsCheckBox = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(12, 9);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "Client Name:";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(85, 6);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // termsConditionsLabel
            // 
            this.termsConditionsLabel.AutoSize = true;
            this.termsConditionsLabel.Location = new System.Drawing.Point(36, 29);
            this.termsConditionsLabel.Name = "termsConditionsLabel";
            this.termsConditionsLabel.Size = new System.Drawing.Size(173, 13);
            this.termsConditionsLabel.TabIndex = 2;
            this.termsConditionsLabel.Text = "Agree to the Terms and Conditions:";
            // 
            // agreeTermsConditionsCheckBox
            // 
            this.agreeTermsConditionsCheckBox.AutoSize = true;
            this.agreeTermsConditionsCheckBox.Location = new System.Drawing.Point(15, 29);
            this.agreeTermsConditionsCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.agreeTermsConditionsCheckBox.Name = "agreeTermsConditionsCheckBox";
            this.agreeTermsConditionsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.agreeTermsConditionsCheckBox.TabIndex = 3;
            this.agreeTermsConditionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(164, 45);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // registerCancelButton
            // 
            this.registerCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.registerCancelButton.Location = new System.Drawing.Point(245, 45);
            this.registerCancelButton.Name = "registerCancelButton";
            this.registerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.registerCancelButton.TabIndex = 5;
            this.registerCancelButton.Text = "Cancel";
            this.registerCancelButton.UseVisualStyleBackColor = true;
            // 
            // RegisterClient
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.registerCancelButton;
            this.ClientSize = new System.Drawing.Size(330, 78);
            this.Controls.Add(this.registerCancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.agreeTermsConditionsCheckBox);
            this.Controls.Add(this.termsConditionsLabel);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterClient";
            this.Text = "Register Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label termsConditionsLabel;
        private System.Windows.Forms.CheckBox agreeTermsConditionsCheckBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button registerCancelButton;
    }
}