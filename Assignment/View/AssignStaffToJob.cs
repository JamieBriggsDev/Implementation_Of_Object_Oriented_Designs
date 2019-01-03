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
    public partial class AssignStaffToJob : Form, IAssignStaffToJob
    {
        private Presenter m_presenter;

        private int m_jobID;

        public AssignStaffToJob(int id)
        {
            InitializeComponent();
            m_jobID = id;
        }

        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel assign job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void AssignStaffToJobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel assign job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

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

        private void StaffNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAssignButton();
        }

        private void JobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAssignButton();
        }

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

        public void FillStaffNames(List<string> _names)
        {
            foreach (var name in _names)
            {
                StaffNameComboBox.Items.Add(name);
            }
        }

        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
    }
}
