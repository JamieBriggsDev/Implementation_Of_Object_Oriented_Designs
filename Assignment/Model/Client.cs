using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        /// <summary>
        /// Name of the client.
        /// </summary>
        private string m_name;
        /// <summary>
        /// Clients ID number.
        /// </summary>
        private int m_ClientID;

        /// <summary>
        /// Name of the client.
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// Clients ID number.
        /// </summary>
        public int ClientID
        {
            get { return m_ClientID; }
            set { m_ClientID = value; }
        }
        
    }
}
