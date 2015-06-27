using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;
using Modelisator.Model;

namespace Modelisator.Forms.ViewModel
{
    public class MenuTop_CouleursForm_ViewModel
    {
        public event EventHandler<EventArgs> OKCOULEUR;


        public MenuTop_CouleursForm_ViewModel()
        { }
        public MenuTop_CouleursForm_ViewModel(Contexte ctx)
        {
            View = new MenuTop_CouleursForm_View();
            Model = new MenuTop_CouleursForm_Model(ctx);
            Setup_MenuTop_CouleursForm();
            ConnectView(); 
        }

        protected void ConnectView()
        {
            View.cmdBoxCouleurs.SelectionChanged += Couleurclick;
        }
        public MenuTop_CouleursForm_View View
        {
            get;
            private set;
        }
        public MenuTop_CouleursForm_Model Model
        {
            get;
            private set;
        }

        protected void Couleurclick(object sender, RoutedEventArgs e)
        {
            Model.laCouleurchoisie((PropertyInfo)View.cmdBoxCouleurs.SelectedValue);
            if (OKCOULEUR != null)
                OKCOULEUR(this, e);
        }

        protected void Setup_MenuTop_CouleursForm()
        {
            View.cmdBoxCouleurs.DataContext = Model.lesCouleurs;
            View.cmdBoxCouleurs.SelectedIndex = 1;

        }
    }
}
