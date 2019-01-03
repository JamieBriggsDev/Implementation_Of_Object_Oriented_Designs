using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    interface IHome
    {
        void UpdateJobs();

        void RegisterPresenter(Presenter presenter);

        void Initialise();

        void OpenForm();
    }
}
