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
using Model;

namespace View
{
    public partial class ShowJob : Form, IShowJob
    {
        Presenter m_presenter;
        Job m_job;
        public ShowJob()
        {
            InitializeComponent();

            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            CancelButton.Visible = false;
            CancelButton.Enabled = false;
        }

        public void LoadJob(Job job)
        {
            m_job = new Job();
            m_job = job;

            LoadJob();
        }

        public void LoadJob()
        {
            JobIDTextBox.Text = m_job.JobID.ToString();
            ClientNameTextBox.Text = m_presenter.GetClientNameThroughMachineID(m_job.MachineID);
            MachineNameTextBox.Text = m_presenter.GetMachineNameThroughMachineID(m_job.MachineID);
            FaultDescriptionTextBox.Text = m_job.FaultDescription;
            UrgencyComboBox.SelectedIndex = m_job.Urgency - 1;
            AttachmentPictureBox.Image = ImageSerializer.Instance.DeserializeImage(m_job.Attachment);
            OpenCheckBox.Checked = m_job.Open == true ? true : false;
            StateTextBox.Text = m_job.State;
            JobRegisteredDateTime.Value = m_job.JobCreated;
            JobDueDateTime.Value = m_job.CompletionDate;
        }

        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }

        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            JobIDTextBox.ReadOnly = false;
            JobRegisteredDateTime.Enabled = true;
            MachineNameTextBox.ReadOnly = false;
            FaultDescriptionTextBox.ReadOnly = false;
            StateTextBox.ReadOnly = false;
            UrgencyComboBox.Enabled = true;
            OpenCheckBox.Enabled = true;

            SaveButton.Visible = true;
            SaveButton.Enabled = true;
            CancelButton.Visible = true;
            CancelButton.Enabled = true;
            BackButton.Enabled = false;
            EditButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoadJob();

            JobIDTextBox.ReadOnly = true;
            JobRegisteredDateTime.Enabled = true;
            MachineNameTextBox.ReadOnly = true;
            FaultDescriptionTextBox.ReadOnly = true;
            StateTextBox.ReadOnly = true;
            UrgencyComboBox.Enabled = false;
            OpenCheckBox.Enabled = false;

            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            CancelButton.Visible = false;
            CancelButton.Enabled = false;
            BackButton.Enabled = true;
            EditButton.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ShowJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_job.JobID = int.Parse(JobIDTextBox.Text);
                m_job.JobCreated = JobRegisteredDateTime.Value;
                m_job.MachineID = m_presenter.GetAllMachines().Find(m => m.MachineName == MachineNameTextBox.Text).MachineID;
                m_job.FaultDescription = FaultDescriptionTextBox.Text;
                m_job.State = StateTextBox.Text;
                m_job.Urgency = int.Parse(UrgencyComboBox.Text);
                m_job.Open = OpenCheckBox.Checked;

                SaveButton.Visible = false;
                SaveButton.Enabled = false;
                CancelButton.Visible = false;
                CancelButton.Enabled = false;
                BackButton.Enabled = true;
                EditButton.Enabled = true;

                m_presenter.EditJob(m_job);

                
            }
            catch
            {
                MessageBox.Show("Please check all information!");
            }

        }
    }
}
