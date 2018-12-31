namespace View
{
    partial class JobControlSmallTitles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JobTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.JobIDLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.FaultLabel = new System.Windows.Forms.Label();
            this.UrgencyLabel = new System.Windows.Forms.Label();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JobTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JobTableLayout
            // 
            this.JobTableLayout.AutoSize = true;
            this.JobTableLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.JobTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.JobTableLayout.ColumnCount = 9;
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.JobTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.JobTableLayout.Controls.Add(this.JobIDLabel, 0, 0);
            this.JobTableLayout.Controls.Add(this.ClientNameLabel, 1, 0);
            this.JobTableLayout.Controls.Add(this.MachineNameLabel, 2, 0);
            this.JobTableLayout.Controls.Add(this.FaultLabel, 3, 0);
            this.JobTableLayout.Controls.Add(this.UrgencyLabel, 4, 0);
            this.JobTableLayout.Controls.Add(this.OpenLabel, 5, 0);
            this.JobTableLayout.Controls.Add(this.StateLabel, 6, 0);
            this.JobTableLayout.Controls.Add(this.DueDateLabel, 7, 0);
            this.JobTableLayout.Location = new System.Drawing.Point(3, 3);
            this.JobTableLayout.Name = "JobTableLayout";
            this.JobTableLayout.RowCount = 1;
            this.JobTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.JobTableLayout.Size = new System.Drawing.Size(1153, 29);
            this.JobTableLayout.TabIndex = 0;
            // 
            // JobIDLabel
            // 
            this.JobIDLabel.AutoSize = true;
            this.JobIDLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.JobIDLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDLabel.Location = new System.Drawing.Point(17, 3);
            this.JobIDLabel.Name = "JobIDLabel";
            this.JobIDLabel.Size = new System.Drawing.Size(39, 23);
            this.JobIDLabel.TabIndex = 0;
            this.JobIDLabel.Text = "Job ID";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(102, 3);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(69, 23);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Client Name";
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MachineNameLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineNameLabel.Location = new System.Drawing.Point(204, 3);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(82, 23);
            this.MachineNameLabel.TabIndex = 2;
            this.MachineNameLabel.Text = "Machine Name";
            // 
            // FaultLabel
            // 
            this.FaultLabel.AutoSize = true;
            this.FaultLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FaultLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaultLabel.Location = new System.Drawing.Point(477, 3);
            this.FaultLabel.Name = "FaultLabel";
            this.FaultLabel.Size = new System.Drawing.Size(92, 23);
            this.FaultLabel.TabIndex = 3;
            this.FaultLabel.Text = "Fault Description";
            // 
            // UrgencyLabel
            // 
            this.UrgencyLabel.AutoSize = true;
            this.UrgencyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UrgencyLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgencyLabel.Location = new System.Drawing.Point(580, 3);
            this.UrgencyLabel.Name = "UrgencyLabel";
            this.UrgencyLabel.Size = new System.Drawing.Size(48, 23);
            this.UrgencyLabel.TabIndex = 4;
            this.UrgencyLabel.Text = "Urgency";
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLabel.Location = new System.Drawing.Point(709, 3);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(34, 23);
            this.OpenLabel.TabIndex = 5;
            this.OpenLabel.Text = "Open";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StateLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(825, 3);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(33, 23);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "State";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(942, 3);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(31, 23);
            this.DueDateLabel.TabIndex = 7;
            this.DueDateLabel.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.JobTableLayout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 53);
            this.panel1.TabIndex = 1;
            // 
            // JobControlSmallTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "JobControlSmallTitles";
            this.Size = new System.Drawing.Size(1226, 53);
            this.JobTableLayout.ResumeLayout(false);
            this.JobTableLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel JobTableLayout;
        private System.Windows.Forms.Label JobIDLabel;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label FaultLabel;
        private System.Windows.Forms.Label UrgencyLabel;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
