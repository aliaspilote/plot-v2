using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.ChainOfResponsibility
{
    public abstract class ObjetBase
    {
        public ObjetBase suivant { protected get; set; }

        private string descriptionParDefaut()
        {
            return "description par défaut";
        }

        protected abstract string description { get; }

        public string donneDescription()
        {
            string resultat;
            resultat = this.description;
            if (resultat != null)
                return resultat;
            if (suivant != null)
                return suivant.donneDescription();
            else
                return this.descriptionParDefaut();
        }
    }
}
