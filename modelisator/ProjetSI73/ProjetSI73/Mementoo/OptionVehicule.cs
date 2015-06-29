using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Mementoo
{
    public class OptionVehicule
    {
        protected string nom;
        public IList<OptionVehicule> optionsIncompatibles
        { get; protected set; }

        public OptionVehicule(string nom)
        {
            optionsIncompatibles = new List<OptionVehicule>();
            this.nom = nom;
        }

        public void ajouteOptionIncompatible(OptionVehicule
          optionIncompatible)
        {
            if (!optionsIncompatibles.Contains(optionIncompatible))
            {
                optionsIncompatibles.Add(optionIncompatible);
                optionIncompatible.ajouteOptionIncompatible(this);
            }
        }

        public void affiche()
        {
            Console.WriteLine("option : " + nom);
        }
    }
}
