﻿using System;
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

            Graph hiba = new Graph();
            hiba.AddEdge("Gaz", "P");
            hiba.AddEdge("Gaz", "n");
            hiba.AddEdge("Gaz", "V");
            hiba.AddEdge("Gaz", "n");
            hiba.AddEdge("Gaz", "R");
            hiba.AddEdge("Gaz", "T");
            hiba.AddEdge("P", "V");
            hiba.AddEdge("V", "P");
            hiba.AddEdge("V", "T");
            hiba.AddEdge("T", "V");
            hiba.AddEdge("T", "n");
            hiba.AddEdge("n", "T");
            this.gViewer.Graph = hiba;

        }
    }
}
