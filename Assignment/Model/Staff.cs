using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// A class designed to hold information about staff members.
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Unique identifier for staff member.
        /// </summary>
        [Key]
        public int StaffID { get; set; }

        /// <summary>
        /// Forename of the staff member.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// Surname of the staff member.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// What role the staff member has.
        /// </summary>
        public string Role { get; set; }



    }
}
