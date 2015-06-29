using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Modelisator.Model;
using Modelisator.View;
using Modelisator.Forms.ViewModel;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;

namespace Modelisator.ViewModel
{
    public class MenuTop_ViewModel
    {
        public MenuTop_StatutForm_ViewModel MenuTopForm_ViewModel;
        public MenuTop_CouleursForm_ViewModel MenuTop_CouleursForm_ViewModel;
        public event EventHandler<EventArgs> OKCOULEUR;

        public MenuTop_ViewModel()
        {
        }

        public MenuTop_ViewModel(Contexte ctx)
        {
            View = new MenuTop_View_UserControl();
            Model = new MenuTop_Model(ctx);
            SetupMenuTopView(ctx);
        }

        public MenuTop_View_UserControl View { get; private set; }
        public MenuTop_Model Model { get; private set; }

        protected void SetupMenuTopView(Contexte Ctx)
        {
            MenuTopForm_ViewModel = new MenuTop_StatutForm_ViewModel(Ctx);
            View.MenuTopRight_ContentPanel.Children.Add(MenuTopForm_ViewModel.View);

            MenuTop_CouleursForm_ViewModel = new MenuTop_CouleursForm_ViewModel(Ctx);
            View.MenuTopCenter_ContentPanel.Children.Add(MenuTop_CouleursForm_ViewModel.View);

            MenuTop_CouleursForm_ViewModel.OKCOULEUR += OKTOP;
        }

        private void OKTOP(object sender, EventArgs args)
        {
            if (OKCOULEUR != null)
                OKCOULEUR(this, args);
        }


    } 
}
