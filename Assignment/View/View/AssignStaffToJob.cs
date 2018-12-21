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
    public partial class AssignStaffToJobForm : Form
    {
        public AssignStaffToJobForm()
        {
            InitializeComponent();
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
            this.DialogResult = DialogResult.OK;
        }
    }
}
