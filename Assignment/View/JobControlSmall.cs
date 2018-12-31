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
        }
    }
}
