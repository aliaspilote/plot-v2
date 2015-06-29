using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;

namespace Modelisator.MonGraphX
{
    public class MonGraph_Model
    {
        public GraphAreaExample Graph;

        public Contexte ctx;

        public MonGraph_Model(Contexte Ctx)
        {
            Ctx = Ctx;
        }

        public GraphExample Graph_Setup()
        {
            var dataGraph = new GraphExample();
            foreach (var GP in Produit.GrandeurPhysiques)
            {
                var dataVertex = new DataVertex(GP.Key);

                dataGraph.AddVertex(dataVertex);
            }
            Relation.EnnumRelation();
            //Now lets make some edges that will connect our vertices
            //get the indexed list of graph vertices we have already added
            var vlist = dataGraph.Vertices.ToList();
            var dataEdge = new DataEdge(); //= new DataEdge(vlist[0], vlist[1]);
            //dataGraph.AddEdge(dataEdge);
            foreach (var R1 in vlist)
            {
                foreach (var R2 in vlist)
                {
                    if (Relation.MatriceRelations[Produit.GrandeurPhysiques[R1.Text].iM][
                            Produit.GrandeurPhysiques[R2.Text].iM] != null)
                        if (Relation.MatriceRelations[Produit.GrandeurPhysiques[R1.Text].iM][
                            Produit.GrandeurPhysiques[R2.Text].iM] !=1 -1)
                            {
                                dataEdge = new DataEdge(R1, R2);
                                dataGraph.AddEdge(dataEdge);
                            }

               }
            }

            return dataGraph;
        }
    }
}
