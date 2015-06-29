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

namespace Modelisator.View
{
    /// <summary>
    /// Logique d'interaction pour MenuTop_View_UserControl.xaml
    /// </summary>
    public partial class MenuTop_View_UserControl : UserControl
    {
        public MenuTop_View_UserControl()
        {
            InitializeComponent();
        }
        //m_GridMenuTop
        public Grid GridMenuTop
        {
            get { return m_GridMenuTop; }
            set { m_GridMenuTop = value; }
        }
        public Grid MenuTopLeft_ContentPanel
        {
            get { return m_MenuTopLeft_ContentPanel; }
            set { m_MenuTopLeft_ContentPanel = value; }
        }
        public Grid MenuTopCenter_ContentPanel
        {
            get { return m_MenuTopCenter_ContentPanel; }
            set { m_MenuTopCenter_ContentPanel = value; }
        }

        public Grid MenuTopRight_ContentPanel
        {
            get { return m_MenuTopRight_ContentPanel; }
            set { m_MenuTopRight_ContentPanel = value; }
        }
    }
}
