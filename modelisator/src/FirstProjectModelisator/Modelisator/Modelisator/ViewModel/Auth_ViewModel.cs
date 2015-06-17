using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class Auth_ViewModel
    {

        public Auth_View_UserControl View
        {
            get;
            private set;
        }

        public Auth_ViewModel()
        {
            View = new Auth_View_UserControl();
        }

    }
}
