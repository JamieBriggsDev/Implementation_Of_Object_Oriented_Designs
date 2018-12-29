using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Machine
    {
        /// <summary>
        /// Name of the machine; unique.
        /// </summary>
        [Key]
        public int MachineID { get; set; }

        public int ClientID { get; set; }
        /// <summary>
        /// Unique Identifier for the client who created the job.
        /// </summary>
        [ForeignKey("ClientID")]
        [Required]
        public virtual Client Client { get; set; }

        [MaxLength(10)]
        public string MachineName { get; set; }

        public int JobID { get; set; }

        /// <summary>
        /// How complex the job is.
        /// </summary>
        public int SizeAndComplexity { get; set; }

        /// <summary>
        /// Description of the machine.
        /// </summary>
        [MaxLength(255)]
        public string MachineDescription { get; set; }

    }
}
