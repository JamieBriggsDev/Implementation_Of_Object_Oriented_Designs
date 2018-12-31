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

        public Home()
        {
            InitializeComponent();
       
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

            GetAllJobs();
        }

        private void AssignStaffButton_Click(object sender, EventArgs e)
        {
            // Open the assign job form as a dialog
            m_presenter.OpenAssignStaff();
        }

        public void GetAllJobs()
        {
            //TODO List<Job> AllJobs = m_presenter.GetAllJobs();
            List<Job> AllJobs = new List<Job>();
            AllJobs = m_presenter.GetAllJobs();

            JobPanel.Controls.Clear();

            JobPanel.Controls.Add(new JobControlSmallTitles());

            foreach(var job in AllJobs)
            {
                var newJob = new JobControlSmall(m_presenter, job);
                //newJob.Dock = DockStyle.Fill;
                JobPanel.Controls.Add(newJob);
            }
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
            GetAllJobs();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Initialise();
        }
    }
}
