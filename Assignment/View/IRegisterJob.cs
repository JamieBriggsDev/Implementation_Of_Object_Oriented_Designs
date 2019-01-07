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
    /// IRegisterJob Interface for form
    /// </summary>
    public interface IRegisterJob
    {
        void OpenForm(Home home);

        void RegisterPresenter(Presenter presenter);

        void Initialise();

        void GetAllClients();

    }
}
