namespace View
{
    partial class JobControlSmall
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
            this.ViewMoreButton = new System.Windows.Forms.Button();
            this.JobIDLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.FaultLabel = new System.Windows.Forms.Label();
            this.UrgencyLabel = new System.Windows.Forms.Label();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.JobTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // JobTableLayout
            // 
            this.JobTableLayout.AutoSize = true;
            this.JobTableLayout.BackColor = System.Drawing.SystemColors.Control;
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
            this.JobTableLayout.Controls.Add(this.ViewMoreButton, 8, 0);
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
            this.JobTableLayout.Size = new System.Drawing.Size(1123, 46);
            this.JobTableLayout.TabIndex = 0;
            // 
            // ViewMoreButton
            // 
            this.ViewMoreButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewMoreButton.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMoreButton.Location = new System.Drawing.Point(1035, 6);
            this.ViewMoreButton.Name = "ViewMoreButton";
            this.ViewMoreButton.Size = new System.Drawing.Size(82, 34);
            this.ViewMoreButton.TabIndex = 9;
            this.ViewMoreButton.Text = "More...";
            this.ViewMoreButton.UseVisualStyleBackColor = true;
            // 
            // JobIDLabel
            // 
            this.JobIDLabel.AutoSize = true;
            this.JobIDLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.JobIDLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobIDLabel.Location = new System.Drawing.Point(20, 3);
            this.JobIDLabel.Name = "JobIDLabel";
            this.JobIDLabel.Size = new System.Drawing.Size(34, 40);
            this.JobIDLabel.TabIndex = 0;
            this.JobIDLabel.Text = "JobID";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(98, 3);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(68, 40);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Client Name";
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MachineNameLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineNameLabel.Location = new System.Drawing.Point(197, 3);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(81, 40);
            this.MachineNameLabel.TabIndex = 2;
            this.MachineNameLabel.Text = "Machine Name";
            // 
            // FaultLabel
            // 
            this.FaultLabel.AutoSize = true;
            this.FaultLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FaultLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaultLabel.Location = new System.Drawing.Point(464, 3);
            this.FaultLabel.Name = "FaultLabel";
            this.FaultLabel.Size = new System.Drawing.Size(90, 40);
            this.FaultLabel.TabIndex = 3;
            this.FaultLabel.Text = "Fault Description";
            // 
            // UrgencyLabel
            // 
            this.UrgencyLabel.AutoSize = true;
            this.UrgencyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UrgencyLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgencyLabel.Location = new System.Drawing.Point(564, 3);
            this.UrgencyLabel.Name = "UrgencyLabel";
            this.UrgencyLabel.Size = new System.Drawing.Size(47, 40);
            this.UrgencyLabel.TabIndex = 4;
            this.UrgencyLabel.Text = "Urgency";
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLabel.Location = new System.Drawing.Point(690, 3);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(33, 40);
            this.OpenLabel.TabIndex = 5;
            this.OpenLabel.Text = "Open";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StateLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(802, 3);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(33, 40);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "State";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(916, 3);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(31, 40);
            this.DueDateLabel.TabIndex = 7;
            this.DueDateLabel.Text = "Date";
            // 
            // JobControlSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JobTableLayout);
            this.Name = "JobControlSmall";
            this.Size = new System.Drawing.Size(1128, 52);
            this.JobTableLayout.ResumeLayout(false);
            this.JobTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button ViewMoreButton;
    }
}
