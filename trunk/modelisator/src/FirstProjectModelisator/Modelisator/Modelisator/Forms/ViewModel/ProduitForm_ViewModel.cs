using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;
using Modelisator.Model;


namespace Modelisator.Forms.ViewModel
{
    public class ProduitForm_ViewModel
    {

        public ProduitForm_ViewModel()
        { }
        public ProduitForm_ViewModel(Contexte ctx)
        {
            View = new ProduitForm_View();
            Model = new ProduitForm_Model(ctx);
            SetupProduitForm();
        }

        public ProduitForm_View View
        {
            get;
            private set;
        }
        public ProduitForm_Model Model
        {
            get;
            private set;
        }

        protected void SetupProduitForm()
        {

            //ProduitChoix_ViewModel = new ProduitChoix_ViewModel(Ctx);

            //View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
            //View.ProduitChoix_ItemsControl.DataContext 

        }
    }
}
