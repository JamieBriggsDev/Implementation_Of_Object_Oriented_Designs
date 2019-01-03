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
    /// <summary>
    /// Controls data in and out of the database.
    /// Inherits from IDatabaseController.
    /// </summary>
    public class DatabaseController : IDatabaseController
    {

        /// <summary>
        /// Gets a list of jobs.
        /// </summary>
        /// <returns>Returns a list of jobs.</returns>
        public List<Job> GetAllJobs()
        {
            List<Job> listOfJobs = new List<Job>();

            using (var db = new DatabaseContext())
            {

                listOfJobs = db.Jobs.ToList();
            }

            return listOfJobs;
        }

        /// <summary>
        /// Calculates the due date time based on urgency and registry date.
        /// </summary>
        /// <param name="job"></param>
        /// <returns>Returns the number of days the job is due in.</returns>
        public int CalculateJobDueDate(Job job)
        {
            int days;

            switch (job.Urgency)
            {
                case 1:
                    days = 40;
                    break;
                case 2:
                    days = 14;
                    break;
                case 3:
                    days = 7;
                    break;
                case 4:
                    days = 3;
                    break;
                case 5:
                    days = 1;
                    break;

                default:
                    days = 90;
                    break;
            }

            return days;
        }

        /// <summary>
        /// Returns a specific machine.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns a machine.</returns>
        public Machine GetMachineNameFromID(int ID)
        {
            Machine machine;
            using (var db = new DatabaseContext())
            {
                machine = db.Machines.Where(m => m.MachineID == ID).First();
            }

            return machine;
        }

        /// <summary>
        /// Get's all specific jobs for the specified machine.
        /// </summary>
        /// <param name="OID"></param>
        /// <returns>Returns a job list.</returns>
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
  

        /// <summary>
        /// Assigns a staff member to a specified job.
        /// </summary>
        /// <param name="staffID"></param>
        /// <param name="jobID"></param>
        /// <returns>Returns true if successful.</returns>
        public bool AssignStaffToJob(int staffID, int jobID)
        {
            using (var db = new DatabaseContext())
            {
                var job = db.Jobs.SingleOrDefault(j => j.JobID == jobID);

                if (job != null)
                {
                    job.StaffID = staffID;
                    job.Open = true;
                    db.SaveChanges();
                }
            }
            return true;
        }

        /// <summary>
        /// Closes a specified job.
        /// </summary>
        /// <param name="jobID"></param>
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

        /// <summary>
        /// Registers a new job to the database.
        /// </summary>
        /// <param name="job"></param>
        /// <returns>Returns true if successful.</returns>
        public bool RegisterJob(Job job)
        {
            using (var db = new DatabaseContext())
            {

                if (job != null)
                {

                    // Need to make sure that the completion date is automated based on urgency.
                    int days = CalculateJobDueDate(job);

                    job.CompletionDate = job.JobCreated.AddDays(days);
                    db.Jobs.Add(job);
                    db.SaveChanges();
                }
            }

            return true;
        }

        /// <summary>
        /// Edits the specified job
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns>Returns true if successfull.</returns>
        public bool EditJobEntry(Job jobInfo)
        {
            using (var db = new DatabaseContext())
            {
                if (jobInfo != null)
                {
                    jobInfo.CompletionDate = jobInfo.JobCreated.AddDays(CalculateJobDueDate(jobInfo));
                    db.Entry(jobInfo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            return true;
        }

        /// <summary>
        /// Returns a list of staff members.
        /// </summary>
        /// <returns>A staff list object.</returns>
        public List<Staff> GetAllStaff()
        {
            List<Staff> listOfStaff = new List<Staff>();

            using (var db = new DatabaseContext())
            {
                listOfStaff = db.Stafflist.ToList();
            }

            return listOfStaff;
        }

        /// <summary>
        /// Returns a list of machines related to the client passed.
        /// </summary>
        /// <param name="ClientID"></param>
        /// <returns>List of machines.</returns>
        public List<Machine> GetClientSpecificMachines(int ClientID)
        {
            List<Machine> listOfMachines = new List<Machine>();

            using (var db = new DatabaseContext())
            {
                listOfMachines = db.Machines.Where(m => m.ClientID == ClientID).ToList();
            }

            return listOfMachines;
        }

        /// <summary>
        /// Adds a new machine to the database.
        /// </summary>
        /// <param name="machine"></param>
        /// <returns>Returns true </returns>
        public bool AddMachine(Machine machine)
        {
            using (var db = new DatabaseContext())
            {
                db.Machines.Add(machine);
                db.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Adds a new client to the database.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns true if successful.</returns>
        public bool AddClient(string name)
        {
            using (var db = new DatabaseContext())
            {
                db.Clients.Add(new Client(name));
                db.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Gets a specific staff ID.
        /// </summary>
        /// <param name="forename"></param>
        /// <param name="surname"></param>
        /// <returns>Returns the staffID of the staff member provided.</returns>
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

        /// <summary>
        /// Get's all of the clients.
        /// </summary>
        /// <returns>Returns a list of clients.</returns>
        public List<Client> GetAllClients()
        {
            List<Client> listOfClients = new List<Client>();

            using (var db = new DatabaseContext())
            {
                listOfClients = db.Clients.ToList();
            }

            return listOfClients;
        }

        /// <summary>
        /// Get's all the machines.
        /// </summary>
        /// <returns>Returns a list of machines.</returns>
        public List<Machine> GetAllMachines()
        {
            List<Machine> listOfMachines = new List<Machine>();

            using (var db = new DatabaseContext())
            {
                listOfMachines = db.Machines.ToList();
            }

            return listOfMachines;
        }

        /// <summary>
        /// Adds a staff member to the database.
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>Returns true if successfull.</returns>
        public bool AddStaff(Staff staff)
        {
            using (var db = new DatabaseContext())
            {
                db.Stafflist.Add(staff);
                db.SaveChanges();
            }

            return true;
        }
        
        /// <summary>
        /// Edits a staff members role.
        /// </summary>
        /// <param name="staff"></param>
        /// <returns>Returns true if successful.</returns>
        public bool EditStaffRole(Staff staff)
        {
            using (var db = new DatabaseContext())
            {
                db.Entry(staff).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Gets a staff member by their ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a staff member.</returns>
        public Staff GetSpecificStaffMember(int id)
        {
            Staff staff;

            using (var db = new DatabaseContext())
            {
                staff = db.Stafflist.SingleOrDefault(s => s.StaffID == id);
            }

            return staff;
        }

        /// <summary>
        ///  Deletes a job from the ID given.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Returns true if successful.</returns>
        public bool DeleteJobByJobID(int ID)
        {
            using (var db = new DatabaseContext())
            {
                var job = db.Jobs.SingleOrDefault(j => j.JobID == ID);

                if (job != null)
                {
                    db.Jobs.Remove(job);
                    db.SaveChanges();
                }
            }
            return true;
        }

    }

    /// <summary>
    /// Database context used to access and query data.
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        /// <summary>
        /// Holds all of the jobs in the database.
        /// </summary>
        public DbSet<Job> Jobs { get; set; }

        /// <summary>
        /// Holds all of the machines in the database.
        /// </summary>
        public DbSet<Machine> Machines { get; set; }

        /// <summary>
        /// Holds all of the staff members in the database.
        /// </summary>
        public DbSet<Staff> Stafflist { get; set; }

        /// <summary>
        /// Holds all of the addresses in the database.
        /// </summary>
        //public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Holds all of the clients in the database.
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Override of save changes to report on any data validation errors.
        /// </summary>
        /// <returns>Returns 0 regardless of outcome.</returns>
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
