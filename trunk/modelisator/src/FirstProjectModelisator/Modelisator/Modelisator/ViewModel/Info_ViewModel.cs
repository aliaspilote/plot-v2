using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class Info_ViewModel
    {
        public Info_ViewModel()
        { }
        public Info_ViewModel(Contexte ctx)
        {
            View = new Info_View_UserControl();
            Model = new Info_Model(ctx);
        }

        public Info_View_UserControl View
        {
            get;
            private set;
        }
        public Info_Model Model
        {
            get;
            private set;
        }
    }
}
