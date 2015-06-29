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
    /// Logique d'interaction pour MenuTop_StatutForm_View.xaml
    /// </summary>
    public partial class MenuTop_StatutForm_View : UserControl
    {
        public MenuTop_StatutForm_View()
        {
            InitializeComponent();
        }
        public Grid Grid_MenuTop_StatutForm
        {
            get { return m_Grid_MenuTop_StatutForm; }
            set { m_Grid_MenuTop_StatutForm = value; }
        }
        public StackPanel StackPanel_StatutForm
        {
            get { return m_StackPanel_StatutForm; }
            set { m_StackPanel_StatutForm = value; }
        }
        public Label LabelNomUtil_MenuTop_StatutForm
        {
            get { return m_LabelNomUtil_MenuTop_StatutForm; }
            set { m_LabelNomUtil_MenuTop_StatutForm = value; }
        }
        public Label LabelMid_MenuTop_StatutForm
        {
            get { return m_LabelMid_MenuTop_StatutForm; }
            set { m_LabelMid_MenuTop_StatutForm = value; }
        }
        public Label LabelRole_MenuTop_StatutForm
        {
            get { return m_LabelRole_MenuTop_StatutForm; }
            set { m_LabelRole_MenuTop_StatutForm = value; }
        }
        public Button BoutonDeconnexion_MenuTop_StatutForm
        {
            get { return m_BoutonDeconnexion_MenuTop_StatutForm; }
            set { m_BoutonDeconnexion_MenuTop_StatutForm = value; }
        }
    }
}
