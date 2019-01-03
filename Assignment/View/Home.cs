using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.View;

namespace View
{
    public partial class Home : Form, IHome
    {
        // TODO: JAMIE: Create form to close a job (DO LAST ONCE DATABASE IS WORKING)
        private Presenter m_presenter;
        private int m_filterIndex;

        public Home()
        {
            InitializeComponent();
            m_filterIndex = 0;
            FilterComboBox.SelectedIndex = 0;
        }

        public Home(Presenter presenter)
        {
            m_presenter = presenter;
            InitializeComponent();
            m_filterIndex = 0;
            FilterComboBox.SelectedIndex = 0;
        }

        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            // Open the register client as a dialog
            m_presenter.OpenRegisterClient();
        }

        private void RegisterJob_Click(object sender, EventArgs e)
        {
            // Open the register job form as a dialog
            m_presenter.OpenRegisterJob();

            UpdateJobs();
        }

        private void AssignStaffButton_Click(object sender, EventArgs e)
        {
            // Open the assign job form as a dialog
            m_presenter.OpenAssignStaff();
        }

        public void UpdateJobs()
        {
            // Clear all controls
            JobPanel.Controls.Clear();
            JobPanel.Visible = false;
            JobPanel.SuspendLayout();


            List<Job> AllJobs = new List<Job>();
            // Filter items by open/ closed/ all]
            if (FilterComboBox.SelectedIndex == 0)
            {
                AllJobs = m_presenter.GetAllJobs().Where(j => j.Open == true).ToList();
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                AllJobs = m_presenter.GetAllJobs().Where(j => j.Open == false).ToList();
            }
            else
            {
                AllJobs = m_presenter.GetAllJobs();
            }

            // Sort jobs by due date
            AllJobs = AllJobs.OrderBy(j => j.CompletionDate).ToList();

            Queue<JobControlSmall> jobControls = new Queue<JobControlSmall>();

            var titles = new JobControlSmallTitles();
            titles.Dock = DockStyle.Top;
            JobPanel.Controls.Add(titles, 0, 0);
            JobPanel.RowCount = AllJobs.Count + 1;
            JobPanel.HorizontalScroll.Enabled = false;
            JobPanel.HorizontalScroll.Visible = false;




            foreach (var job in AllJobs)
            {
                var newJob = new JobControlSmall(m_presenter, job);
                newJob.Dock = DockStyle.Top;
                jobControls.Enqueue(newJob);
                //newJob.Dock = DockStyle.Top;
            }

            for(int i = 1; i <= AllJobs.Count; i++)
            {
                JobPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
                //JobPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52.0f));
                JobPanel.Controls.Add(jobControls.Dequeue(), 0, i);
            }

            JobPanel.ResumeLayout();
            JobPanel.Visible = true;

        }


        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }

        public void OpenForm()
        {
            Application.Run(this);
        }

        public void Initialise()
        {
            UpdateJobs();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Initialise();
        }

        private void Home_Enter(object sender, EventArgs e)
        {
            UpdateJobs();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateJobs();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJobs();
        }
    }
}
