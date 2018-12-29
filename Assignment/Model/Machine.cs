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
        [MaxLength(20), Key]
        private string m_name;

        /// <summary>
        /// ID of the job assigned to the machine.
        /// </summary>
        [ForeignKey("jobID")]
        private int m_jobID;
        
        /// <summary>
        /// How complex the job is.
        /// </summary>
        private int m_sizeAndComplexity;

        /// <summary>
        /// Description of the machine.
        /// </summary>
        [MaxLength(255)]
        private string m_machineDescription;

        /// <summary>
        /// Getter setter for the machine name.
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        
        /// <summary>
        /// Getter for the job ID.
        /// We don't have a setter as it is a foreign key.
        /// </summary>
        public int JobID
        {
            get { return m_jobID; }
        }

        /// <summary>
        /// Getter setter for the complexity.
        /// </summary>
        public int Complexity
        {
            get { return m_sizeAndComplexity; }
            set { m_sizeAndComplexity = value; }
        }

        /// <summary>
        /// Description of the machine.
        /// </summary>
        public string MachineDescription
        {
            get { return m_machineDescription; }
            set { m_machineDescription = value; }
        }
    }
}
