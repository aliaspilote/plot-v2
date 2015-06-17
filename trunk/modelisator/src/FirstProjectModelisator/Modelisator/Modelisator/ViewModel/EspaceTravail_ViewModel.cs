using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class EspaceTravail_ViewModel
    {

        public EspaceTravail_ViewModel()
        { }
        public EspaceTravail_ViewModel(Contexte ctx)
        {
            View = new EspaceTravail_View_UserControl();
            Model = new EspaceTravail_Model(ctx);
        }

        public EspaceTravail_View_UserControl View
        {
            get;
            private set;
        }
        public EspaceTravail_Model Model
        {
            get;
            private set;
        }


    }
}
