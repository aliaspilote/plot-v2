using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class ProduitChoix_ViewModel
    {
        public ProduitChoix_ViewModel()
        { }
        public ProduitChoix_ViewModel(Contexte ctx)
        {
            View = new ProduitChoix_View_UserControl();
            Model = new ProduitChoix_Model(ctx);
        }

        public ProduitChoix_View_UserControl View
        {
            get;
            private set;
        }
        public ProduitChoix_Model Model
        {
            get;
            private set;
        }
    }
}
