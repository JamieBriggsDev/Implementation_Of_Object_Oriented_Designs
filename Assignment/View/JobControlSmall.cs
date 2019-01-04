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
    /// <summary>
    /// Control used in the Home form to display seperate jobs.
    /// </summary>
    public partial class JobControlSmall : UserControl
    {
        Job m_job;
        Presenter m_presenter;

        /// <summary>
        /// Sets up control, registers the presenter and also adds a job.
        /// </summary>
        /// <param name="presenter">Presenter to register.</param>
        /// <param name="job">Job to set up</param>
        public JobControlSmall(Presenter presenter, Job job)
        {
            InitializeComponent();
            m_presenter = presenter;
            AddJob(job);
        }

        /// <summary>
        /// Adds a job to the control and fills in the text,
        /// </summary>
        /// <param name="job">Job to add to control.</param>
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

        #region ControlEvents Various events for the controls.

        /// <summary>
        /// Opens the show job form for the specific job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewMoreButton_Click(object sender, EventArgs e)
        {
            m_presenter.OpenShowJob(m_job);
        }

        /// <summary>
        /// Opens the assign staff form for the specific job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignStaff_Click(object sender, EventArgs e)
        {
            // Check if user has permisions
            if(m_presenter.IsTechnicalManager())
                m_presenter.OpenAssignStaff(m_job.JobID);
            else
            {
                DialogResult error = MessageBox.Show("You don't have permission to do this!",
                    "Permission not granted!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        #endregion

    }
}
