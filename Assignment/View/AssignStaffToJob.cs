using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.View
{
    /// <summary>
    /// Assign staff to job form.
    /// </summary>
    public partial class AssignStaffToJob : Form, IAssignStaffToJob
    {
        private Presenter m_presenter;

        private int m_jobID;

        /// <summary>
        /// Registers the presenter to the form.
        /// </summary>
        /// <param name="presenter"></param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
        /// <summary>
        /// Sets up register job form and records job ID to be recorded.
        /// </summary>
        /// <param name="id"></param>
        public AssignStaffToJob(int id)
        {
            InitializeComponent();
            m_jobID = id;
        }

        /// <summary>
        /// Opens the form as a child to the Home form.
        /// </summary>
        /// <param name="home">Home parent form.</param>
        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }

        /// <summary>
        /// Validates the assign button and enables it when a selection
        /// is made in StaffNameComboBox.
        /// </summary>
        private void ValidateAssignButton()
        {
            if(!string.IsNullOrEmpty(StaffNameComboBox.Text))
            {
                AssignButton.Enabled = true;
            }
            else
            {
                AssignButton.Enabled = false;
            }
        }
        /// <summary>
        /// Fills the staff names in the combo box.
        /// </summary>
        /// <param name="_names"></param>
        public void FillStaffNames(List<string> names)
        {
            StaffNameComboBox.DataSource = names;
            // TODO foreach (var name in _names)
            //{
            //    StaffNameComboBox.Items.Add(name);
            //}
        }



        #region FormEvents Various events for the form.
        /// <summary>
        /// Closes the form when the cancel button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel assign job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Closes the form when the cancel button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignStaffToJobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel assign job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Assigns a staff member to a job when the assign button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignButton_Click(object sender, EventArgs e)
        {
            char[] split = { ' ', ':' };
            int staffID = int.Parse(StaffNameComboBox.Text.Split(split)[0]);

            DialogResult = DialogResult.OK;

            if (m_presenter.AssignStaffToJob(staffID, m_jobID))
                this.DialogResult = DialogResult.OK;
            else
            {
                DialogResult error = MessageBox.Show("Error assigning staff.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Abort;
            }
        }
        /// <summary>
        /// Validates the assign button when the StaffNameComboBox index is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAssignButton();
        }
        /// <summary>
        /// Validates the assign button when the JobComboBox index is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAssignButton();
        }
        #endregion
    }
}
