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
            this.AssignStaffButton = new System.Windows.Forms.ToolStripButton();
            this.JobPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeToolStrip
            // 
            this.HomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterClientButton,
            this.toolStripSeparator1,
            this.RegisterJob,
            this.toolStripSeparator2,
            this.AssignStaffButton});
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
            // AssignStaffButton
            // 
            this.AssignStaffButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AssignStaffButton.Image = ((System.Drawing.Image)(resources.GetObject("AssignStaffButton.Image")));
            this.AssignStaffButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AssignStaffButton.Name = "AssignStaffButton";
            this.AssignStaffButton.Size = new System.Drawing.Size(73, 22);
            this.AssignStaffButton.Text = "Assign Staff";
            this.AssignStaffButton.Click += new System.EventHandler(this.AssignStaffButton_Click);
            // 
            // JobPanel
            // 
            this.JobPanel.AutoScroll = true;
            this.JobPanel.AutoSize = true;
            this.JobPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobPanel.Location = new System.Drawing.Point(0, 25);
            this.JobPanel.Name = "JobPanel";
            this.JobPanel.Size = new System.Drawing.Size(1272, 431);
            this.JobPanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 456);
            this.Controls.Add(this.JobPanel);
            this.Controls.Add(this.HomeToolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
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
        private System.Windows.Forms.ToolStripButton AssignStaffButton;
        private System.Windows.Forms.FlowLayoutPanel JobPanel;
    }
}