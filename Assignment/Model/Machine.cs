using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// How complex the job is.
        /// </summary>
        private int m_sizeAndComplexity;

        /// <summary>
        /// Description of the machine.
        /// </summary>
        [MaxLength(255)]
        private string m_machineDescription;

        /// <summary>
        /// Name of the machine; unique.
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// How complex the job is.
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
