///////////////////////////////////////////////////////////
//  Contexte.cs
//  Implementation of the Class Contexte
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Omar
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;

namespace Modelisator.Model {
	public class Contexte {

		public Contexte(){
            ListeProduits = new List<Produit>();
        }

        Utilisateur m_user;

        public Utilisateur User
        {
            get
            {
                return m_user;
            }
            set
            {
                m_user = value;
            }
        }

        public List<Produit> ListeProduits;


	}//end Contexte

}//end namespace Modelisator.Model