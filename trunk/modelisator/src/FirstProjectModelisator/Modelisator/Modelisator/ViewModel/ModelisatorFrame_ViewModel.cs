using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Modelisator.Forms.ViewModel;
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

        public event EventHandler<EventArgs> DeconnecterHandler;

        public ModelisatorFrame_ViewModel(Contexte ctx)
        {
            Ctx = ctx;
            View = new ModelisatorFram_View_UserControl();
            Model = new ModelisatorFrame_Model(ctx);
            SetupModelisatorFrame();
            ConnectView();

        }

        public ModelisatorFram_View_UserControl View { get; private set; }
        public ModelisatorFrame_Model Model { get; private set; }

        protected void PapierPeintChange(object sender, EventArgs e)
        {
            View.PapierpeintGrid.Background = MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.Model.CouleurBrush;
            Refresh();
        }

        protected void ChoixProduit_Clik_Action(object sender, EventArgs e)
        {
            EspaceTravail_ViewModel = new EspaceTravail_ViewModel(Ctx);
            View.EspaceTravail_ContentPanel.Children.Add(EspaceTravail_ViewModel.View);
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.View.btn_VueEnsemble.IsEnabled = true;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.View.btn_Export.IsEnabled = true;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.View.btn_Import.IsEnabled = true;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.View.btn_RAZ_GP.IsEnabled = true;
        }

        protected void SetupModelisatorFrame()
        {
            
            Info_ViewModel = new Info_ViewModel(Ctx);
            MenuTop_ViewModel = new MenuTop_ViewModel(Ctx);
            ProduitChoix_ViewModel = new ProduitChoix_ViewModel(Ctx);

            View.ProduitChoix_ContentPanel.Children.Add(ProduitChoix_ViewModel.View);
            View.Info_ContentPanel.Children.Add(Info_ViewModel.View);
            View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
        }

        public void ConnectView()
        {
            View.PapierpeintGrid.DataContext = MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.Model.CouleurBrush;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.OKCOULEUR += PapierPeintChange;
            ProduitChoix_ViewModel.ClickBTNProduit += ChoixProduit_Clik_Action;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.VueEnsemble += VueEnsemble_Clik_Action;
        }

        public void DeconnectView()
        {
            View.PapierpeintGrid.DataContext = null;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.OKCOULEUR -= PapierPeintChange;
            ProduitChoix_ViewModel.ClickBTNProduit -= ChoixProduit_Clik_Action;
            MenuTop_ViewModel.MenuTop_CouleursForm_ViewModel.VueEnsemble += VueEnsemble_Clik_Action;
        }

        public void Refresh()
        {
            DeconnectView();
            ConnectView();
        }

        private void VueEnsemble_Clik_Action(object sender, EventArgs args)
        {
            EspaceTravail_ViewModel.RefreshVueGraph("","ENSEMBLE");
        }
    }
}
