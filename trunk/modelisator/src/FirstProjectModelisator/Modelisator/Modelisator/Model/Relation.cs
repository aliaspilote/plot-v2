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


        void EnnumRelation()
        {
            GrandeurPhysique gp1 = new GrandeurPhysique("GRP1");
            GrandeurPhysique gp2 = new GrandeurPhysique("GRP2");
            GrandeurPhysique gp3 = new GrandeurPhysique("GRP3");
            GrandeurPhysique gp4 = new GrandeurPhysique("GRP4");
            GrandeurPhysique gp5 = new GrandeurPhysique("GRP5");
            GrandeurPhysique gp6 = new GrandeurPhysique("GRP6");
            GrandeurPhysique gp7 = new GrandeurPhysique("GRP7");
            GrandeurPhysique gp0 = new GrandeurPhysique("GRP0");

            Dictionary<GrandeurPhysique, int> GP_Ennum = new Dictionary<GrandeurPhysique, int>();

            GP_Ennum.Add(gp0, 0);
            GP_Ennum.Add(gp1, 1);
            GP_Ennum.Add(gp2, 2);
            GP_Ennum.Add(gp3, 3);
            GP_Ennum.Add(gp4, 4);
            GP_Ennum.Add(gp5, 5);
            GP_Ennum.Add(gp6, 6);

            int[][] Matricerelations = new int[GP_Ennum.Count()][];
            for ( int i = 0; i < GP_Ennum.Count(); i++ )
            {
                    Matricerelations[i] = new int[GP_Ennum.Count()];
            }

            Matricerelations[0][0] = 0;
            Matricerelations[0][1] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
            Matricerelations[0][0] = 0;
        }

	}//end Relation

}//end namespace Modelisator.Model