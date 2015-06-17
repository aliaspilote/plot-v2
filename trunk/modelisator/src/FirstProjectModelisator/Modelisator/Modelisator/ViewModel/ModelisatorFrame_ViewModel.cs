using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class ModelisatorFrame_ViewModel
    {

        public ModelisatorFrame_ViewModel(Contexte ctx)
        {
            View = new ModelisatorFram_View_UserControl();
        }

        public ModelisatorFram_View_UserControl View
        {
            get;
            private set;
        }

    }
}
