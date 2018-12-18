using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Presenter
{
    public interface IRegisterClient
    {
        /// <summary>
        /// Register a presenter for this interface.
        /// </summary>
        /// <param name="_presenter">Presenter to register.</param>
        void RegisterPresenter(RegisterClientPresenter _presenter);

    }
}
