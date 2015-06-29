using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.ChainOfResponsibility
{
    public class Modele : ObjetBase
    {
        protected string laDescription;
        protected string nom;

        public Modele(string nom, string description)
        {
            this.laDescription = description;
            this.nom = nom;
        }

        protected override string description
        {
            get
            {
                if (laDescription != null)
                    return "Modèle " + nom + " : " + laDescription;
                else
                    return null;
            }
        }
    }
}
