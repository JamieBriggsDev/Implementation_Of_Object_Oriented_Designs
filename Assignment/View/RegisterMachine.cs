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

            // Fill clients combo box
            FillClients();
            // Empty generated name field
            GeneratedNameLabel.Text = "";
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

        private void MachineDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if(MachineDescriptionTextBox.Text.Length > 255)
            {
                MachineDescriptionTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                MachineDescriptionTextBox.BackColor = Color.White;
            }
        }

        private void ClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO - JAMIE: Get number of machines client has and use that number in string
            int TotalMachines = 0;

            // Label is first three letters of client name plus total machines client has plus 1
            // e.g. "MICRO12"
            GeneratedNameLabel.Text = ClientsComboBox.Text.Substring(0, 5).ToUpper() + (TotalMachines + 1).ToString();
        }

        public void FillClients()
        {
            // TODO - JAMIE: Use presenter to grab all machines
            // temp code
            List<string> temp = m_presenter.GetAllClients();

            foreach (var name in temp)
            {
                ClientsComboBox.Items.Add(name);
            }
        }
    }
}
