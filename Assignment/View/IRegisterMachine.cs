using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IRegisterMachine
    {
        void OpenForm(RegisterJob job);

        void RegisterPresenter(Presenter presenter);

        void Initialise();

        void FillClients();
    
        string ClientSelected { get; set; }
    }
}
