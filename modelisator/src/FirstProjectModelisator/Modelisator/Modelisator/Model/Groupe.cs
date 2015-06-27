///////////////////////////////////////////////////////////
//  Groupe.cs
//  Implementation of the Class Groupe
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
	public class Groupe {

        private string m_Nom;

        public Groupe() { }
        public Groupe(string nom) {
            Nom = nom;
        }

		public string Nom{
			get{
				return m_Nom;
			}
			set{
				m_Nom = value;
			}
		}

	    public override string ToString()
	    {
            return Nom;
	    }
	}//end Groupe

}//end namespace Modelisator.Model