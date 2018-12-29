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
        public string FirstLine { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        [MaxLength(100)]
        private string LastLine { get; set; }

        /// <summary>
        /// The postcode for the address.
        /// </summary>
        [MaxLength(8)]
        public string PostCode { get; set; }


    }
}
