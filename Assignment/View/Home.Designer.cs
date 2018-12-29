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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaultDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachment = new System.Windows.Forms.DataGridViewImageColumn();
            this.Urgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.HomeToolStrip.Size = new System.Drawing.Size(935, 25);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.ClientName,
            this.MachineName,
            this.FaultDescription,
            this.Attachment,
            this.Urgency,
            this.Open});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 428);
            this.dataGridView1.TabIndex = 1;
            // 
            // JobID
            // 
            this.JobID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.JobID.HeaderText = "Job ID";
            this.JobID.MaxInputLength = 32;
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            this.JobID.Width = 63;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.MaxInputLength = 100;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 89;
            // 
            // MachineName
            // 
            this.MachineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MachineName.HeaderText = "Machine Name";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            this.MachineName.Width = 96;
            // 
            // FaultDescription
            // 
            this.FaultDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FaultDescription.HeaderText = "Fault Description";
            this.FaultDescription.Name = "FaultDescription";
            this.FaultDescription.ReadOnly = true;
            // 
            // Attachment
            // 
            this.Attachment.HeaderText = "Attachment";
            this.Attachment.Name = "Attachment";
            this.Attachment.ReadOnly = true;
            // 
            // Urgency
            // 
            this.Urgency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Urgency.HeaderText = "Urgency";
            this.Urgency.Name = "Urgency";
            this.Urgency.ReadOnly = true;
            this.Urgency.Width = 72;
            // 
            // Open
            // 
            this.Open.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            this.Open.Width = 39;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HomeToolStrip);
            this.Name = "Home";
            this.Text = "Home";
            this.HomeToolStrip.ResumeLayout(false);
            this.HomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaultDescription;
        private System.Windows.Forms.DataGridViewImageColumn Attachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgency;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Open;
    }
}