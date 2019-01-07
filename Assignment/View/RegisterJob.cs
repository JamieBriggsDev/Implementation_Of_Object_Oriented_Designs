// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
    /// Register Job Form
    /// </summary>
    public partial class RegisterJob : Form, IRegisterJob
    {
        private Presenter m_presenter;

        /// <summary>
        /// Initialises the form, sets some initial component states
        /// and registers the presenter.
        /// </summary>
        /// <param name="presenter">Presenter to register.</param>
        public RegisterJob()
        {
            InitializeComponent();

            RemoveImageButton.Enabled = false;
            RemoveImageButton.Visible = false;
            UrgencyComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Registers the presenter to the form.
        /// </summary>
        /// <param name="presenter"></param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }

        /// <summary>
        /// Initialise function which is called after the initial
        /// form has been set up.
        /// </summary>
        public void Initialise()
        {
            GetAllClients();
            UpdateMachinesComboBox();
        }

        /// <summary>
        /// Opens the form as a child to the Home form.
        /// </summary>
        /// <param name="home">Home parent form.</param>
        public void OpenForm(Home home)
        {
            Initialise();
            ShowDialog(home);

        }

        /// <summary>
        /// Validates the register button and enables it if it fits the right
        /// conditions.
        /// </summary>
        private void ValidateRegisterButton()
        {
            if (FaultDescriptionTextBox.TextLength > 0 &&
                FaultDescriptionTextBox.TextLength <= 155)
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        /// <summary>
        /// Using the presenter, gets all the clients and then puts them into
        /// a list of strings to put into the ClientComboBox
        /// </summary>
        public void GetAllClients()
        {
            List<string> clientNames = new List<string>();
            List<Client> clients = m_presenter.GetAllClients();

            foreach (var client in clients)
            {
                clientNames.Add(client.Name);
            }

            ClientComboBox.DataSource = clientNames;
        }

        /// <summary>
        /// Updates the MachineComboBox depending on the selected
        /// text in the ClientComboBox.
        /// </summary>
        private void UpdateMachinesComboBox()
        {
            int ClientID = m_presenter.GetClientID(ClientComboBox.Text);
            List<string> AllMachines = m_presenter.GetAllClientSpecificMachines(ClientID);

            ExistingMachineComboBox.DataSource = AllMachines;
           // ExistingMachineComboBox.SelectedIndex = 1;
        }

        #region FormEvents Various events for the form.
        /// <summary>
        /// Registers a new job when the register button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //int jobID = m_presenter.GetAllJobs().Count + 1;

            int machineID = m_presenter.GetAllMachines().Where(m => m.MachineName
                == ExistingMachineComboBox.Text).First().MachineID;

            byte[] attachment = ImageSerializer.Instance.SerializeImage(JobPicture.Image);
            int urgency = int.Parse(UrgencyComboBox.Text);
            // Add new job
            Job newJob = new Job()
            {
                MachineID = machineID,
                FaultDescription = FaultDescriptionTextBox.Text,
                Attachment = attachment,
                Urgency = urgency,
                Open = false,
                JobCreated = DatePicker.Value
            };  

            DialogResult = DialogResult.OK;

            if (m_presenter.RegisterJob(newJob))
                this.DialogResult = DialogResult.OK;
            else
            {
                DialogResult error = MessageBox.Show("Error registering job.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Abort;
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Opens the create new machine form through the presenter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewMachine_Click(object sender, EventArgs e)
        {
            m_presenter.OpenRegisterMachine(ClientComboBox.SelectedItem.ToString());
            UpdateMachinesComboBox();
        }

        /// <summary>
        /// Checks to see how long the text inside the fault description is
        /// and changes the colour of the component when the description is 
        /// too long.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FaultDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            string fault = FaultDescriptionTextBox.Text;

            // Make text red goes over the character limit
            if (fault.Length > 155)
            {
                FaultDescriptionTextBox.BackColor = Color.IndianRed;
            }
            // If not over character limit, ensure text is black
            else
            {
                FaultDescriptionTextBox.BackColor = Color.White;
            }

            ValidateRegisterButton();
        }

        /// <summary>
        /// Opens dialogue to open a picture and save it into the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowsePictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    JobPicture.Image = new Bitmap(dlg.FileName);
                    RemoveImageButton.Enabled = true;
                    RemoveImageButton.Visible = true;
                }
            }
        }
       
        /// <summary>
        /// Removes the loaded image in the form if it is wish to be removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            RemoveImageButton.Visible = false;
            RemoveImageButton.Enabled = false;

            JobPicture.Image = JobPicture.InitialImage;
        }

        /// <summary>
        /// Updates MachineComboBox with the new selected client in ClientComboBox,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMachinesComboBox();

            ValidateRegisterButton();
        }
        #endregion
    }
}
