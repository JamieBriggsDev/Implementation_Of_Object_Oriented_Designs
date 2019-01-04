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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterClient));
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(16, 11);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(88, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client Name:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(113, 7);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(305, 22);
            this.ClientNameTextBox.TabIndex = 1;
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientNameTextBox_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(216, 39);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(100, 28);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterCancelButton
            // 
            this.RegisterCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RegisterCancelButton.Location = new System.Drawing.Point(324, 39);
            this.RegisterCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterCancelButton.Name = "RegisterCancelButton";
            this.RegisterCancelButton.Size = new System.Drawing.Size(100, 28);
            this.RegisterCancelButton.TabIndex = 5;
            this.RegisterCancelButton.Text = "Cancel";
            this.RegisterCancelButton.UseVisualStyleBackColor = true;
            this.RegisterCancelButton.Click += new System.EventHandler(this.RegisterCancelButton_Click);
            // 
            // RegisterClient
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RegisterCancelButton;
            this.ClientSize = new System.Drawing.Size(440, 79);
            this.Controls.Add(this.RegisterCancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button RegisterCancelButton;
    }
}