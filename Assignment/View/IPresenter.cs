using System.Collections.Generic;
using Model;

namespace View
{
    public interface IPresenter
    {
        bool AssignStaffToJob(int staffID, int jobID);
        bool DeleteJob(int id);
        bool EditJob(Job job);
        List<Client> GetAllClients();
        List<string> GetAllClientSpecificMachines(int clientID);
        List<Job> GetAllJobs();
        List<string> GetAllMachineNames();
        List<Machine> GetAllMachines();
        int GetClientID(string name);
        string GetClientNameThroughMachineID(int id);
        string GetMachineNameThroughMachineID(int id);
        string GetStaffInitials(int id);
        bool OpenAssignStaff(int jobID);
        bool OpenRegisterClient();
        bool OpenRegisterJob();
        bool OpenRegisterMachine();
        bool OpenShowJob(Job job);
        bool RegisterClient(string name);
        bool RegisterJob(Job job);
        bool RegisterMachine(Machine machine);
        bool ValidateDatabaseController();
    }
}