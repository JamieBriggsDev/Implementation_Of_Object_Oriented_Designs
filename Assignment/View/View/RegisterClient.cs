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
    public partial class RegisterClientForm : Form
    {
        /// <summary>
        /// RegisterClient constructor
        /// </summary>
        public RegisterClientForm()
        {
            InitializeComponent();
        }

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
            // Add new client
            //TODO: JAMIE: Make sure a new client is entered and added to the ClientModel.

            // Close this form and focus parent
            this.DialogResult = DialogResult.OK;
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

        /// <summary>
        /// Changes the status of the Register button depending on if text was entered into the client 
        /// name text box and if the terms and conditions check box has been ticked.
        /// </summary>
        private void ValidateRegisterButton()
        {
            // Check both client name text box and the terms and conditions check box.
            if(AgreeTermsConditionsCheckBox.Checked && !string.IsNullOrWhiteSpace(ClientNameTextBox.Text))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }



    }
}
