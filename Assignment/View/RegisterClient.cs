// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

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
    public partial class RegisterClient : Form, IRegisterClient
    {
        private Presenter m_presenter;
        /// <summary>
        /// Sets up Register Client form and registers presenter.
        /// </summary>
        public RegisterClient()
        {
            InitializeComponent();
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
        /// Opens the form as a child form to the Home form.
        /// </summary>
        /// <param name="home"></param>
        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }

        /// <summary>
        /// Changes the status of the Register button depending on if text was entered into the client 
        /// name text box and if the terms and conditions check box has been ticked.
        /// </summary>
        private void ValidateRegisterButton()
        {
            // Check both client name text box and the terms and conditions check box.
            if (!string.IsNullOrWhiteSpace(ClientNameTextBox.Text))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        #region FormEvents Various events for the form.
        /// <summary>
        /// AgreeTermsConditionsCheckBox checked changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agreeTermsConditionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Validate Register Button
            ValidateRegisterButton();
        }

        /// <summary>
        /// ClientNameTextBox text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate register button
            ValidateRegisterButton();
        }

        /// <summary>
        /// RegisterCancelButton clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterCancelButton_Click(object sender, EventArgs e)
        {
            // Cancel register client, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// RegisterButton clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {

            DialogResult delete = MessageBox.Show("Does the client agree to the terms and conditions?", "Terms and Conditions",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (delete == DialogResult.Yes)
            {
                // Add new client
                if (m_presenter.RegisterClient(ClientNameTextBox.Text.ToString()))
                    this.DialogResult = DialogResult.OK;
                else
                {
                    DialogResult error = MessageBox.Show("Error registering client.", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.DialogResult = DialogResult.OK;
                }
            }

        } 

        /// <summary>
        /// RegisterClient form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel register client, close this form and focus parent
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
