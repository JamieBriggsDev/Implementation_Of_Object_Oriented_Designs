using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IShowJob
    {
        void OpenForm(Home home);

        void RegisterPresenter(Presenter presenter);

        void LoadJob(Job job);

    }
}
