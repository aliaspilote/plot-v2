using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using Modelisator.View;
using Modelisator.Forms.ViewModel;
using Modelisator.Forms.View;
using Modelisator.Forms.Model;

namespace Modelisator.ViewModel
{
    public class ProduitChoix_ViewModel
    {
        public Contexte Ctx;
        public ProduitForm_ViewModel ProduitForm_ViewModel;
        public ProduitChoix_ViewModel()
        { }
        public ProduitChoix_ViewModel(Contexte ctx)
        {
            Ctx = ctx;
            View = new ProduitChoix_View_UserControl();
            Model = new ProduitChoix_Model(ctx);
            SetupProduitChoix();
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

        protected void SetupProduitChoix()
        {

            ProduitForm_ViewModel = new ProduitForm_ViewModel(Ctx);

            //View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
            //View.ProduitChoix_ItemsControl.DataContext = ProduitForm_ViewModel.View;
            //View.ProduitChoix_ItemsControl.DataContext 

        }
    }
}
