///////////////////////////////////////////////////////////
//  Relation.cs
//  Implementation of the Class Relation
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Quentin
///////////////////////////////////////////////////////////




using Modelisator.Model;
namespace Modelisator.Model {
	public class Relation {

		private GrandeurPhysique Arrivee{
			//read property
			get{;}
			//write property
			set{;}
		}
		private GrandeurPhysique Debut{
			//read property
			get{;}
			//write property
			set{;}
		}
		public List<> m_Equation;
		public List<> m_GrandeurPhysique;

		public Relation(){

		}

		~Relation(){

		}

		public virtual void Dispose(){

		}

		public GrandeurPhysique Arrivee{
			get{
				return Arrivee;
			}
			set{
				Arrivee = value;
			}
		}

		public GrandeurPhysique Debut{
			get{
				return Debut;
			}
			set{
				Debut = value;
			}
		}

	}//end Relation

}//end namespace Modelisator.Model