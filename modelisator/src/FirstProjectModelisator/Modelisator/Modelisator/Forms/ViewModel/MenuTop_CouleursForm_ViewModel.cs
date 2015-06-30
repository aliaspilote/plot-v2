using System;
using System.Collections.Generic;
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
        public event EventHandler<EventArgs> Import_Ev;
        public event EventHandler<EventArgs> Export_Ev;


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
            View.brn_Export.Click += Export_click;
            View.btn_Import.Click += Import_click;
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

        protected void Export_click(object sender, RoutedEventArgs e)
        {
            //Choix 1
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "CSV Files|*.csv";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                MessageBox.Show(filename);
            }
            //Appel de la méthode I/E

            //Choix 2
            if (Export_Ev != null)
                Export_Ev(this, e);
        }

        protected void Import_click(object sender, RoutedEventArgs e)
        {
            //Choix 1

            //Appel de la méthode I/E

            //Choix 2   Remonter l'"evenement au controleur supèrier
            if (Import_Ev != null)
                Import_Ev(this, e);
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
