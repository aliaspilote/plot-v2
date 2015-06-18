///////////////////////////////////////////////////////////
//  Relation.cs
//  Implementation of the Class Relation
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Quentin
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;

namespace Modelisator.Model {
	public class Relation {

		private GrandeurPhysique m_Arrivee;

		private GrandeurPhysique m_Debut;

		public List<Equation> Equations;

        public List<GrandeurPhysique> GrandeurPhysiques;

		public Relation(){		}

		public GrandeurPhysique Arrivee{
			get{
                return m_Arrivee;
			}
			set{
                m_Arrivee = value;
			}
		}

		public GrandeurPhysique Debut{
			get{
                return m_Debut;
			}
			set{
                m_Debut = value;
			}
		}

	}//end Relation

}//end namespace Modelisator.Model