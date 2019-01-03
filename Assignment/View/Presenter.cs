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
        private IShowJob m_showJob;

        public Presenter()
        {
            // Setup home form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialise Database Controller
            m_databaseController = new DatabaseController();

            m_home = new Home(this);
            //m_home.RegisterPresenter(this);
            m_home.OpenForm();
        }
        public bool ValidateDatabaseController()
        {
            if (m_databaseController == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Grabs all the jobs using the database controller.
        /// </summary>
        /// <returns></returns>
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
        /// Using the database controller, grabs all the clients.
        /// </summary>
        /// <returns></returns>
        public List<Client> GetAllClients()
        {
            List<string> clientNames = new List<string>();
            List<Client> clients = m_databaseController.GetAllClients();

            foreach (var client in clients)
            {
                clientNames.Add(client.Name);
            }

            return clients;
        }

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

        public List<string> GetAllClientSpecificMachines(int clientID)
        {
            List<string> MachineNames = new List<string>();
            foreach(var machine in m_databaseController.GetClientSpecificMachines(clientID))
            {
                MachineNames.Add(machine.MachineName);
            }
            return MachineNames;
        }

        public bool OpenRegisterClient()
        {
            try
            {
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

        public bool OpenRegisterJob()
        {
            try
            {
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

        public bool OpenRegisterMachine()
        {
            try
            {
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

        public bool OpenAssignStaff(int jobID)
        {
            try
            {
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

        public bool OpenShowJob(Job job)
        {
            try
            {
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
        // Register Client Stuff
        public void RegisterClient(string name)
        {
            m_databaseController.AddClient(name);
        }


        public bool RegisterJob(Job job)
        {
            // Registers job
            bool success = m_databaseController.RegisterJob(job);

            return success;
        }

        public bool RegisterMachine(Machine machine)
        {
            try
            {
                m_databaseController.AddMachine(machine);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        // Assign staff to job stuff
        public bool AssignStaffToJob(int staffID, int jobID)
        {
            try
            {
                m_databaseController.AssignStaffToJob(staffID, jobID);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        // Gets the client name from a machine
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
            catch(Exception)
            {
                return "ERROR GETTING CLIENT NAME";
            }

        }


        public string GetMachineNameThroughMachineID(int id)
        {
            try
            {
                List<Machine> machines = m_databaseController.GetAllMachines();
                string name = machines.Find(m => m.MachineID == id).MachineName;
                return name;
            }
            catch(Exception)
            {

                return "ERROR GETTING MACHINE NAME";
            }

        }

        public List<string> GetAllMachineNames()
        {
            List<string> MachineNames = new List<string>();
            List<Machine> Machines = m_databaseController.GetAllMachines();

            MachineNames = Machines.Select(m => m.MachineName).ToList();

            return MachineNames;
        }

        public List<Machine> GetAllMachines()
        {
            List<Machine> Machines = m_databaseController.GetAllMachines();
            return Machines;
        }

        public void EditJob(Job job)
        {
            m_databaseController.EditJobEntry(job);
        }

        public void DeleteJob(int id)
        {
            m_databaseController.DeleteJobByJobID(id);
        }

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
    }
}
