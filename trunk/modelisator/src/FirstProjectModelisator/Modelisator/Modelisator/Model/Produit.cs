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
        private bool    m_Selectionne;

		public Produit()
        {
            GrandeurPhysiques = new Dictionary<string, GrandeurPhysique>();
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

		public bool Selectionne{
			get{
                return m_Selectionne;
			}
			set{
                m_Selectionne = value;
			}
		}

	}//end Produit

}//end namespace Modelisator.Model