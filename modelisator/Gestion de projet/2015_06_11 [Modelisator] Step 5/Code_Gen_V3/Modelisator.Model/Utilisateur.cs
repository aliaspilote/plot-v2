///////////////////////////////////////////////////////////
//  Utilisateur.cs
//  Implementation of the Class Utilisateur
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
///////////////////////////////////////////////////////////




using Modelisator.Model;
namespace Modelisator.Model {
	public class Utilisateur {

		private Groupe Groupe{
			//read property
			get{;}
			//write property
			set{;}
		}
		private string MotDePasse{
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
		public Contexte m_Contexte;

		public Utilisateur(){

		}

		~Utilisateur(){

		}

		public virtual void Dispose(){

		}

		public Groupe Groupe{
			get{
				return Groupe;
			}
			set{
				Groupe = value;
			}
		}

		public string MotDePasse{
			get{
				return MotDePasse;
			}
			set{
				MotDePasse = value;
			}
		}

		public string Nom{
			get{
				return Nom;
			}
			set{
				Nom = value;
			}
		}

	}//end Utilisateur

}//end namespace Modelisator.Model