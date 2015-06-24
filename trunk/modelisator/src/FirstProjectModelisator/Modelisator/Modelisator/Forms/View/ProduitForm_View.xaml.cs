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
        }
        public Label LabelProduitForm
        {
            get { return m_LabelProduitForm; }
            set { m_LabelProduitForm = value; }
        }
        public Rectangle RectangleProduitForm
        {
            get { return m_RectangleProduitForm; }
            set { m_RectangleProduitForm = value; }
        }
        public Grid GridProduitForm
        {
            get { return m_GridProduitForm; }
            set { m_GridProduitForm = value; }
        }

    }
}
