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
    public partial class Login : Form, ILogin
    {
        Presenter m_presenter;

        public Login(Presenter presenter)
        {
            InitializeComponent();
            RegisterPresenter(presenter);
            FillStaffComboBox();
        }

        public void RegisterPresenter(Presenter presenter)
        {
            m_presenter = presenter;
        }


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

        public void OpenForm(Home home)
        {
            ShowDialog(home);
        }
    }
}
