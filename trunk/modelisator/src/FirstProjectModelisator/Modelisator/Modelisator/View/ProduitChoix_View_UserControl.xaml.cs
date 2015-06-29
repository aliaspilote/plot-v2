using System;
using System.Collections.Generic;
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
using Modelisator.Forms.View;
using Modelisator.Model;

namespace Modelisator.View
{
    /// <summary>
    /// Logique d'interaction pour ProduitChoix_View_UserControl.xaml
    /// </summary>
    public partial class ProduitChoix_View_UserControl : UserControl
    {

        public event EventHandler<EventArgs> CatchClickBTNProduit;
        public ProduitChoix_View_UserControl()
        {
            InitializeComponent();
        }
        public ItemsControl ProduitChoix_ItemsControl
        {
            get { return m_ProduitChoix_ItemsControl; }
            set { m_ProduitChoix_ItemsControl = value; }
        }

        public Label labelListeProduit
        {
            get { return m_labelListeProduit; }
            set { m_labelListeProduit = value; }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (CatchClickBTNProduit != null)
                CatchClickBTNProduit(sender, e);
        }
    }
}
