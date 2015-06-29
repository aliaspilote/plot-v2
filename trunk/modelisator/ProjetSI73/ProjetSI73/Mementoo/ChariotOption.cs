using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Mementoo
{
    public class ChariotOption
    {
        protected IList<OptionVehicule> options =
            new List<OptionVehicule>();

        public Memento ajouteOption(OptionVehicule
          optionVehicule)
        {
            MementoImpl resultat = new MementoImpl();
            resultat.etat = options;
            IList<OptionVehicule> optionsIncompatibles =
              optionVehicule.optionsIncompatibles;
            foreach (OptionVehicule option in
              optionsIncompatibles)
                options.Remove(option);
            options.Add(optionVehicule);
            return resultat;
        }

        public void annule(Memento memento)
        {
            MementoImpl mementoImplInstance = memento as MementoImpl;
            if (mementoImplInstance == null)
                return;
            options = mementoImplInstance.etat;
        }

        public void affiche()
        {
            Console.WriteLine("Contenu du chariot des options");
            foreach (OptionVehicule option in options)
                option.affiche();
            Console.WriteLine();
        }
    }
}
