using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.AbstractFactory
{
    public abstract class Automobile
    {
        protected string modele;
        protected string couleur;
        protected int puissance;
        protected double espace;

        public Automobile(string modele, string couleur, int
          puissance, double espace)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.puissance = puissance;
            this.espace = espace;
        }

        public abstract void afficheCaracteristiques();
    }

}
