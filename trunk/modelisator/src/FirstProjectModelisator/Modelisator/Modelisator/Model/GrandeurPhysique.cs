///////////////////////////////////////////////////////////
//  GrandeurPhysique.cs
//  Implementation of the Class GrandeurPhysique
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Modelisator.Model;

namespace Modelisator.Model {
    public class GrandeurPhysique : INotifyPropertyChanged
    {

        private int     m_iM;
        private bool    m_Calcule;
		private string  m_Description;
		private bool    m_EstPremier;
		private string  m_Nom;
		private bool    m_Selectionne;
		private string  m_Unite;
		private double  m_Valeur;
        private bool    m_entree;
        private string imageFullPath;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public  List<Equation> Equations;

        public GrandeurPhysique()
        {

            setCouleurs();
            setBouleans();
        }

	    public GrandeurPhysique(string nom)
	    {
	        Nom = nom;
            Unite = "[SI]";
            Description = "Description de la GP " + nom + " est ici.";
            setCouleurs();
            setBouleans();
	    }
        public GrandeurPhysique(string nom, int im)
        {
            Nom = nom;
            iM = im;
            Unite = "[SI]";
            Description = "Description de la GP " + nom + " est ici.";
            setCouleurs();
            setBouleans();
        }
        public GrandeurPhysique(string nom, int im, string dsc, bool premier)
        {
            Nom = nom;
            iM = im;
            Unite = "[SI]";
            Description = dsc;
            EstPremier = premier;
            setBouleans();
            setCouleurs();
        }

        public void setBouleans()
        {
            Calcule = false;
            Entree = false;
            FocusOn = false;
            Selectionne = false;
        }

        public void setCouleurs()
        {
            Calcule_Couleur_Font = new SolidColorBrush(Colors.DarkViolet);
            Entree_Couleur_Font = new SolidColorBrush(Colors.DarkGreen);
            Defaut_Couleur_Font = new SolidColorBrush(Colors.Black);
            Focus_Couleur_BackG = new SolidColorBrush(Colors.DodgerBlue);
            Defaut_Couleur_BackG = new SolidColorBrush(Colors.White);
        }
        private bool m_isCalculate;

        private bool m_isGiven;

        private bool m_focusOn;

        private SolidColorBrush m_CouleurNoeud;

        private SolidColorBrush m_CouleurBackG;

        static SolidColorBrush Calcule_Couleur_Font;
        static SolidColorBrush Entree_Couleur_Font;
        static SolidColorBrush Defaut_Couleur_Font;
        static SolidColorBrush Focus_Couleur_BackG;
        static SolidColorBrush Defaut_Couleur_BackG;

        public void rafraichirCouleur()
        {
            if (Calcule)
                CouleurNoeud = Calcule_Couleur_Font;
            else if (Entree)
                CouleurNoeud = Entree_Couleur_Font;
            else
                CouleurNoeud = Defaut_Couleur_Font;

            if (FocusOn)
                CouleurBackG = Focus_Couleur_BackG;
            else
                CouleurBackG = Defaut_Couleur_BackG;
        }

        public SolidColorBrush CouleurBackG
        {
            get
            {
                // rafraichirCouleur();
                return m_CouleurBackG;
            }
            set
            {
                m_CouleurBackG = value;
                OnPropertyChanged("CouleurBackG");
            }
        }

        public SolidColorBrush CouleurNoeud
        {
            get
            {
               // rafraichirCouleur();
                return m_CouleurNoeud;
            }
            set
            {
                m_CouleurNoeud = value;
                OnPropertyChanged("CouleurNoeud");
            }
        }
        
        public bool FocusOn
        {
            get
            {
                return m_focusOn;
            }
            set
            {
                m_focusOn = value;
                rafraichirCouleur();
            }
        } public bool Calcule
        {
            get
            {
                return m_isCalculate;
            }
            set
            {
                m_isCalculate = value;
                rafraichirCouleur();
            }
        }

        public bool Entree
        {
            get
            {
                return m_isGiven;
            }
            set
            {
                m_isGiven = value;
                rafraichirCouleur();
            }
        }

		public double   Valeur{
			get{
				return m_Valeur;
			}
			set
			{
			    Entree = true;
                if (value != m_Valeur)
                {
                    m_Valeur = value;
                    OnPropertyChanged("Valeur");
                }
			}
		}

		public string   Description{
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

        public int      iM
        {
            get { return m_iM; }
            set { m_iM = value; }
        }

	}//end GrandeurPhysique

}//end namespace Modelisator.Model