using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface ILogin
    {
        void OpenForm(Home home);

        void FillStaffComboBox();

        void RegisterPresenter(Presenter presenter);

    }
}
