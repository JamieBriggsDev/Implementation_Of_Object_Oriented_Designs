using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.View;
using Model;

namespace View
{
    /// <summary>
    /// Form shown to let the staff login.
    /// </summary>
    public partial class Login : Form, ILogin
    {
        Presenter m_presenter;

        /// <summary>
        /// Sets up control, registers the presenter then fills
        /// the StaffComboBox.
        /// </summary>
        /// <param name="presenter">Presenter to register.</param>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Registers the presenter to the form. Also fills staff combo box 
        /// as staff combo box needs to presenter before it is filled.
        /// </summary>
        /// <param name="presenter"></param>
        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
            FillStaffComboBox();
        }
        /// <summary>
        /// Fills in the StaffComboBox
        /// </summary>
        public void FillStaffComboBox()
        {
            List<string> AllStaff = new List<string>();
            foreach (var staff in m_presenter.GetAllStaff())
            {
                string Forename = staff.Forename;
                string Surname = staff.Surname;
                AllStaff.Add(Forename + " " + Surname);
            }

            StaffComboBox.DataSource = AllStaff;
        }
        /// <summary>
        /// Opens forms as a child to the Home form.
        /// </summary>
        /// <param name="home">Home form.</param>
        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }

        #region FormEvents Various events for the form.
        /// <summary>
        /// Saves the staff ID to the presenter so the rest of the program
        /// can alter depending on the member of staff logged in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string forename = StaffComboBox.Text.Split(new char[] { ' ' })[0];
                string surname = StaffComboBox.Text.Split(new char[] { ' ' })[1];
                Staff staffToLogin = m_presenter.GetAllStaff().Find(s => s.Forename == forename &&
                s.Surname == surname);

                int ID = staffToLogin.StaffID;
                if (!m_presenter.SetUser(ID))
                {
                    return;
                }

                DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {
                DialogResult error = MessageBox.Show("Error Logging In.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        #endregion


    }
}
