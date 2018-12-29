using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{

    public class Job
    {
        /// <summary>
        /// Primary Key Unique Identifier for the job.
        /// </summary>
        [Key]
        public int JobID { get; set; }



        public int ClientID { get; set; }
        /// <summary>
        /// Unique Identifier for the client who created the job.
        /// </summary>
        [ForeignKey("ClientID")]
        [Required]
        public virtual Client Client { get; set; }

        public int MachineID { get; set; }
        /// <summary>
        /// Unique identifer for the machine the job is related to.
        /// </summary>
        [ForeignKey("MachineID")]
        [Required]
        public virtual Machine Machine { get; set; }

        /// <summary>
        /// Description for the job requested.
        /// </summary>
        [MinLength(0), MaxLength(255)]
        public string FaultDescription { get; set; }

        [MinLength(0), MaxLength(155)]
        public string Attachment { get; set; }

        /// <summary>
        /// The severity of the job.
        /// </summary>
        public int Urgency { get; set; }

        /// <summary>
        /// Whether the job is currently open or not.
        /// </summary>
        public bool Open { get; set; }


}
}
