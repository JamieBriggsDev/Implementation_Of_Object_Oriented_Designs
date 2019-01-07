// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Jamie Briggs
// Brandon Taylor
// 07/01/2019
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    /// <summary>
    /// IRegisterMachine Interface for form
    /// </summary>
    public interface IRegisterMachine
    {
        void OpenForm(RegisterJob job);

        void RegisterPresenter(Presenter presenter);

        void Initialise();

        void FillClients();
    
        string ClientSelected { get; set; }
    }
}
