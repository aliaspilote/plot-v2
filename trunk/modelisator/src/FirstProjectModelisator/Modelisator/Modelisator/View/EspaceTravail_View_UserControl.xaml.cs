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
    /// Logique d'interaction pour EspaceTravail_View_UserControl.xaml
    /// </summary>
    public partial class EspaceTravail_View_UserControl : UserControl
    {
        public EspaceTravail_View_UserControl()
        {
            InitializeComponent();
        }
        public Grid GridEspaceTravail
        {
            get { return m_GridEspaceTravail; }
            set { m_GridEspaceTravail = value; }
        }
        
    }
}
