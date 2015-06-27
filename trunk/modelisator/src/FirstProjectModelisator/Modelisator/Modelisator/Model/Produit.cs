///////////////////////////////////////////////////////////
//  Produit.cs
//  Implementation of the Class Produit
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;



namespace Modelisator.Model {
	public class Produit {

        static public Dictionary<string, GrandeurPhysique> GrandeurPhysiques;

        private string  m_Description;
        private string  m_Nom;
        private bool    m_Selectionner;

		public Produit()
        {
		    if (GrandeurPhysiques == null)
		    {
		        InitialiserGPs();
                GrandeurPhysiques = new Dictionary<string, GrandeurPhysique>();
		    }
        }
        public Produit(string nom)
        {
            Nom = nom;
            if (GrandeurPhysiques == null)
            {
                //InitialiserGPs();
                GrandeurPhysiques = new Dictionary<string, GrandeurPhysique>();
            }
        }

		public string Description{
			get{
                return m_Description;
			}
			set{
                m_Description = value;
			}
		}

		public string Nom{
			get{
                return m_Nom;
			}
			set{
                m_Nom = value;
			}
		}

		public bool Selectionner{
			get{
                return m_Selectionner;
			}
			set{
                m_Selectionner = value;
			}
		}

	    public override string ToString()
	    {
            return Nom;
	    }

	    public void InitialiserGPs()
	    {
            GrandeurPhysiques.Add("p", new GrandeurPhysique("p",0));
            GrandeurPhysiques.Add("X1", new GrandeurPhysique("X1",1));
            GrandeurPhysiques.Add("Tmax", new GrandeurPhysique("Tmax",2));
            GrandeurPhysiques.Add("p0", new GrandeurPhysique("p0",3));
            GrandeurPhysiques.Add("dV", new GrandeurPhysique("dV",4));
            GrandeurPhysiques.Add("alpha_gas", new GrandeurPhysique("alpha_gas",5));
            GrandeurPhysiques.Add("sigma", new GrandeurPhysique("sigma",6));
            GrandeurPhysiques.Add("R", new GrandeurPhysique("R",7));
            GrandeurPhysiques.Add("t", new GrandeurPhysique("t",8));
            GrandeurPhysiques.Add("tu", new GrandeurPhysique("tu",1));
            GrandeurPhysiques.Add("p", new GrandeurPhysique("p",1));
            GrandeurPhysiques.Add("p", new GrandeurPhysique("p",1));
	    }

	}//end Produit

}//end namespace Modelisator.Model