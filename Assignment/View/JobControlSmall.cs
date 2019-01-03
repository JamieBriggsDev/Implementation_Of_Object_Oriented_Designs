using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class JobControlSmall : UserControl
    {
        Job m_job;
        Presenter m_presenter;
        public JobControlSmall()
        {
            InitializeComponent();
        }

        public JobControlSmall(Presenter presenter, Job job)
        {
            InitializeComponent();
            m_presenter = presenter;
            AddJob(job);
        }

        private void AddJob(Job job)
        {
            m_job = job;

            JobIDLabel.Text = m_job.JobID.ToString();
            ClientNameLabel.Text = m_presenter.GetClientNameThroughMachineID(m_job.MachineID);
            MachineNameLabel.Text = m_presenter.GetMachineNameThroughMachineID(m_job.MachineID);
            FaultLabel.Text = m_job.FaultDescription;
            UrgencyLabel.Text = m_job.Urgency.ToString();
            OpenLabel.Text = m_job.Open == true ? "Open" : "Closed";
            StateLabel.Text = m_job.State;
            DueDateLabel.Text = m_job.CompletionDate.ToShortDateString();

            // Update color of control depending on date
            DateTime due = m_job.CompletionDate.Date;
            DateTime today = DateTime.Today.Date;

            if(m_job.StaffID != 0)
            {
                Label StaffNameLabel = new Label();
                StaffNameLabel.Dock = DockStyle.Fill;
                StaffNameLabel.Text = m_presenter.GetStaffInitials(m_job.StaffID);
                StaffNameLabel.AutoSize = true;
                StaffNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                JobTableLayout.Controls.Add(StaffNameLabel, 3, 0);

                if (today.CompareTo(due) > 0)
                {
                    BackColor = Color.IndianRed;
                    ViewMoreButton.BackColor = Color.LightGoldenrodYellow;
                }
                else if((due - today).TotalDays < 5)
                {
                    BackColor = Color.PaleGoldenrod;
                    ViewMoreButton.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    BackColor = Color.LightGreen;
                    ViewMoreButton.BackColor = Color.LightGoldenrodYellow;
                }
            }
            else
            {
                Button button = new Button();
                button.Dock = DockStyle.Fill;
                button.Text = "Assign";
                button.Click += new EventHandler(AssignStaff_Click);
                JobTableLayout.Controls.Add(button, 3, 0);
            }

            
        }

        private void ViewMoreButton_Click(object sender, EventArgs e)
        {
            m_presenter.OpenShowJob(m_job);
        }

        private void AssignStaff_Click(object sender, EventArgs e)
        {
            m_presenter.OpenAssignStaff(m_job.JobID);
        }


    }
}
