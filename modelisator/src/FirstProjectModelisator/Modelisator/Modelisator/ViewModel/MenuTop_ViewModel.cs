using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class MenuTop_ViewModel
    {
        public MenuTop_ViewModel()
        { }
        public MenuTop_ViewModel(Contexte ctx)
        {
            View = new MenuTop_View_UserControl();
            Model = new MenuTop_Model(ctx);
        }

        public MenuTop_View_UserControl View
        {
            get;
            private set;
        }
        public MenuTop_Model Model
        {
            get;
            private set;
        }
    }
}
