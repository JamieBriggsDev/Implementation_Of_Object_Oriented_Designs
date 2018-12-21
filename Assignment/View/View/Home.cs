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
    public partial class Home : Form
    {
        // TODO: JAMIE: Create table for current jobs
        // TODO: JAMIE: Create form to close a job

        private RegisterClientForm m_registerClient;
        private RegisterJobForm m_registerJob;
        private AssignStaffToJobForm m_assignJob;

        public Home()
        {
            InitializeComponent();
        }

        private void RegisterClientButton_Click(object sender, EventArgs e)
        {
            // Open the register client as a dialog
            m_registerClient = new RegisterClientForm();
            m_registerClient.ShowDialog(this);
        }

        private void RegisterJob_Click(object sender, EventArgs e)
        {
            // Open the register job form as a dialog
            m_registerJob = new RegisterJobForm();
            m_registerJob.ShowDialog(this);
        }

        private void AssignStaffButton_Click(object sender, EventArgs e)
        {
            // Open the assign job form as a dialog
            m_assignJob = new AssignStaffToJobForm();
            m_assignJob.ShowDialog(this);
        }

    }
}
