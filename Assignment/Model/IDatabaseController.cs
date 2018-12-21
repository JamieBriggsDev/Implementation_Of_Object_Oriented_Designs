using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDatabaseController
    {
        bool GetAllJobs();

        bool GetJobsSpecificMachine(int OID);

        bool AssignStaffToJob(int staffID);

        bool CloseJob(int JobID);

        bool RegisterJob(Job job);

        bool EditJobEntry(int JobID, string state);

        void GetAllStaffNames();

        int GetStaffID(string forname, string surname);

        void GetClientSpecificMachines(int ClientID);

        bool AddMachine();

        bool AddClient(string clientName);
    }
}
