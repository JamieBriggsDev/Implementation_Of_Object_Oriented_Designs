using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IAssignStaffToJob
    {
        void OpenChild(Home home);

        void RegisterPresenter(Presenter presenter);

        void FillStaffNames(List<String> _names);

        void FillJobs(List<String> _jobs);
    }
}
