///////////////////////////////////////////////////////////
//  Sauvegarde.cs
//  Implementation of the Class Sauvegarde
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Quentin
///////////////////////////////////////////////////////////
using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using System.IO;

namespace Modelisator.Model {
	public class Sauvegarde {

        private string      m_Chemin;
        private DateTime    m_Date;
        private string      m_Nom;

		public Produit m_Produit;

		public Sauvegarde(){		}

		public string Chemin{
			get{
                return m_Chemin;
			}
			set{
                m_Chemin = value;
			}
		}

        public DateTime Date
        {
			get{
                return m_Date;
			}
			set{
                m_Date = value;
			}
		}

		public void export()
        {
            string text;


            StreamWriter sw = new StreamWriter(m_Chemin);//cr�ation du fichier 
            foreach (GrandeurPhysique gp in m_Produit.GrandeurPhysiques)
            {

                text = gp.Nom + ";" + gp.Unite + ";" + gp.Valeur + ";" + gp.Description + ";" + gp.Calcule + ";" + gp.Selectionne + ";" + gp.EstPremier;
                sw.WriteLine("{0}", text);//enregistrement de la liste GP dans le fichier 
            }

            sw.Close();


		}

        public void import()
        {
            List<GrandeurPhysique> liste = new List<GrandeurPhysique>();
            var reader = new StreamReader(File.OpenRead(m_Chemin));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                GrandeurPhysique gp = new GrandeurPhysique();
                gp.Nom=values[0];
                gp.Unite = values[1];
                gp.Valeur=Convert.ToDouble(values[2]);
                gp.Description=values[3];
                gp.Calcule=Convert.ToBoolean(values[4]);
                gp.Selectionne=Convert.ToBoolean(values[5]);
                gp.EstPremier=Convert.ToBoolean(values[6]);
                liste.Add(gp);
            }
            m_Produit.GrandeurPhysiques = liste;

        }

		public string Nom{
			get{
                return m_Nom;
			}
			set{
                m_Nom = value;
			}
		}

	}//end Sauvegarde

}//end namespace Modelisator.Model