using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRegisteredClientsModel
    {
        /// <summary>
        /// Get all clients.
        /// </summary>
        /// <returns>Returns a list of clients.</returns>
        List<Client> GetClients();

        /// <summary>
        /// Register a new client.
        /// </summary>
        /// <param name="_entry">New Client.</param>
        /// <returns></returns>
        bool Register(Client _entry);
    }
}
