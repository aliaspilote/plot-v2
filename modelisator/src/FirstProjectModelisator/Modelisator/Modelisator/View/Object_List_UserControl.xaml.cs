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
    /// Logique d'interaction pour Object_List_UserControl.xaml
    /// </summary>
    /// 
    public class objettest
    {
        public objettest(string ab)
        {
            a = ab;
        }
        public string a;
        public override string ToString()
        {
            return a;
        }
    }

    public class modeltest
    {
        public List<objettest> ListeTest;
        public modeltest ()
        {
            ListeTest = new List<objettest>();
            ListeTest.Add(new objettest("AAAAAAA"));
            ListeTest.Add(new objettest("BBBBB"));
            ListeTest.Add(new objettest("DDDDDDDDDDDDD"));
            ListeTest.Add(new objettest("BBBBB"));
            ListeTest.Add(new objettest("DDDDDDDDDDDDD"));
            ListeTest.Add(new objettest("BBBBB"));
            ListeTest.Add(new objettest("DDDDDDDDDDDDD"));
            ListeTest.Add(new objettest("BBBBB"));
            ListeTest.Add(new objettest("DDDDDDDDDDDDD"));
        }
        public override string ToString()
        {
            return "bbbb";
        }
    }
    public partial class Object_List_UserControl : UserControl
    {
        public modeltest Model;
        public Object_List_UserControl()
        {
            InitializeComponent();
            Model = new modeltest();
            this.DataContext = Model.ListeTest;
        }
    }
}
