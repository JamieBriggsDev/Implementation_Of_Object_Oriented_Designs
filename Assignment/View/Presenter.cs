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
    /// <summary>
    /// Presenter class which sets up the program, forms and the database
    /// controller. Also alows the forms and database controller to talk
    /// to each other indirectly.
    /// </summary>
    public class Presenter : IPresenter
    {
        // Database controller
        private IDatabaseController m_databaseController;
        // Forms
        private IHome m_home;
        private IRegisterClient m_registerClient;
        private IRegisterJob m_registerJob;
        private IAssignStaffToJob m_assignStaff;
        private IRegisterMachine m_registerMachine;
        private IShowJob m_showJob;
        private ILogin m_login;
        // Logged in user ID
        private int? m_loggedInUser;
        
        /// <summary>
        /// Contructor enables visual styles, creates the Database Controller,
        /// creates the Home form and opens it. Only opens Home form if
        /// database controller is valid.
        /// </summary>
        public Presenter()
        {
            // Setup home form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialise Database Controller
            m_databaseController = new DatabaseController();

            if(ValidateDatabaseController())
            {
                OpenHome();
            }
        }

        public bool OpenHome()
        {
            try
            {     
                m_home = new Home(this);
                m_home.OpenForm();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool OpenLogin()
        {
            try
            {
                m_login = new Login(this);
                m_login.OpenForm(m_home as Home);
                
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        #region OpenFormMethods These methods allow the opening of other forms.
        /// <summary>
        /// Opens the register client form.
        /// </summary>
        /// <returns>Returns true or false depending on 
        /// if the form opened successfully.</returns>
        public bool OpenRegisterClient()
        {
            try
            {
                // Creates new form, registers this presenter
                //  and then opens the form as a dialogue to home.
                m_registerClient = new RegisterClient();
                m_registerClient.RegisterPresenter(this);
                m_registerClient.OpenForm(m_home as Home);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Opens the register job form.
        /// </summary>
        /// <returns>Returns true or false depending on 
        /// if the form opened successfully.</returns>
        public bool OpenRegisterJob()
        {
            try
            {
                // Creates new form, registers this presenter
                //  and then opens the form as a dialogue to home.
                m_registerJob = new RegisterJob();
                m_registerJob.RegisterPresenter(this);
                m_registerJob.OpenForm(m_home as Home);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Opens the register machine form.
        /// </summary>
        /// <returns>Returns true or false depending on 
        /// if the form opened successfully.</returns>
        public bool OpenRegisterMachine()
        {
            try
            {
                // Creates new form, registers this presenter
                //  and then opens the form as a dialogue to home.
                m_registerMachine = new RegisterMachine();
                m_registerMachine.RegisterPresenter(this);
                m_registerMachine.OpenForm(m_registerJob as RegisterJob);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Opens the assign staff form.
        /// </summary>
        /// <param name="jobID"></param>
        /// <returns></returns>
        public bool OpenAssignStaff(int jobID)
        {
            try
            {
                // Creates new form, registers this presenter
                //  and then opens the form as a dialogue to home.
                //  Also grabs all the staff names. Once finished,
                //  the home form updates its jobs.
                m_assignStaff = new AssignStaffToJob(jobID);
                m_assignStaff.RegisterPresenter(this);

                List<string> Names = new List<string>();
                List<Staff> StaffMembers = m_databaseController.GetAllStaff();

                foreach (var Staff in StaffMembers)
                {
                    string ID = Staff.StaffID.ToString();
                    string Forname = Staff.Forename;
                    string Surname = Staff.Surname;
                    Names.Add($"{ID}: {Surname}, {Forname}");
                }

                m_assignStaff.FillStaffNames(Names);
                m_assignStaff.OpenForm(m_home as Home);
                m_home.UpdateJobs();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        /// <summary>
        /// Opens the show job form.
        /// </summary>
        /// <returns>Returns true or false depending on 
        /// if the form opened successfully.</returns>
        public bool OpenShowJob(Job job)
        {
            try
            {
                // Creates new form, registers this presenter
                //  and then opens the form as a dialogue to home. Once
                //  closed, the home form updates all its jobs.
                m_showJob = new ShowJob();
                m_showJob.RegisterPresenter(this);
                m_showJob.LoadJob(job);
                m_showJob.OpenForm(m_home as Home);
                m_home.UpdateJobs();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        #endregion



        #region DatabaseControllerGetters These methods get information from the database using the database controller.
        /// <summary>
        /// Grabs all the jobs using the database controller.
        /// </summary>
        /// <returns>Returns a list of jobs if successful. If not then
        /// null is returned.</returns>
        public List<Job> GetAllJobs()
        {
            try
            {
                List<Job> AllJobs = m_databaseController.GetAllJobs();
                return AllJobs;
            }
            catch (Exception)
            {

                return null;
            }
        }
        /// <summary>
        /// Grabs all the clients using the database controller.
        /// </summary>
        /// <returns>Returns a list of clients if successful. If not then
        /// null is returned.</returns>
        public List<Client> GetAllClients()
        {
            try
            {
                List<string> clientNames = new List<string>();
                List<Client> clients = m_databaseController.GetAllClients();

                foreach (var client in clients)
                {
                    clientNames.Add(client.Name);
                }

                return clients;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Grabs all the machines using the database controller.
        /// </summary>
        /// <returns>Returns a list of machines if successful. If not then
        /// null is returned.</returns>
        public List<Machine> GetAllMachines()
        {
            try
            {
                List<Machine> Machines = m_databaseController.GetAllMachines();
                return Machines;
            }
            catch (Exception)
            {

                return null;

            }
        }
        /// <summary>
        /// Grabs all stff using the database controller.
        /// </summary>
        /// <returns>Returns a list of staff if successful. If not then
        /// null is returned.</returns>
        public List<Staff> GetAllStaff()
        {
            try
            {
                List<Staff> Staff = m_databaseController.GetAllStaff();
                return Staff;
            }
            catch (Exception)
            {

                return null;

            }
        }
        /// <summary>
        ///  Grabs all the machines specific to a lusing the database controller.
        /// </summary>
        /// <param name="clientID">Client ID to use to find specific machines.</param>
        /// <returns>Returns a list of strings for names of client specific machines.</returns>
        public List<string> GetAllClientSpecificMachines(int clientID)
        {
            List<string> MachineNames = new List<string>();
            foreach (var machine in m_databaseController.GetClientSpecificMachines(clientID))
            {
                MachineNames.Add(machine.MachineName);
            }
            return MachineNames;
        }
        /// <summary>
        /// Grabs a list of all machines names.
        /// </summary>
        /// <returns>Returns a list of strings for all machine names.</returns>
        public List<string> GetAllMachineNames()
        {
            List<string> MachineNames = new List<string>();
            List<Machine> Machines = m_databaseController.GetAllMachines();

            MachineNames = Machines.Select(m => m.MachineName).ToList();

            return MachineNames;
        }
        /// <summary>
        /// Gets the client ID given a name.
        /// </summary>
        /// <param name="name">Name of client.</param>
        /// <returns>Returns the client ID in Int format. Returns
        /// 0 if client wasn't found.</returns>
        public int GetClientID(string name)
        {
            try
            {

                int ID = m_databaseController.GetAllClients().Find(c => c.Name == name).ClientID;
                return ID;

            }
            catch (Exception)
            {
                return 0;
            }

        }
        /// <summary>
        /// Gets client name using machine ID.
        /// </summary>
        /// <param name="id">Machine ID to find client name.</param>
        /// <returns>Returns a string with the client name.</returns>
        public string GetClientNameThroughMachineID(int id)
        {
            try
            {
                int clientID =
                    m_databaseController.GetAllMachines().Find(m => m.MachineID == id).ClientID;
                string clientName =
                    m_databaseController.GetAllClients().Find(c => c.ClientID == clientID).Name;

                return clientName;
            }
            catch (Exception)
            {
                return "ERROR GETTING CLIENT NAME";
            }

        }
        /// <summary>
        /// Gets machine name using machine ID.
        /// </summary>
        /// <param name="id">Machine ID to find machine name.</param>
        /// <returns>Returns a string with the machine name.</returns>
        public string GetMachineNameThroughMachineID(int id)
        {
            try
            {
                List<Machine> machines = m_databaseController.GetAllMachines();
                string name = machines.Find(m => m.MachineID == id).MachineName;
                return name;
            }
            catch (Exception)
            {

                return "ERROR GETTING MACHINE NAME";
            }

        }
        /// <summary>
        /// Gets the staff initials using staff ID.
        /// </summary>
        /// <param name="id">ID of the staff to get initials for.</param>
        /// <returns>Returns a string containing the staff initials. Returns
        /// "Unassigned" if id == 0.</returns>
        public string GetStaffInitials(int id)
        {
            if (id == 0)
                return "Unassigned";
            else
            {
                Staff staff = m_databaseController.GetAllStaff().Find(s => s.StaffID == id);
                return string.Format("{0}. {1}", staff.Forename.Substring(0, 1), staff.Surname);
            }
        }
        /// <summary>
        /// Gets the tecnhical manager.
        /// </summary>
        /// <returns>Returns a staff object who is the
        /// technical manager.</returns>
        public Staff GetTechnicaManager()
        {

            Staff manager = m_databaseController.GetAllStaff()
                .Find(s => s.Role == "Technical Manager");

            return manager;
        }
        #endregion



        #region DatabaseControllerEditors These methods edits the information within the database.
        /// <summary>
        /// Registers a client with the database controller.
        /// </summary>
        /// <param name="name">Name of client to register.</param>
        /// <returns>Returns true or false depending success of method.</returns>
        public bool RegisterClient(string name) => m_databaseController.AddClient(name) ? true : false;
        /// <summary>
        /// Registers a job with the database controller.
        /// </summary>
        /// <param name="job">Job to register to the database.</param>
        /// <returns>Returns true or false depending on success of method.</returns>
        public bool RegisterJob(Job job) => m_databaseController.RegisterJob(job) ? true : false;
        /// <summary>
        /// Registers a machine with the database controller.
        /// </summary>
        /// <param name="machine">Machine to register to the database.</param>
        /// <returns>Returns true or false depending on success of method.</returns>
        public bool RegisterMachine(Machine machine) => m_databaseController.AddMachine(machine) ? true : false;
        /// <summary>
        /// Assigns a staff member to a job with the database controller.
        /// </summary>
        /// <param name="staffID">ID of staff to assign to the job.</param>
        /// <param name="jobID">ID of job which the staff will be assigned to.</param>
        /// <returns>Returns true or false depending on success of method.</returns>
        public bool AssignStaffToJob(int staffID, int jobID) => m_databaseController.AssignStaffToJob(staffID, jobID) ? true : false;
        /// <summary>
        /// Edits a job with the database controller using the passed
        /// in Job's ID.
        /// </summary>
        /// <param name="job">Job to edit.</param>
        /// <returns>Returns true or false depending on success of method.</returns>
        public bool EditJob(Job job) => m_databaseController.EditJobEntry(job) ? true : false;
        /// <summary>
        /// Deletes a job with the database controller.
        /// </summary>
        /// <param name="id">ID of job to delete.</param>
        /// <returns>Returns true or false depending on success of method.</returns>
        public bool DeleteJob(int id) => m_databaseController.DeleteJobByJobID(id) ? true : false;



        #endregion



        #region Misc These methods are used for checking information in the presenter.
        /// <summary>
        /// Returns bool if technical manager is logged in.
        /// </summary>
        /// <returns>Returns true or false depending
        /// on if technical manager is logged in.</returns>
        public bool IsTechnicalManager()
        {
            Staff manager = GetTechnicaManager();

            if (m_loggedInUser == manager.StaffID)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validates if the database controller is initilised.
        /// </summary>
        /// <returns>Returns true or false depending on if the database controller
        /// is initialised.</returns>
        public bool ValidateDatabaseController()
        {
            if (m_databaseController == null)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Sets the logged in user whilst checking the user exists.
        /// </summary>
        /// <param name="staffID">Staff ID to login</param>
        /// <returns>Returns true or false depending on if the user
        /// successfully logged in.</returns>
        public bool SetUser(int staffID)
        {
            if (m_databaseController.GetAllStaff()
                .Exists(s => s.StaffID == staffID))
            {
                m_loggedInUser = staffID;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Checks if the logged in user is valid or not.
        /// </summary>
        /// <returns>Returns true or false depending on if the user
        /// successfully logged in.</returns>
        public bool IsValidUser() => m_loggedInUser != null ? true : false;

        #endregion
    }
}
