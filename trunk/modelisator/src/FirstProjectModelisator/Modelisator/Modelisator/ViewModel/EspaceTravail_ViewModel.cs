using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.View;
using Modelisator.Model;
using Modelisator.View;
using Modelisator.GraphSharpe;

namespace Modelisator.ViewModel
{
    public class EspaceTravail_ViewModel
    {

        public EspaceTravail_ViewModel()
        { }
        public EspaceTravail_ViewModel(Contexte ctx)
        {
            GrapProduitGPForm_View EssaiGrap = new GrapProduitGPForm_View();
            MainWindowViewModel VM = new MainWindowViewModel();
            MainWindowsGraphShaper V = new MainWindowsGraphShaper();
            V.DataContext = VM;


            View = new EspaceTravail_View_UserControl();
           // View.GridEspaceTravail.Children.Add(EssaiGrap);
            View.GridEspaceTravail.Children.Add(V);
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
