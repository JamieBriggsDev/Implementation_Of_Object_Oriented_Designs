using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View.Presenter
{
    public class RegisterClientPresenter
    {
        /// <summary>
        /// Register Client Presenter Screen.
        /// </summary>
        private IRegisterClient m_screen;
        /// <summary>
        /// Registered Clients Model Presenter Data.
        /// </summary>
        private IRegisteredClientsModel m_data;

        /// <summary>
        /// Register Client Presenter Screen.
        /// </summary>
        public IRegisterClient Screen
        {
            get { return m_screen; }
            set { m_screen = value; }
        }

        /// <summary>
        /// Registered Clients Presenter Screen.
        /// </summary>
        public IRegisteredClientsModel Data
        {
            get { return m_data; }
            set { m_data = value; }
        }


    }
}
