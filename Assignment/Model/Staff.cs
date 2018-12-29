using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        /// <summary>
        /// Unique identifier for staff member.
        /// </summary>
        [Key]
        public int m_staffID;

        public int StaffID
        {
            get { return m_staffID; }
            set { m_staffID = value; }
        }

        /// <summary>
        /// Forename of the staff member.
        /// </summary>
        private string m_forename;

        public string Forename
        {
            get { return m_forename; }
            set { m_forename = value; }
        }

        /// <summary>
        /// Surname of the staff member.
        /// </summary>
        public string m_surname;

        public string Surname
        {
            get { return m_surname; }
            set { m_surname = value; }
        }



    }
}
