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
        // TODO: JAMIE: Add component to add attachments to the job listing to RegisterJob.
        public RegisterJob()
        {
            InitializeComponent();

            RemoveImageButton.Enabled = false;
            RemoveImageButton.Visible = false;
            UrgencyComboBox.SelectedIndex = 0;
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
            //int jobID = m_presenter.GetAllJobs().Count + 1;
            int machineID = m_presenter.GetAllMachineNames().Count;
            byte[] attachment = ImageSerializer.Instance.SerializeImage(JobPicture.Image);
            int urgency = int.Parse(UrgencyComboBox.Text);
            // Add new job
            Job newJob = new Job()
            {
                //JobID = jobID,
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

        private void CreateNewMachine_Click(object sender, EventArgs e)
        {
            m_presenter.OpenRegisterMachine();
            UpdateMachinesComboBox();
        }

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
                }
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
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
