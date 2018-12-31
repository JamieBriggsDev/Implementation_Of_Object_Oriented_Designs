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

namespace View.View
{
    /// <summary>
    /// WinForm to register a new client.
    /// </summary>
    public partial class RegisterMachine : Form, IRegisterMachine
    {
        /// <summary>
        /// Member variable to hold the presenter.
        /// </summary>
        private Presenter m_presenter;

        /// <summary>
        /// Closes the form when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register machine, close this form and focus parent
            DialogResult = DialogResult.Cancel;
        }
        
        /// <summary>
        /// Closes the form when the accept button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // Get clientID
            int clientID = m_presenter.GetClientID(ClientsComboBox.Text);
            // Create new machine
            Machine newMachine = new Machine()
            {
                ClientID = clientID,
                SizeAndComplexity = ComplexityComboBox.SelectedIndex,
                MachineDescription = MachineDescriptionTextBox.Text,
                MachineName = GeneratedNameLabel.Text
            };


            m_presenter.RegisterMachine(newMachine);
            // Accept register machine, close this form and focus parent
            DialogResult = DialogResult.OK;
        }
        
        /// <summary>
        /// Returns dialogue.cancel when form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register machine, close this form and focus parent
            DialogResult = DialogResult.Cancel;
        }
        
        /// <summary>
        /// Validates the 'Accept' button when box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComplexityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAcceptButton();
        }
        
        /// <summary>
        /// Validates the 'Accept' button when box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MachineDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAcceptButton();

            if (MachineDescriptionTextBox.Text.Length > 255)
            {
                MachineDescriptionTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                MachineDescriptionTextBox.BackColor = Color.White;
            }
        }
        
        /// <summary>
        /// Validates the 'Accept' button when box is changed. Also changes
        /// the generated name if needs be.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAcceptButton();


            // Get clientID
            int clientID = m_presenter.GetClientID(ClientsComboBox.Text);
            // Total machines client owns
            int TotalMachines = m_presenter.GetAllClientSpecificMachines(clientID).Count;

            string name = ClientsComboBox.Text.Replace(" ", string.Empty).ToUpper();
            // Label is first three letters of client name plus total machines client has plus 1
            // e.g. "MICRO12"
            if (name.Length > 5)
                GeneratedNameLabel.Text = name.Substring(0, 5) + (TotalMachines + 1).ToString();
            else
                GeneratedNameLabel.Text = name + (TotalMachines + 1).ToString();
        }

        /// <summary>
        /// Initialises the form. Contents of which are to be called after the presenter
        /// is first set within the class.
        /// </summary>
        public void Initialise()
        {
            // Fill clients combo box
            FillClients();
        }

        /// <summary>
        /// Tells the presenter to register a new machine with the selected options.
        /// </summary>
        public RegisterMachine()
        {
            InitializeComponent();

            // Empty generated name field
            GeneratedNameLabel.Text = "";
        }
        
        /// <summary>
        /// Opens the form as a dialogue.
        /// </summary>
        /// <param name="job">Register Job form.</param>
        public void OpenForm(RegisterJob job)
        {
            Initialise();
            ShowDialog(job);

        }
        
        /// <summary>
        /// Validates the Accept button to make sure it should be enabled or not.
        /// </summary>
        public void ValidateAcceptButton()
        {
            if(!string.IsNullOrWhiteSpace(ClientsComboBox.Text) &&
                !string.IsNullOrWhiteSpace(ComplexityComboBox.Text) &&
                !string.IsNullOrWhiteSpace(MachineDescriptionTextBox.Text))
            {
                AcceptButton.Enabled = true;
            }
            else
            {
                AcceptButton.Enabled = false;
            }
        }
        
        /// <summary>
        /// Registers the presenter with this form.
        /// </summary>
        /// <param name="presenter">Presenter to be registered with this form.</param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }
        
        /// <summary>
        /// Fills the clients combobox on initialise.
        /// </summary>
        public void FillClients()
        {
            List<string> clientNames = new List<string>();
            List<Client> clients = m_presenter.GetAllClients();

            foreach (var client in clients)
            {
                clientNames.Add(client.Name);
            }
            ClientsComboBox.DataSource = clients;
        }


    }
}
