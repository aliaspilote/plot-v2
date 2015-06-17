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
    public class ab
    {
        public ab (string ab)
        {
            a = ab;
        }
        public string a;
        public override string ToString()
        {
            return a;
        }
    }

    public class ad
    {
        public List<ab> ListeTest;
        public ad ()
        {
            ListeTest = new List<ab>();
            ListeTest.Add(new ab("tu es la"));
            ListeTest.Add(new ab("tu es la"));
            ListeTest.Add(new ab("tu es la"));
            ListeTest.Add(new ab("tu es la"));
            ListeTest.Add(new ab("tu es la"));
            ListeTest.Add(new ab("tu es la"));
        }
    }
    public partial class Object_List_UserControl : UserControl
    {
        public ad Model;
        public Object_List_UserControl()
        {
            InitializeComponent();
            Model = new ad();
            this.DataContext = Model;
        }
    }
}
