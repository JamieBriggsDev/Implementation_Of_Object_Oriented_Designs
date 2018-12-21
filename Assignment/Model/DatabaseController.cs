using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DatabaseController : IDatabaseController
    {
        private List<Job> m_jobsList;

        // TODO: BRANDON: Get all jobs implemented
        public bool GetAllJobs()
        {
            throw new NotImplementedException("Get all jobs has not been implemented yet.");
        }

        // TODO: BRANDON: Get specific machine to job
        public bool GetJobsSpecificMachine(int OID)
        {
            throw new NotImplementedException("Get job specific machine has not been implemented yet.");
        }

        // TODO: BRANDON: Assign staff to job
        public bool AssignStaffToJob(int staffID)
        {
            throw new NotImplementedException("Assign staff to job has not been implemented yet.");
        }

        // TODO: BRANDON: Close job
        public bool CloseJob(int JobID)
        {
            throw new NotImplementedException("Close job has not been implemented yet.");
        }

        // TODO: BRANDON: Register a new job
        public bool RegisterJob(Job job)
        {
            throw new NotImplementedException("Register job has not been implemented yet.");
        }

        // TODO: BRANDON: Edit job entrys state
        public bool EditJobEntry(int JobID, string state)
        {
            throw new NotImplementedException("Edit job entry has not been implemented yet.");
        }

        // TODO: BRANDON: Get all staff names
        public void GetAllStaffNames()
        {
            throw new NotImplementedException("Get all staff names has not been implemented yet.");
        }

        // TODO: BRANDON: Get all machines dependant of client
        public void GetClientSpecificMachines(int ClientID)
        {
            throw new NotImplementedException("Get client specific machines has not been implemented yet.");
        }

        // TODO BRANDON: Add new machine
        public bool AddMachine()
        {
            throw new NotImplementedException("Add machine has not been implemented yet.");
        }


        public bool AddClient(string clientName)
        {
            throw new NotImplementedException("Add client has not been implemented yet.");
        }


        public int GetStaffID(string forname, string surname)
        {
            throw new NotImplementedException();
        }
    }
}
