using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Modelisator.Model;

namespace Modelisator.MonGraphX
{
    public class MonGraph_ViewModel
    {

        public event PropertyChangedEventHandler EventSaisie;

        public MonGraph_ViewModel(Contexte ctx)
        {
            View = new MonGraph_UserControl();
            Model = new MonGraph_Model(ctx);
            SetupView();
            ConnectView(); 
        }

        protected void ConnectView()
        {
            foreach (var GP in Produit.GrandeurPhysiques)
            {
                GP.Value.PropertyChanged += ValurGP_PropertyChanged;
            }
        }

        private void ValurGP_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            MessageBox.Show("Et voila, Noeud '"+ ((GrandeurPhysique)sender).Nom+"' saisi, reste plus qu'a calculer");
        }

        protected void SetupView()
        {

        }
        public MonGraph_UserControl View
        {
            get;
            private set;
        }
        public MonGraph_Model Model
        {
            get;
            private set;
        }


    }

}
