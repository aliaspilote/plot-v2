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
using MahApps.Metro.Controls;
using Modelisator.View;

namespace Modelisator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainContentPage.Content = new Auth_View_UserControl();
            MainContentPage.Content = new Object_List_UserControl();
        }

        ContentControl MainContentPage
        {
            get { return m_MainContentPage; }
            set { m_MainContentPage = value; }
        }

    }

  
}
