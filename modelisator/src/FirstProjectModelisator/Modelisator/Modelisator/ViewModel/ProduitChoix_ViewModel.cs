using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Modelisator.Model;
using Modelisator.View;
using Modelisator.Forms.ViewModel;
using Modelisator.Forms.View;
using Modelisator.Forms.Model;

namespace Modelisator.ViewModel
{
    public class ProduitChoix_ViewModel
    {
        public event EventHandler<EventArgs> ClickBTNProduit;
        public Contexte Ctx;
        public ProduitChoix_ViewModel()
        { }
        public ProduitChoix_ViewModel(Contexte ctx)
        {
            Ctx = ctx;
            View = new ProduitChoix_View_UserControl();
            Model = new ProduitChoix_Model(ctx);
            SetupProduitChoix();
            ConnectView();
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
            View.ProduitChoix_ItemsControl.ItemsSource = Ctx.ListeProduits;

        }

        protected void ConnectView()
        {
            View.CatchClickBTNProduit +=CatchSelectedProduit;
        }
        private void CatchSelectedProduit(object sender, EventArgs args)
        {
            Model.selectionnerProduit((((Button)sender).Content.ToString()));
            if (ClickBTNProduit != null)
                ClickBTNProduit(sender, args);
        }
    }
}
