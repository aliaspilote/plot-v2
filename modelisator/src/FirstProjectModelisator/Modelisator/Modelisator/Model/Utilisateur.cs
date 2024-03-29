///////////////////////////////////////////////////////////
//  Utilisateur.cs
//  Implementation of the Class Utilisateur
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
///////////////////////////////////////////////////////////
using System;
using System.Timers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;


namespace Modelisator.Model {
	public class Utilisateur {

        private Groupe m_Groupe;
        private string m_MotDePasse;
        private string m_Nom;


        public Utilisateur()
        {

        }

        public Utilisateur(string nom, Groupe grp)
        {
            m_Groupe = grp;
            m_Nom = nom;
        }

		public Groupe Groupe{
			get{
                return m_Groupe;
			}
			set{
                m_Groupe = value;
			}
		}

		public string MotDePasse{
			get{
                return m_MotDePasse;
			}
			set{
                m_MotDePasse = value;
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

	}//end Utilisateur

}//end namespace Modelisator.Model