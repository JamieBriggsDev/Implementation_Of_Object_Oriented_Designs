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
        public List<Job> GetMachineSpecificJobs(int OID)
        {
            List<Job> listOfJobs = new List<Job>();

            using (var db = new DatabaseContext())
            {
                // Get all of the machines 
                var jobs = from j in db.Jobs
                               where j.MachineID == OID
                               select j;
               
               foreach (var item in jobs)
                {
                    listOfJobs.Add(item);
                }

            }
            return listOfJobs;
        }

        // Assigns staff to job
        public bool AssignStaffToJob(int staffID, int jobID)
        {
            using (var db = new DatabaseContext())
            {
                var job = db.Jobs.SingleOrDefault(j => j.JobID == jobID);

                if (job != null)
                {
                    job.StaffID = staffID;
                    db.SaveChanges();
                }
            }
            return true;
        }

        // Sets the specified job status to closed.
        public void CloseJob(int jobID)
        {
            using (var db = new DatabaseContext())
            {
                var job = db.Jobs.SingleOrDefault(j => j.JobID == jobID);

                if (job != null)
                {
                    job.Open = false;
                    db.SaveChanges();
                }
            }
        }

        // Registers a new job
        public bool RegisterJob(Job job)
        {
            using (var db = new DatabaseContext())
            {
                db.Jobs.Add(job);
                db.SaveChanges();
            }

            return true;
        }

        // Edit job entrys 

        public bool EditJobEntry(int JobID, string state)
        {
            using (var db = new DatabaseContext())
            {
                var job = db.Jobs.SingleOrDefault(j => j.JobID == JobID);

                if (job != null)
                {
                    job.State = state;
                    db.SaveChanges();
                }
            }
            return true;
        }

        //  Gets all staff members.
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

        // Gets all machines related to client.
        public List<Machine> GetClientSpecificMachines(int ClientID)
        {
            List<Machine> listOfMachines = new List<Machine>();

            using (var db = new DatabaseContext())
            {
                var machines = from m in db.Machines
                               where m.ClientID == ClientID
                               select m;

                foreach(var item in machines)
                {
                    listOfMachines.Add(item);
                }
            }

            return listOfMachines;
        }

        // Adds a new machine to the database.
        public bool AddMachine(Machine machine)
        {
            using (var db = new DatabaseContext())
            {
                db.Machines.Add(machine);
                db.SaveChanges();
            }

            return true;
        }

        // Adds a new client to the database.
        public bool AddClient(string name)
        {
            using (var db = new DatabaseContext())
            {
                db.Clients.Add(new Client(name));
                db.SaveChanges();
            }

            return true;
        }

        public List<Client> GetAllClients()
        {
            List<Client> listOfClient = new List<Client>();

            using (var db = new DatabaseContext())
            {
                var client = from c in db.Clients
                             orderby c.Name
                             select c;

                foreach(var item in client)
                {
                    listOfClient.Add(item);
                }
            }

            return listOfClient;
        }

        // Returns the staff ID of specified staff member.
        public int GetStaffID(string forename, string surname)
        {
            int staffID;

            using (var db = new DatabaseContext())
            {
                var staff = db.Stafflist.SingleOrDefault(s => s.Forename == forename && s.Surname == surname);
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
