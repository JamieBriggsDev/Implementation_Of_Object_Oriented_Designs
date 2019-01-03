using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// An interface for an object to access data from a database.
    /// </summary>
    public interface IDatabaseController
    {
        List<Job> GetAllJobs();

        int CalculateJobDueDate(Job job);

        Machine GetMachineNameFromID(int ID);

        List<Job> GetMachineSpecificJobs(int OID);

        bool AssignStaffToJob(int staffID, int jobID);

        void CloseJob(int jobID);

        bool RegisterJob(Job job);

        bool EditJobEntry(Job jobInfo);

        List<Staff> GetAllStaff();

        int GetStaffID(string forename, string surname);

        List<Machine> GetClientSpecificMachines(int ClientID);

        bool AddMachine(Machine machine);

        bool AddClient(string name);

        List<Client> GetAllClients();

        List<Machine> GetAllMachines();

        bool AddStaff(Staff staff);

        bool EditStaffRole(Staff staff);

        Staff GetSpecificStaffMember(int ID);

        bool DeleteJobByJobID(int ID);

    }
}
