namespace View
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.HomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.RegisterClientButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RegisterJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterLabel = new System.Windows.Forms.ToolStripLabel();
            this.FilterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.LogoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LoggedInAsLabel = new System.Windows.Forms.ToolStripLabel();
            this.JobPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HomeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeToolStrip
            // 
            this.HomeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterClientButton,
            this.toolStripSeparator1,
            this.RegisterJob,
            this.toolStripSeparator2,
            this.FilterLabel,
            this.FilterComboBox,
            this.LogoutButton,
            this.toolStripSeparator3,
            this.LoggedInAsLabel});
            this.HomeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeToolStrip.Name = "HomeToolStrip";
            this.HomeToolStrip.Size = new System.Drawing.Size(1272, 25);
            this.HomeToolStrip.TabIndex = 0;
            this.HomeToolStrip.Text = "toolStrip1";
            // 
            // RegisterClientButton
            // 
            this.RegisterClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RegisterClientButton.Image = ((System.Drawing.Image)(resources.GetObject("RegisterClientButton.Image")));
            this.RegisterClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegisterClientButton.Name = "RegisterClientButton";
            this.RegisterClientButton.Size = new System.Drawing.Size(87, 22);
            this.RegisterClientButton.Text = "Register Client";
            this.RegisterClientButton.Click += new System.EventHandler(this.RegisterClientButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RegisterJob
            // 
            this.RegisterJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RegisterJob.Image = ((System.Drawing.Image)(resources.GetObject("RegisterJob.Image")));
            this.RegisterJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegisterJob.Name = "RegisterJob";
            this.RegisterJob.Size = new System.Drawing.Size(74, 22);
            this.RegisterJob.Text = "Register Job";
            this.RegisterJob.Click += new System.EventHandler(this.RegisterJob_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FilterLabel
            // 
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(39, 22);
            this.FilterLabel.Text = "Filter: ";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.Items.AddRange(new object[] {
            "All Jobs",
            "Open Jobs",
            "Unassigned",
            "Closed Jobs"});
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 25);
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(49, 22);
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(80, 22);
            this.LoggedInAsLabel.Text = "Logged in as: ";
            // 
            // JobPanel
            // 
            this.JobPanel.AutoScroll = true;
            this.JobPanel.ColumnCount = 1;
            this.JobPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.JobPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobPanel.Location = new System.Drawing.Point(0, 25);
            this.JobPanel.Name = "JobPanel";
            this.JobPanel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.JobPanel.RowCount = 3;
            this.JobPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.JobPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.JobPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.JobPanel.Size = new System.Drawing.Size(1272, 431);
            this.JobPanel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 456);
            this.Controls.Add(this.JobPanel);
            this.Controls.Add(this.HomeToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Enter += new System.EventHandler(this.Home_Enter);
            this.HomeToolStrip.ResumeLayout(false);
            this.HomeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip HomeToolStrip;
        private System.Windows.Forms.ToolStripButton RegisterClientButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RegisterJob;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel JobPanel;
        private System.Windows.Forms.ToolStripLabel FilterLabel;
        private System.Windows.Forms.ToolStripComboBox FilterComboBox;
        private System.Windows.Forms.ToolStripButton LogoutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LoggedInAsLabel;
        //private View.JobControlSmallTitles jobControlSmallTitles1;
    }
}