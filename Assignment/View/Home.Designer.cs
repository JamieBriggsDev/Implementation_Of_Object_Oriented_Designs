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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.RegisterClientButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RegisterJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AssignStaffButton = new System.Windows.Forms.ToolStripButton();
            this.JobsDataView = new System.Windows.Forms.DataGridView();
            this.HomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataView)).BeginInit();
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
            this.HomeToolStrip.Size = new System.Drawing.Size(1539, 25);
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
            // JobsDataView
            // 
            this.JobsDataView.AllowUserToAddRows = false;
            this.JobsDataView.AllowUserToDeleteRows = false;
            this.JobsDataView.AllowUserToResizeColumns = false;
            this.JobsDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobsDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.JobsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.JobsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobsDataView.Location = new System.Drawing.Point(0, 25);
            this.JobsDataView.MultiSelect = false;
            this.JobsDataView.Name = "JobsDataView";
            this.JobsDataView.ReadOnly = true;
            this.JobsDataView.Size = new System.Drawing.Size(1539, 596);
            this.JobsDataView.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 621);
            this.Controls.Add(this.JobsDataView);
            this.Controls.Add(this.HomeToolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.HomeToolStrip.ResumeLayout(false);
            this.HomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataView)).EndInit();
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
        private System.Windows.Forms.DataGridView JobsDataView;
    }
}