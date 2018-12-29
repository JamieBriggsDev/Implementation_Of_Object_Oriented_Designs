using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        [MaxLength(100), Key]
        private string m_firstLine;

        public string FirstLine
        {
            get { return m_firstLine; }
            set { m_firstLine = value; }
        }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        [MaxLength(100)]
        private string m_lastLine;

        public string LastLine
        {
            get { return m_lastLine; }
            set { m_lastLine = value; }
        }

        /// <summary>
        /// The postcode for the address.
        /// </summary>
        [MaxLength(8)]
        public string m_postcode;

        public string Postcode
        {
            get { return m_postcode; }
            set { m_postcode = value; }
        }

    }
}
