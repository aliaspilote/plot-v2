using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Flyweight
{
    public class FabriqueOption
    {
        protected IDictionary<string, OptionVehicule> options
          = new Dictionary<string, OptionVehicule>();
        public OptionVehicule getOption(string nom)
        {
            OptionVehicule resultat;
            if (options.ContainsKey(nom))
                resultat = options[nom];
            else
            {
                resultat = new OptionVehicule(nom);
                options.Add(nom, resultat);
            }
            return resultat;
        }
    }
}
