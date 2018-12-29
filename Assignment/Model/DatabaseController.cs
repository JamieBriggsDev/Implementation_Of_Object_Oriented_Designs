using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DatabaseController : IDatabaseController
    {

        // Returns a list of jobs.
        public List<Job> GetAllJobs()
        {
            // The list of jobs to return for the form to display.
            List<Job> listOfJobs = new List<Job>();

            // Use the database context to access data.
            using (var db = new DatabaseContext())
            {

                // Query to get all the jobs and order by open.
                var jobs = from j in db.Jobs
                           orderby j.Open
                           select j;

                // Go through each of them and add them to the list.
                foreach (var item in jobs)
                {
                    listOfJobs.Add(item);
                }
            }

            return listOfJobs;
        }

        // Gets the machines specific jobs past and current.
        public bool GetMachineSpecificJobs(int OID)
        {
            throw new NotImplementedException("Get job specific machine has not been implemented yet.");
        }

        // TODO - BRANDON: Assign staff to job
        public bool AssignStaffToJob(int staffID)
        {
            throw new NotImplementedException("Assign staff to job has not been implemented yet.");
        }

        // TODO - BRANDON: Close job
        public bool CloseJob(int JobID)
        {
            throw new NotImplementedException("Close job has not been implemented yet.");
        }

        // TODO - BRANDON: Register a new job
        public bool RegisterJob(Job job)
        {
            throw new NotImplementedException("Register job has not been implemented yet.");
        }

        // TODO - BRANDON: Edit job entrys state
        public bool EditJobEntry(int JobID, string state)
        {
            throw new NotImplementedException("Edit job entry has not been implemented yet.");
        }

        // TODO - BRANDON: Get all staff names
        public List<Staff> GetAllStaff()
        {
            List<Staff> listOfStaff = new List<Staff>();

            using (var db = new DatabaseContext())
            {
                var staff = from s in db.Stafflist
                            orderby s.Surname
                            select s;

                foreach(var item in staff)
                {
                    listOfStaff.Add(item);
                }
            }

            return listOfStaff;
        }

        // TODO - BRANDON: Get all machines dependant of client
        public void GetClientSpecificMachines(int ClientID)
        {
            throw new NotImplementedException("Get client specific machines has not been implemented yet.");
        }

        // TODO - BRANDON: Add new machine
        public bool AddMachine()
        {
            throw new NotImplementedException("Add machine has not been implemented yet.");
        }

        // TODO - BRANDON: Add client
        public bool AddClient(string clientName)
        {
            throw new NotImplementedException("Add client has not been implemented yet.");
        }

        // TODO - BRANDON: Get staff ID
        public int GetStaffID(string forename, string surname)
        {
            int staffID;

            using (var db = new DatabaseContext())
            {
                var staff = db.Stafflist.Where(s => s.Forename == forename && s.Surname == surname)
                .First();
                staffID = staff.StaffID;
            }

            return staffID;
        }
    }

    /// <summary>
    /// Database context used to access data.
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Staff> Stafflist { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
