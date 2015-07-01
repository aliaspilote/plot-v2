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
        public event EventHandler<EventArgs> VueEnsemble;


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
            View.btn_Export.Click += Export_click;
            View.btn_Import.Click += Import_click;
            View.btn_VueEnsemble.Click += VueEnsemble_click;
            View.btn_RAZ_GP.Click += RAZ_GP_click;
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

        protected void VueEnsemble_click(object sender, RoutedEventArgs e)
        {
            if (VueEnsemble != null)
                VueEnsemble(this, e);
        }

        protected void Export_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog1.Filter = "CSV Files|*.csv";
            saveFileDialog1.Title = "Exporter l'espace de travail";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                string filename = saveFileDialog1.FileName;
                Sauvegarde.export(filename);
                MessageBox.Show("Export effectuer");
            }
            else
            {
                MessageBox.Show("Export annuler");
            }
        }

        protected void Import_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "CSV Files|*.csv";
            dlg.Title = "Importer l'espace de travail";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                Sauvegarde.import(filename);
                MessageBox.Show("Import effectuer");
            }
            else
            {
                MessageBox.Show("Import annuler");
            }
        }

        protected void RAZ_GP_click(object sender, RoutedEventArgs e)
        {
            Model.RAZ_GP_valeur();
            MessageBox.Show("Remise à zéro de la valeur des grandeurs physiques.");
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
