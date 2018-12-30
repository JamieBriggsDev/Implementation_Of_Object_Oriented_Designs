using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.View
{
    public partial class AssignStaffToJob : Form, IAssignStaffToJob
    {
        private Presenter m_presenter;

        public AssignStaffToJob()
        {
            InitializeComponent();
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
            // Close this form and focus parent
            // TODO: JAMIE: Be able to grab name from form on 'Assign' button clicked
            m_presenter.AssignStaffToJob("Egg", "Yolk");
            this.DialogResult = DialogResult.OK;
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
            if(!string.IsNullOrEmpty(StaffNameComboBox.Text) &&
                !string.IsNullOrEmpty(JobComboBox.Text))
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

        public void FillJobs(List<string> _jobs)
        {
            foreach (var job in _jobs)
            {
                JobComboBox.Items.Add(job);
            }
        }

        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
    }
}
