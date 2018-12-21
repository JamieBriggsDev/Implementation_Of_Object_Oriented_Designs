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
        // TODO: JAMIE: Create table for current jobs
        // TODO: JAMIE: Create form to close a job
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
        }

        private void AssignStaffButton_Click(object sender, EventArgs e)
        {
            // Open the assign job form as a dialog
            m_presenter.OpenAssignStaff();
        }

        public void GetAllJobs()
        {
            throw new NotImplementedException();
        }


        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }

        public void RunForm()
        {
            Application.Run(this);
        }
    }
}
