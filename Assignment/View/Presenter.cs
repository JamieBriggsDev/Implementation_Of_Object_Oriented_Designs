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
            // Initialise Database Controller
            m_databaseController = new DatabaseController();
            // Setup home form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            m_home = new Home();
            m_home.RegisterPresenter(this);    
            m_home.RunForm();
        }

        public void OpenRegisterClient()
        {
            m_registerClient = new RegisterClient();
            m_registerClient.RegisterPresenter(this);
            m_registerClient.OpenChild(m_home as Home);
        }

        public void OpenRegisterJob()
        {
            m_registerJob = new RegisterJob();
            m_registerJob.RegisterPresenter(this);
            m_registerJob.OpenChild(m_home as Home);
        }

        public void OpenRegisterMachine()
        {
            m_registerMachine = new RegisterMachine();
            m_registerMachine.RegisterPresenter(this);
            m_registerMachine.OpenChild(m_registerJob as RegisterJob);
        }

        public void OpenAssignStaff()
        {
            m_assignStaff = new AssignStaffToJob();
            m_assignStaff.RegisterPresenter(this);

            // TODO -JAMIE: Fill staff names and jobs
            List<string> names = new List<string>();
            names.Add("Jamie");
            m_assignStaff.FillStaffNames(names);

            List<string> jobs = new List<string>();
            jobs.Add("Egg");
            m_assignStaff.FillJobs(jobs);


            m_assignStaff.OpenChild(m_home as Home);
        }

        // Register Client Stuff
        public void RegisterClient(string name)
        {
            m_databaseController.AddClient(name);
        }

        // Register Job stuff
        public void RegisterJob()
        {
            // TODO -ANY: Register job function needs doing
            m_databaseController.RegisterJob(new Job());
        }

        // Assign staff to job stuff
        public void AssignStaffToJob(string forename, string surname)
        {
            int StaffID = m_databaseController.GetStaffID(forename, surname);
            m_databaseController.AssignStaffToJob(StaffID);
        }

    }
}
