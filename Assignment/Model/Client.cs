// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Client class designed to hold client information.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Clients ID number.
        /// </summary>
        [Key]
        public int ClientID { get; set; } 

        /// <summary>
        /// Name of the client.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Default initialiser.
        /// </summary>
        public Client() { }

        /// <summary>
        /// Easy initialisation of a client.
        /// </summary>
        public Client(string name)
        {
            Name = name;
        }

        
        
    }
}
