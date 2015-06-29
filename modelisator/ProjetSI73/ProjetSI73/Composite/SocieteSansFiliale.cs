using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Composite
{
    public class SocieteSansFiliale : Societe
    {
        public override bool ajouteFiliale(Societe filiale)
        {
            return false;
        }

        public override double calculeCoutEntretien()
        {
            return nbrVehicules * coutUnitVehicule;
        }
    }
}
