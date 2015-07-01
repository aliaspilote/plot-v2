using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Modelisator.Model;

namespace Modelisator.MonGraphX
{
    public class MonGraph_ViewModel
    {
        public MouseEventHandler FocusGraph;

        public event PropertyChangedEventHandler EventSaisie;

        public MonGraph_ViewModel(Contexte ctx)
        {
            View = new MonGraph_UserControl();
            Model = new MonGraph_Model(ctx);
            SetupView();
            ConnectView(); 
        }

        public void ConnectView()
        {
            View.SelectionGP += FocusGP;
            foreach (var GP in Produit.GrandeurPhysiques)
            {
                GP.Value.PropertyChanged += GP_PropertyChanged;
            }
        }
        

        private void FocusGP(object sender, MouseEventArgs e)
        {
            PreapationGPselectionnee(((TextBlock)e.Source).Text);
            if (FocusGraph != null)
                FocusGraph(this, e);
        }

        private void GP_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //  Nom du noeud modifié            ((GrandeurPhysique)sender).Nom  
            //  Nom de la propriété modifier    e.PropertyName
            if (e.PropertyName=="Valeur")
                Model.CalculerRelation(((GrandeurPhysique)sender));
        }

        public void PreapationGPselectionnee(string GPnom)
        {
            Model.RAZselectionGP();
            if (GPnom!="")
            Model.InitialiserVoisinFocuGP(Produit.GrandeurPhysiques[GPnom]);
        }

        public void SetupView()
        {

        }
        public MonGraph_UserControl View
        {
            get;
            set;
        }
        public MonGraph_Model Model
        {
            get;
            set;
        }


    }

}
