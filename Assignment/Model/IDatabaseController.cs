using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDatabaseController
    {
        List<Job> GetAllJobs();

        bool GetMachineSpecificJobs(int OID);

        bool AssignStaffToJob(int staffID);

        void CloseJob(int jobID);

        bool RegisterJob(Job job);

        bool EditJobEntry(int JobID, string state);

        List<Staff> GetAllStaff();

        int GetStaffID(string forename, string surname);

        void GetClientSpecificMachines(int ClientID);

        bool AddMachine();

        bool AddClient(string clientName);
    }
}
