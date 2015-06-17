using Modelisator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modelisator.View
{
    /// <summary>
    /// Logique d'interaction pour Auth_View_UserControl.xaml
    /// </summary>
    public partial class Auth_View_UserControl : UserControl
    {
        Auth_Model View_Model;

        public Auth_View_UserControl()
        {
            InitializeComponent();
            View_Model = new Auth_Model();
        }
        private void ConnecterClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(View_Model.ClickConnect());
        }

        private void ClickBoutonAnnuler(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
