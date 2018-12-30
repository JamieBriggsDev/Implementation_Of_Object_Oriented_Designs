using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    interface IHome
    {
        void GetAllJobs();

        void RegisterPresenter(Presenter presenter);

        void OpenForm();
    }
}
