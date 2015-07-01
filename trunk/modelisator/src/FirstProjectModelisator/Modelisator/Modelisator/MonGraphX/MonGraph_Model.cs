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

        public GraphExample Graph_Setup(string FOCUS = "")
        {
            if (Produit.GrandeurPhysiques == null)
                return null;

            var dataGraph = new GraphExample();
            if (FOCUS == "FOCUS")
            {
                foreach (var GP in Produit.GrandeurPhysiques)
                {
                    if (GP.Value.Selectionne)
                    {
                        var dataVertex = new DataVertex(GP.Key);
                        dataGraph.AddVertex(dataVertex);
                    }
                }  
            }
            else
            {
              foreach (var GP in Produit.GrandeurPhysiques)
                {
                    //if (GP.Value.EstPremier)
                    //{
                        var dataVertex = new DataVertex(GP.Key);
                        dataGraph.AddVertex(dataVertex);
                    //}
                }  
            }
            
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

        public void CalculerRelation(GrandeurPhysique depart)
        {
            int indiceEquation = 0;
            foreach (var Arrivee in Produit.GrandeurPhysiques)
            {
                indiceEquation = Relation.MatriceRelations[depart.iM][Arrivee.Value.iM];
                if (indiceEquation != 0)
                    Equation.Calculer(indiceEquation);
            }
            indiceEquation = 0;
            foreach (var Arrivee in Produit.GrandeurPhysiques)
            {
                indiceEquation = Relation.MatriceRelations[Arrivee.Value.iM][depart.iM];
                if (indiceEquation != 0)
                    Equation.Calculer(indiceEquation);
            }
        }

        public void RAZselectionGP()
        {
            var uneRelation = 0;
            foreach (var GP_RAZ in Produit.GrandeurPhysiques)
            {
                GP_RAZ.Value.Selectionne = false;
                GP_RAZ.Value.FocusOn = false;
            }

        }

        public void InitialiserVoisinFocuGP(GrandeurPhysique GPfocus)
        {
            GPfocus.Selectionne = true;
            GPfocus.FocusOn = true;

            foreach (var GP_Selec in Produit.GrandeurPhysiques)
            {
                int uneRelation = Relation.MatriceRelations[GPfocus.iM][GP_Selec.Value.iM];
                if (uneRelation != 0)
                    GP_Selec.Value.Selectionne = true;
            }
        }

       
    }
}
