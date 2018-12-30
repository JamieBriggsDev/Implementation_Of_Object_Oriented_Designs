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
    public partial class RegisterJob : Form, IRegisterJob
    {
        private Presenter m_presenter;

        private bool m_pictureGiven;
        // TODO: JAMIE: Add component to add attachments to the job listing to RegisterJob.
        public RegisterJob()
        {
            InitializeComponent();

            m_pictureGiven = false;
            RemoveImageButton.Enabled = false;
            RemoveImageButton.Visible = false;
        }

        public void Initialise()
        {
            GetAllClients();
            UpdateMachinesComboBox();
        }

        public void OpenForm(Home home)
        {
            Initialise();
            ShowDialog(home);

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Add new job
            // TODO: Make sure a new job is entered and added to the database.
            // Register job, close this form and focus parent
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void RegisterJob_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register job, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        private void ValidateRegisterButton()
        {
            //TODO: JAMIE: Make sure ValidateRegisterButton works
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

        private void ExistingMachineRadioButton_Click(object sender, EventArgs e)
        {
            // Disable new machine options
            NewMachineRadioButton.Checked = false;
            NewMachineNameLabel.Enabled = false;
            CreateNewMachine.Enabled = false;
            // Enable existing machine options
            ExistingMachineComboBox.Enabled = true;

            ValidateRegisterButton();
        }

        private void NewMachineRadioButton_Click(object sender, EventArgs e)
        {
            // Disable existing machine options
            ExistingMachineRadioButton.Checked = false;
            ExistingMachineComboBox.Enabled = false;
            // Enable new machine options
            NewMachineNameLabel.Enabled = true;
            CreateNewMachine.Enabled = true;

            ValidateRegisterButton();
        }

        private void CreateNewMachine_Click(object sender, EventArgs e)
        {
            m_presenter.OpenRegisterMachine();
            UpdateMachinesComboBox();
        }

        public void GetAllClients()
        {
            List<string> clients = new List<string>();
            clients = m_presenter.GetAllClients();
            ClientComboBox.DataSource = clients;
        }

        public void GetAllClientMachines(string _client)
        {
            throw new NotImplementedException();
        }

        public void CreateNewMachineForm()
        {
            throw new NotImplementedException();
        }


        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }

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
                    m_pictureGiven = true;
                }
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            m_pictureGiven = false;
            RemoveImageButton.Visible = false;
            RemoveImageButton.Enabled = false;

            JobPicture.Image = JobPicture.InitialImage;
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMachinesComboBox();

            ValidateRegisterButton();
        }

        public void UpdateMachinesComboBox()
        {
            int ClientID = m_presenter.GetClientID(ClientComboBox.Text);
            List<string> AllMachines = m_presenter.GetAllClientSpecificMachines(ClientID);
            
            ExistingMachineComboBox.DataSource = AllMachines;
        }
    }
}
