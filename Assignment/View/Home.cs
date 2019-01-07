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
    /// <summary>
    /// Home form.
    /// </summary>
    public partial class Home : Form, IHome
    {
        private Presenter m_presenter;
        /// <summary>
        /// Sets up Home form and sets FilterComboBox index to 0.
        /// </summary>
        public Home(Presenter presenter)
        {
            RegisterPresenter(presenter);
            InitializeComponent();
            FilterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Registers the presenter to the form.
        /// </summary>
        /// <param name="presenter"></param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
        /// <summary>
        /// Updates all the jobs shown in the form.
        /// </summary>
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
                AllJobs = m_presenter.GetAllJobs();
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                AllJobs = m_presenter.GetAllJobs().Where(j => j.Open == true).ToList();
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                AllJobs = m_presenter.GetAllJobs().Where(j => j.StaffID == 0).ToList();
            }
            else if (FilterComboBox.SelectedIndex == 3)
            {
                AllJobs = m_presenter.GetAllJobs().Where(j => j.Open == false).ToList();
            }

            // Sort jobs by due date
            AllJobs = AllJobs.OrderBy(j => j.CompletionDate).ToList();

            Queue<JobControlSmall> jobControls = new Queue<JobControlSmall>();

            var titles = new JobControlSmallTitles();
            titles.Dock = DockStyle.Top;
            JobPanel.Controls.Add(titles, 0, 0);
            JobPanel.RowCount = AllJobs.Count + 1;
            JobPanel.HorizontalScroll.Maximum = 0;
            JobPanel.HorizontalScroll.Enabled = false;
            JobPanel.HorizontalScroll.Visible = false;

            foreach (var job in AllJobs)
            {
                var newJob = new JobControlSmall(m_presenter, job);
                newJob.Dock = DockStyle.Top;
                jobControls.Enqueue(newJob);
                //newJob.Dock = DockStyle.Top;
            }

            for (int i = 1; i <= AllJobs.Count; i++)
            {
                JobPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
                //JobPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52.0f));
                JobPanel.Controls.Add(jobControls.Dequeue(), 0, i);
            }

            JobPanel.ResumeLayout();
            JobPanel.Visible = true;

        }

        /// <summary>
        /// Opens the form.
        /// </summary>
        public void OpenForm()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Sets up any controls initialised after the presenter 
        /// has been registered.
        /// </summary>
        public void Initialise()
        {
            m_presenter.OpenLogin();
            if (!m_presenter.IsValidUser())
                this.Close();
            else
            {
                LoggedInAsLabel.Text = "Logged in as: " + m_presenter.GetUserLoggedIn();
                UpdateJobs();
            }
                
        }



        #region FormEvents Various events for the form.
        /// <summary>
        /// Opens the register client form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            // Open the register client as a dialog
            m_presenter.OpenRegisterClient();
        }

        /// <summary>
        /// Opens the register job form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterJob_Click(object sender, EventArgs e)
        {
            // Open the register job form as a dialog
            m_presenter.OpenRegisterJob();

            UpdateJobs();
        }

        /// <summary>
        /// Initialises the form when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Load(object sender, EventArgs e)
        {
            Initialise();
        }
        /// <summary>
        /// Updates all the jobs on the form when the form is entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Enter(object sender, EventArgs e)
        {
            UpdateJobs();
        }
        /// <summary>
        /// Updates the jobs when the FilterComboBox index has been changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJobs();
        }
        /// <summary>
        /// Logs the current user out and allows the user to login to a different
        /// account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_presenter.OpenLogin();
            this.Show();
            LoggedInAsLabel.Text = "Logged in as: " + m_presenter.GetUserLoggedIn();
        }
        #endregion
    }
}
