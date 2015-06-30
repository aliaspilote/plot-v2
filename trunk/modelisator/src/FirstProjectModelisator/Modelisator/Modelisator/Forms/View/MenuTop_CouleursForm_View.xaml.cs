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

namespace Modelisator.Forms.View
{
    /// <summary>
    /// Logique d'interaction pour MenuTop_CouleursForm_View.xaml
    /// </summary>
    public partial class MenuTop_CouleursForm_View : UserControl
    {
        public MenuTop_CouleursForm_View()
        {
            InitializeComponent();
        }
        
        public ComboBox cmdBoxCouleurs
        {
            get { return m_cmdBoxCouleurs; }
            set { m_cmdBoxCouleurs = value; }
        }

        public Button btn_Import
        {
            get { return m_btn_Import; }
            set { m_btn_Import = value; }
        }

        public Button brn_Export
        {
            get { return m_btn_Export; }
            set { m_btn_Export = value; }
        }
    }
}
