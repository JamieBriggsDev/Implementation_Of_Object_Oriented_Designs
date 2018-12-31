using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
                listOfJobs = db.Jobs.ToList();
            }

            return listOfJobs;
        }

        // Returns a specific machine.
        public Machine GetMachineNameFromID(int ID)
        {
            Machine machine;
            using (var db = new DatabaseContext())
            {
                machine = db.Machines.Where(m => m.MachineID == ID).First();
            }

            return machine;
        }

        // Gets the machines specific jobs past and current.
        public List<Job> GetMachineSpecificJobs(int OID)
        {
            List<Job> listOfJobs = new List<Job>();

            using (var db = new DatabaseContext())
            {
                // Get all of the machines 
                listOfJobs = db.Jobs.Where(j => j.MachineID == OID).ToList();
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
                Job job = db.Jobs.SingleOrDefault(j => j.JobID == JobID);

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
                listOfStaff = db.Stafflist.ToList();
            }

            return listOfStaff;
        }

        // Gets all machines related to client.
        public List<Machine> GetClientSpecificMachines(int ClientID)
        {
            List<Machine> listOfMachines = new List<Machine>();

            using (var db = new DatabaseContext())
            {
                listOfMachines = db.Machines.Where(m => m.ClientID == ClientID).ToList();
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

        // Returns the staff ID of specified staff member.
        public int GetStaffID(string forename, string surname)
        {
            int staffID;

            using (var db = new DatabaseContext())
            {

                // We want to grab the singular value for the staff unique identifier.
                staffID = db.Stafflist.SingleOrDefault(s => s.Forename == forename && s.Surname == surname).StaffID;
            }

            return staffID;
        }

        public List<Client> GetAllClients()
        {
            List<Client> listOfClients = new List<Client>();

            using (var db = new DatabaseContext())
            {
                listOfClients = db.Clients.ToList();
            }

            return listOfClients;
        }

        public List<Machine> GetAllMachines()
        {
            List<Machine> listOfMachines = new List<Machine>();

            using (var db = new DatabaseContext())
            {
                listOfMachines = db.Machines.ToList();
            }

            return listOfMachines;
        }

        public bool AddStaff(Staff staff)
        {
            using (var db = new DatabaseContext())
            {
                db.Stafflist.Add(staff);
                db.SaveChanges();
            }

            return true;
        }
    }

    /// <summary>
    /// Database context used to access data.
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        // Holds all the jobs.
        public DbSet<Job> Jobs { get; set; }

        // Holds all the machines.
        public DbSet<Machine> Machines { get; set; }

        // Holds the members of staff.
        public DbSet<Staff> Stafflist { get; set; }

        // Holds the addresses of the companies.
        public DbSet<Address> Addresses { get; set; }

        // Holds all the clients.
        public DbSet<Client> Clients { get; set; }

        // Helpful test output whenever save changes fails due to validation exceptions.
        public override int SaveChanges()
        {
            try
            {
               base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

            return 0;
        }

    }
}
