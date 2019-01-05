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
    /// <summary>
    /// Show job form.
    /// </summary>
    public partial class ShowJob : Form, IShowJob
    {
        Presenter m_presenter;
        Job m_job;

        /// <summary>
        /// Sets up the show job form.
        /// </summary>
        public ShowJob()
        {
            InitializeComponent();

            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            CancelButton.Visible = false;
            CancelButton.Enabled = false;
            FaultDescriptionTextBox.BackColor = FaultDescriptionTextBox.BackColor = Color.LightGray;
        }
        /// <summary>
        /// Registers the presenter to this form.
        /// </summary>
        /// <param name="presenter"></param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
        /// <summary>
        /// Loads a job into the form.
        /// </summary>
        /// <param name="job"></param>
        public void LoadJob(Job job)
        {
            m_job = new Job();
            m_job = job;

            LoadJob();

            Text = string.Format("Job ID: {0} Overview", m_job.JobID);
        }
        /// <summary>
        /// Loads a job into the form.
        /// </summary>
        private void LoadJob()
        {
            JobIDTextBox.Text = m_job.JobID.ToString();
            ClientNameTextBox.Text = m_presenter.GetClientNameThroughMachineID(m_job.MachineID);
            MachineNameTextBox.Text = m_presenter.GetMachineNameThroughMachineID(m_job.MachineID);
            FaultDescriptionTextBox.Text = m_job.FaultDescription;
            UrgencyComboBox.SelectedIndex = m_job.Urgency;
            AttachmentPictureBox.Image = ImageSerializer.Instance.DeserializeImage(m_job.Attachment);
            OpenCheckBox.Checked = m_job.Open == true ? true : false;
            StateTextBox.Text = m_job.State;
            JobRegisteredDateTime.Value = m_job.JobCreated;
            JobDueDateTime.Value = m_job.CompletionDate;
        }
        /// <summary>
        /// Opens the form as a child to the Home form.
        /// </summary>
        /// <param name="home"></param>
        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }



        #region FormEvents Various events for the form.
        /// <summary>
        /// Allows the controls in the form to be editable and
        /// shows the save and cancel buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            JobRegisteredDateTime.Enabled = true;
            FaultDescriptionTextBox.ReadOnly = false;
            StateTextBox.ReadOnly = false;
            UrgencyComboBox.Enabled = true;
            FaultDescriptionTextBox.BackColor = Color.White;

            SaveButton.Visible = true;
            SaveButton.Enabled = true;
            CancelButton.Visible = true;
            CancelButton.Enabled = true;
            BackButton.Enabled = false;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
        /// <summary>
        /// Makes all the controls in the form uneditable and doesn't save 
        /// any changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            JobRegisteredDateTime.Enabled = true;
            FaultDescriptionTextBox.ReadOnly = true;
            StateTextBox.ReadOnly = true;
            UrgencyComboBox.Enabled = false;
            FaultDescriptionTextBox.BackColor = FaultDescriptionTextBox.BackColor = Color.LightGray;
            LoadJob();

            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            CancelButton.Visible = false;
            CancelButton.Enabled = false;
            BackButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Saves the job in the form through the database controller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {    
                m_job.JobCreated = JobRegisteredDateTime.Value;
                m_job.MachineID = m_presenter.GetAllMachines().Find(m => m.MachineName == MachineNameTextBox.Text).MachineID;
                m_job.FaultDescription = FaultDescriptionTextBox.Text;
                m_job.State = StateTextBox.Text;
                m_job.Urgency = int.Parse(UrgencyComboBox.Text);
                m_job.Open = OpenCheckBox.Checked;

                JobRegisteredDateTime.Enabled = true;
                FaultDescriptionTextBox.ReadOnly = true;
                StateTextBox.ReadOnly = true;
                UrgencyComboBox.Enabled = false;
                FaultDescriptionTextBox.BackColor = FaultDescriptionTextBox.BackColor = Color.LightGray;

                SaveButton.Visible = false;
                SaveButton.Enabled = false;
                CancelButton.Visible = false;
                CancelButton.Enabled = false;
                BackButton.Enabled = true;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;


                if (!m_presenter.EditJob(m_job))
                {
                    return;
                }
                
            }
            catch
            {
                DialogResult error = MessageBox.Show("Error editing job.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Abort;
            }

        }
        /// <summary>
        /// Tells the database controller to delete the job within the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Do you sure you would like to delete this job?", "Important!", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if(delete == DialogResult.Yes)
            {
                if (m_presenter.DeleteJob(m_job.JobID))
                    this.DialogResult = DialogResult.OK;
                else
                {
                    DialogResult error = MessageBox.Show("Error deleting job.", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.DialogResult = DialogResult.Abort;
                }
            }

        }

        #endregion
    }
}
