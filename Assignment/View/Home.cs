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
        private DataTable m_jobsTable;

        public Home()
        {
            InitializeComponent();

            m_jobsTable = new DataTable();
            // Empty jobs table
            m_jobsTable.Clear();
            m_jobsTable.Columns.Add("JobsDataView", typeof(int));
            m_jobsTable.Columns.Add("Client Name", typeof(string));
            m_jobsTable.Columns.Add("Machine Name", typeof(string));
            m_jobsTable.Columns.Add("Fault", typeof(string));
            m_jobsTable.Columns.Add("Attachment", typeof(Image));
            m_jobsTable.Columns.Add("Urgency", typeof(int));
            m_jobsTable.Columns.Add("Open", typeof(string));
            m_jobsTable.Columns.Add("State", typeof(string));
            m_jobsTable.Columns.Add("Job Created", typeof(DateTime));
            m_jobsTable.Columns.Add("Date Due", typeof(DateTime));

            BindingSource source = new BindingSource();
            source.DataSource = m_jobsTable;
            JobsDataView.DataSource = source;
            JobsDataView.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            JobsDataView.Columns[4].FillWeight = 10.0f;

            
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

            //m_jobsTable.Clear();

            DataGridViewRow row = new DataGridViewRow();
            //object[] newRow = new object[10];

            m_jobsTable.Rows.Clear();

            foreach (var job in AllJobs)
            {
                DataRow newRow = m_jobsTable.NewRow();
                

                newRow[0] = job.JobID;
                newRow[1] = m_presenter.GetClientNameThroughMachineID(job.MachineID);
                newRow[2] = m_presenter.GetMachineNameThroughMachineID(job.MachineID, true);
                newRow[3] = job.FaultDescription;
                newRow[4] = ImageSerializer.Instance.DeserializeImage(job.Attachment);
                newRow[5] = job.Urgency;
                newRow[6] = job.Open == true ? "Open" : "Closed";
                newRow[7] = job.State;
                newRow[8] = job.JobCreated;
                // TODO - JAMIE: Get due date
                newRow[9] = job.JobCreated;

                m_jobsTable.Rows.Add(newRow);

                //m_jobsTable.Rows.InsertAt(newRow, 0);
            }

            //JobsDataView.Rows.Add()

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
