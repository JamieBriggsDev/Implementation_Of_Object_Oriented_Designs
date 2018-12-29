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

        List<Job> GetMachineSpecificJobs(int OID);

        bool AssignStaffToJob(int staffID, int jobID);

        void CloseJob(int jobID);

        bool RegisterJob(Job job);

        bool EditJobEntry(int JobID, string state);

        List<Staff> GetAllStaff();

        int GetStaffID(string forename, string surname);

        List<Machine> GetClientSpecificMachines(int ClientID);

        bool AddMachine(Machine machine);

        bool AddClient(string name);
    }
}
