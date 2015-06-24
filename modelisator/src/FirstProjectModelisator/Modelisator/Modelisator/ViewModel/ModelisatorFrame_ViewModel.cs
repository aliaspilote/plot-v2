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
        public Contexte Ctx;
        public EspaceTravail_ViewModel EspaceTravail_ViewModel;
        public Info_ViewModel Info_ViewModel;
        public MenuTop_ViewModel MenuTop_ViewModel;
        public ProduitChoix_ViewModel ProduitChoix_ViewModel;

        public ModelisatorFrame_ViewModel(Contexte ctx)
        {
            View = new ModelisatorFram_View_UserControl();
            Model = new ModelisatorFrame_Model(ctx);
            SetupModelisatorFrame();
            
        }

        public ModelisatorFram_View_UserControl View
        {
            get;
            private set;
        }
        public ModelisatorFrame_Model Model
        {
            get;
            private set;
        }
        protected void SetupModelisatorFrame()
        {
            EspaceTravail_ViewModel = new EspaceTravail_ViewModel(Ctx);
            Info_ViewModel = new Info_ViewModel(Ctx);
            MenuTop_ViewModel = new MenuTop_ViewModel(Ctx);
            ProduitChoix_ViewModel = new ProduitChoix_ViewModel(Ctx);
            
            View.ProduitChoix_ContentPanel.Children.Add(ProduitChoix_ViewModel.View);
            View.EspaceTravail_ContentPanel.Children.Add(EspaceTravail_ViewModel.View);
            View.Info_ContentPanel.Children.Add(Info_ViewModel.View);
            View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
            
        }

    }
}
