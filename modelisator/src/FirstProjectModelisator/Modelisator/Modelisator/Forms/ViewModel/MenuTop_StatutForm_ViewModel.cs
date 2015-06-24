using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;
using Modelisator.Model;

namespace Modelisator.Forms.ViewModel
{
    public class MenuTop_StatutForm_ViewModel
    {
        public MenuTop_StatutForm_ViewModel()
        { }
        public MenuTop_StatutForm_ViewModel(Contexte ctx)
        {
            View = new MenuTop_StatutForm_View();
            Model = new MenuTop_StatutForm_Model(ctx);
            SetupMenuTopStatutForm();
        }

        public MenuTop_StatutForm_View View
        {
            get;
            private set;
        }
        public MenuTop_StatutForm_Model Model
        {
            get;
            private set;
        }

        protected void SetupMenuTopStatutForm()
        {

            //ProduitChoix_ViewModel = new ProduitChoix_ViewModel(Ctx);

            //View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
            //View.ProduitChoix_ItemsControl.DataContext 

        }
    }
}
