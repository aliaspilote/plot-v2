///////////////////////////////////////////////////////////
//  Sauvegarde.cs
//  Implementation of the Class Sauvegarde
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Quentin
///////////////////////////////////////////////////////////




using Modelisator.Model;
namespace Modelisator.Model {
	public class Sauvegarde {

		private string Chemin{
			//read property
			get{;}
			//write property
			set{;}
		}
		private date Date{
			//read property
			get{;}
			//write property
			set{;}
		}
		private string Nom{
			//read property
			get{;}
			//write property
			set{;}
		}
		public Produit m_Produit;

		public Sauvegarde(){

		}

		~Sauvegarde(){

		}

		public virtual void Dispose(){

		}

		public string Chemin{
			get{
				return Chemin;
			}
			set{
				Chemin = value;
			}
		}

		public date Date{
			get{
				return Date;
			}
			set{
				Date = value;
			}
		}

		public void export(){

		}

		public void import(){

		}

		public string Nom{
			get{
				return Nom;
			}
			set{
				Nom = value;
			}
		}

	}//end Sauvegarde

}//end namespace Modelisator.Model