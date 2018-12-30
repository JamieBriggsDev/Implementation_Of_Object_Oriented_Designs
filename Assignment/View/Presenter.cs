using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.View;

namespace View
{
    public class Presenter
    {
        // Database controller
        private IDatabaseController m_databaseController;
        // Forms
        private IHome m_home;
        private IRegisterClient m_registerClient;
        private IRegisterJob m_registerJob;
        private IAssignStaffToJob m_assignStaff;
        private IRegisterMachine m_registerMachine;

        public Presenter()
        {
            // Setup home form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialise Database Controller
            m_databaseController = new DatabaseController();

            m_home = new Home();
            m_home.RegisterPresenter(this);    
            m_home.RunForm();
        }
        public bool ValidateDatabaseController()
        {
            if (m_databaseController == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// TODO - JAMIE: Using the database controller, grabs all jobs.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllJobs()
        {
            //try
            //{
            //    List<Job> AllJobs = m_databaseController.GetAllJobs();
            //    return AllJobs;
            //}
            //catch (Exception)
            //{

            //    return null;
            //}

            return null;
        }

        /// <summary>
        /// Using the database controller, grabs all the clients.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllClients()
        {
            List<string> clientNames = new List<string>();
            List<Client> clients = m_databaseController.GetAllClients();

            foreach (var client in clients)
            {
                clientNames.Add(client.Name);
            }

            return clientNames;
        }


        public bool OpenRegisterClient()
        {
            try
            {
                m_registerClient = new RegisterClient();
                m_registerClient.RegisterPresenter(this);
                m_registerClient.OpenChild(m_home as Home);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool OpenRegisterJob()
        {
            try
            {
                m_registerJob = new RegisterJob();
                m_registerJob.RegisterPresenter(this);
                m_registerJob.OpenChild(m_home as Home);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool OpenRegisterMachine()
        {
            try
            {
                m_registerMachine = new RegisterMachine();
                m_registerMachine.RegisterPresenter(this);
                m_registerMachine.OpenChild(m_registerJob as RegisterJob);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void OpenAssignStaff()
        {
            m_assignStaff = new AssignStaffToJob();
            m_assignStaff.RegisterPresenter(this);

            // TODO - JAMIE: Fill staff names and jobs
            List<string> Names = new List<string>();
            List<Staff> StaffMembers = m_databaseController.GetAllStaff();

            // TODO - JAMIE: Remove temp staff class
            Staff temp = new Staff()
            {
                //StaffID = 123,
                Forename = "Jamie",
                Surname = "Briggs"

            };
            StaffMembers.Add(temp);

            foreach (var Staff in StaffMembers)
            {
                string ID = Staff.StaffID.ToString();
                string Forname = Staff.Forename;
                string Surname = Staff.Surname;
                Names.Add($"{ID}: {Surname}, {Forname}");
            }

            m_assignStaff.FillStaffNames(Names);

            //List<string> JobNames = new List<string>();
            //List<Job> AllJobs = new List<Job>();
            //foreach (var job in AllJobs)
            //{

            //}

            //jobs.Add("Egg");
            //m_assignStaff.FillJobs(jobs);


            m_assignStaff.OpenChild(m_home as Home);
        }

        // Register Client Stuff
        public void RegisterClient(string name)
        {
            m_databaseController.AddClient(name);
        }


        public bool RegisterJob()
        {
            // TODO -ANY: Register job function needs doing
            bool success = m_databaseController.RegisterJob(new Job());

            return success;
        }

        // Assign staff to job stuff
        public bool AssignStaffToJob(string forename, string surname)
        {
            try
            {
                int StaffID = m_databaseController.GetStaffID(forename, surname);
                m_databaseController.AssignStaffToJob(StaffID, 1);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


    }
}
