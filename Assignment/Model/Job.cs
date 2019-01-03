using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    /// <summary>
    /// A class made to hold information about jobs.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// Primary Key Unique Identifier for the job.
        /// </summary>
        [Key]
        public int JobID { get; set; }

        /// <summary>
        /// Date the job was created.
        /// </summary>
        public DateTime JobCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Contains the machineID of which the job was created for.
        /// </summary>
        public int MachineID { get; set; }

        /// <summary>
        /// If assigned, holds the staffID of the staff member.
        /// </summary>
        public int StaffID { get; set; }

        /// <summary>
        /// Holds the location of the job.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Description for the job requested.
        /// </summary>
        [MinLength(0), MaxLength(255)]
        public string FaultDescription { get; set; }

        /// <summary>
        /// The state the job is currently in.
        /// </summary>
        public string State { get; set; } = "Estimate needed";

        /// <summary>
        /// An image of the issue described.
        /// </summary>
        public byte[] Attachment { get; set; }

        /// <summary>
        /// The severity of the job.
        /// </summary>
        public int Urgency { get; set; }

        /// <summary>
        /// Time for completion.
        /// </summary>
        public DateTime CompletionDate { get; set; }
        
        /// <summary>
        /// Whether the job is currently open or not.
        /// </summary>
        public bool Open { get; set; } = false;


}
}
