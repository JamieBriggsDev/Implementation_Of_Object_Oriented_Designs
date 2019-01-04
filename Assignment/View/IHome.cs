using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    interface IHome
    {
        void OpenForm();

        void RegisterPresenter(Presenter presenter);

        void UpdateJobs();

        void Initialise();
    }
}
