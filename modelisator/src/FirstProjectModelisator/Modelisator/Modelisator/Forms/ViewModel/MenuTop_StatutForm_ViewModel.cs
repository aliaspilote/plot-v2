using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;
using Modelisator.Model;

namespace Modelisator.Forms.ViewModel
{
    public class MenuTop_StatutForm_ViewModel
    {
        public event EventHandler<EventArgs> DeconnecterHandler;

        public MenuTop_StatutForm_ViewModel()
        { }
        public MenuTop_StatutForm_ViewModel(Contexte ctx)
        {
            View = new MenuTop_StatutForm_View();
            Model = new MenuTop_StatutForm_Model(ctx);
            SetupMenuTopStatutForm();
            ConnectView();
        }
        protected void ConnectView()
        {
            View.BoutonDeconnexion_MenuTop_StatutForm.Click += DecoBtnClick;
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

        protected void DecoBtnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.
                Show("Êtes vous sur de vouloir vous déconnecter ?", 
                    "Déconnexion : Confirmation", 
                    System.Windows.MessageBoxButton.YesNo
                    );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (DeconnecterHandler != null)
                    DeconnecterHandler(this, EventArgs.Empty);
            }
        }

        protected void SetupMenuTopStatutForm()
        {
            View.LabelNomUtil_MenuTop_StatutForm.DataContext = Model.Utilisateur_ctx;
            View.LabelRole_MenuTop_StatutForm.DataContext = Model.Utilisateur_ctx;
            //ProduitChoix_ViewModel = new ProduitChoix_ViewModel(Ctx);

            //View.MenuTop_ContentPanel.Children.Add(MenuTop_ViewModel.View);
            //View.ProduitChoix_ItemsControl.DataContext 

        }
    }
}
