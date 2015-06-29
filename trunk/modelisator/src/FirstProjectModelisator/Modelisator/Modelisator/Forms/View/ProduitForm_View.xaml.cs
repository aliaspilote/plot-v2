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
using Modelisator.Model;

namespace Modelisator.Forms.View
{
    /// <summary>
    /// Logique d'interaction pour ProduitForm_View.xaml
    /// </summary>
    public partial class ProduitForm_View : UserControl
    {
        public ProduitForm_View()
        {
            InitializeComponent();
            Items = new List<Produit>();
        }
        public Label Label_ProduitForm
        {
            get { return m_Label_ProduitForm; }
            set { m_Label_ProduitForm = value; }
        }
        public Grid Grid_ProduitForm
        {
            get { return m_Grid_ProduitForm; }
            set { m_Grid_ProduitForm = value; }
        }

        public static readonly DependencyProperty ItemsProperty =
          DependencyProperty.Register("Items", typeof(IEnumerable<Produit>), 
          typeof(ProduitForm_View), 
          new PropertyMetadata(new List<Produit>()));

        public IEnumerable<Produit> Items
        {
            get { return (IEnumerable<Produit>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        } 

    }
}
