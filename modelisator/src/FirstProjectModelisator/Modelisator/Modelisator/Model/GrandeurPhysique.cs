///////////////////////////////////////////////////////////
//  GrandeurPhysique.cs
//  Implementation of the Class GrandeurPhysique
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
	public class GrandeurPhysique {

		private bool    m_Calcule;
		private string  m_Description;
		private bool    m_EstPremier;
		private string  m_Nom;
		private bool    m_Selectionne;
		private string  m_Unite;
		private double  m_Valeur;


        public  List<Equation> Equations;

		public GrandeurPhysique(){		}


		public bool Calcule{
			get{
                return m_Calcule;
			}
			set{
                m_Calcule = value;
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

		public bool     EstPremier{
			get{
                return m_EstPremier;
			}
			set{
                m_EstPremier = value;
			}
		}

		public string   Nom{
			get{
                return m_Nom;
			}
			set{
                m_Nom = value;
			}
		}

		public bool     Selectionne{
			get{
				return m_Selectionne;
			}
			set{
				m_Selectionne = value;
			}
		}

		public string   Unite{
			get{
				return m_Unite;
			}
			set{
				m_Unite = value;
			}
		}

		public double   Valeur{
			get{
				return m_Valeur;
			}
			set{
				m_Valeur = value;
			}
		}


	}//end GrandeurPhysique

}//end namespace Modelisator.Model