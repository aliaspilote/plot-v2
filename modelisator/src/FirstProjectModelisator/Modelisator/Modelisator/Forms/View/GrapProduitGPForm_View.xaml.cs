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
using Microsoft.Msagl;
using Microsoft.Msagl.Drawing;

namespace Modelisator.Forms.View
{
    /// <summary>
    /// Logique d'interaction pour GrapProduitGPForm_View.xaml
    /// </summary>
    public partial class GrapProduitGPForm_View : UserControl
    {
        public GrapProduitGPForm_View()
        {
            InitializeComponent();

            Graph graph = new Graph("graph");
            graph.AddEdge("Pression", "Temperatue");
            graph.AddEdge("Temperatue", "Masse");
            graph.AddEdge("Pression", "Objet");
            graph.AddEdge("Masse", "33");
            graph.AddEdge("9", "42");
            graph.Attr.Color = Microsoft.Msagl.Drawing.Color.AliceBlue;
            this.gViewer.Graph = graph;

        }
    }
}
