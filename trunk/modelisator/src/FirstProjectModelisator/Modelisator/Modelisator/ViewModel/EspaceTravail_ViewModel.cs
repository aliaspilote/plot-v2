using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.View;
using Modelisator.Model;
using Modelisator.MonGraphX;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class EspaceTravail_ViewModel
    {

        public EspaceTravail_ViewModel()
        { }
        public EspaceTravail_ViewModel(Contexte ctx)
        {
            MonGraph_ViewModel MonGraph_ViewModel = new MonGraph_ViewModel(ctx);


            View = new EspaceTravail_View_UserControl();
           // View.GridEspaceTravail.Children.Add(EssaiGrap);
            View.GridEspaceTravail.Children.Add(MonGraph_ViewModel.View);
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
