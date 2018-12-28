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
    public partial class RegisterMachine : Form, IRegisterMachine
    {
        private Presenter m_presenter;

        public RegisterMachine()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register machine, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // Accept register machine, close this form and focus parent
            this.DialogResult = DialogResult.OK;
        }

        private void RegisterMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register machine, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        public void OpenChild(RegisterJob job)
        {
            ShowDialog(job);
        }

        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
    }
}
