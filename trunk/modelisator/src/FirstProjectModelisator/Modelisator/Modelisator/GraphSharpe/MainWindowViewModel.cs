using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelisator.Model;


namespace Modelisator.GraphSharpe
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Data
        private string layoutAlgorithmType;
        private PocGraph graph;
        private List<String> layoutAlgorithmTypes = new List<string>();
        #endregion

        #region Ctor
        public MainWindowViewModel()
        {
            Graph = new PocGraph(true);

            Produit.InitialiserGPs();
            List<PocVertex> existingVertices = new List<PocVertex>();
            existingVertices.Add(new PocVertex(Produit.GrandeurPhysiques["p"])); //0
            existingVertices.Add(new PocVertex(Produit.GrandeurPhysiques["X1"])); //1
            existingVertices.Add(new PocVertex(Produit.GrandeurPhysiques["Tmax"])); //2
            existingVertices.Add(new PocVertex(Produit.GrandeurPhysiques["p0"])); //3
            existingVertices.Add(new PocVertex(Produit.GrandeurPhysiques["dV"])); //4

            //existingVertices.Add(new PocVertex("Sacha Barber", true)); //0
            //existingVertices.Add(new PocVertex("Sarah Barber", false)); //1
            //existingVertices.Add(new PocVertex("Marlon Grech", true)); //2
            //existingVertices.Add(new PocVertex("Daniel Vaughan", true)); //3
            //existingVertices.Add(new PocVertex("Bea Costa", false)); //4

            foreach (PocVertex vertex in existingVertices)
                Graph.AddVertex(vertex);

            //add some edges to the graph
            AddNewGraphEdge(existingVertices[0], existingVertices[1]);
            AddNewGraphEdge(existingVertices[0], existingVertices[2]);
            AddNewGraphEdge(existingVertices[0], existingVertices[3]);
            AddNewGraphEdge(existingVertices[0], existingVertices[4]);

            AddNewGraphEdge(existingVertices[1], existingVertices[0]);
            AddNewGraphEdge(existingVertices[1], existingVertices[2]);
            AddNewGraphEdge(existingVertices[1], existingVertices[3]);

            AddNewGraphEdge(existingVertices[2], existingVertices[0]);
            AddNewGraphEdge(existingVertices[2], existingVertices[1]);
            AddNewGraphEdge(existingVertices[2], existingVertices[3]);
            AddNewGraphEdge(existingVertices[2], existingVertices[4]);

            AddNewGraphEdge(existingVertices[3], existingVertices[0]);
            AddNewGraphEdge(existingVertices[3], existingVertices[1]);
            AddNewGraphEdge(existingVertices[3], existingVertices[3]);
            AddNewGraphEdge(existingVertices[3], existingVertices[4]);

            AddNewGraphEdge(existingVertices[4], existingVertices[0]);
            AddNewGraphEdge(existingVertices[4], existingVertices[2]);
            AddNewGraphEdge(existingVertices[4], existingVertices[3]);

            string edgeString = string.Format("{0}-{1} Connected", 
                existingVertices[0].ID, existingVertices[0].ID);
            Graph.AddEdge(new PocEdge(edgeString, existingVertices[0], existingVertices[1]));
            Graph.AddEdge(new PocEdge(edgeString, existingVertices[0], existingVertices[1]));
            Graph.AddEdge(new PocEdge(edgeString, existingVertices[0], existingVertices[1]));
            Graph.AddEdge(new PocEdge(edgeString, existingVertices[0], existingVertices[1]));

            //Add Layout Algorithm Types
            layoutAlgorithmTypes.Add("BoundedFR");
            layoutAlgorithmTypes.Add("Circular");
            layoutAlgorithmTypes.Add("CompoundFDP");
            layoutAlgorithmTypes.Add("EfficientSugiyama");
            layoutAlgorithmTypes.Add("FR");
            layoutAlgorithmTypes.Add("ISOM");
            layoutAlgorithmTypes.Add("KK");
            layoutAlgorithmTypes.Add("LinLog");
            layoutAlgorithmTypes.Add("Tree");

            //Pick a default Layout Algorithm Type
            LayoutAlgorithmType = "LinLog";

        }
        #endregion

        #region Private Methods
        private PocEdge AddNewGraphEdge(PocVertex from, PocVertex to)
        {
            string edgeString = string.Format("{0}-{1} Connected", from.ID, to.ID);

            PocEdge newEdge = new PocEdge(edgeString, from, to);
            Graph.AddEdge(newEdge);
            return newEdge;
        }

        #endregion

        #region Public Properties

        public List<String> LayoutAlgorithmTypes
        {
            get { return layoutAlgorithmTypes; }
        }

        public string LayoutAlgorithmType
        {
            get { return layoutAlgorithmType; }
            set
            {
                layoutAlgorithmType = value;
                NotifyPropertyChanged("LayoutAlgorithmType");
            }
        }

        public PocGraph Graph
        {
            get { return graph; }
            set
            {
                graph = value;
                NotifyPropertyChanged("Graph");
            }
        }
        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion
    }
}