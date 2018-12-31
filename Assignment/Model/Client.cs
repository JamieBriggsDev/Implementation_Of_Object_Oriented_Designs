using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO - BRANDON: Change Client class to be integrated into the datebase
    public class Client
    {
        /// <summary>
        /// Clients ID number.
        /// </summary>
        /// 
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
