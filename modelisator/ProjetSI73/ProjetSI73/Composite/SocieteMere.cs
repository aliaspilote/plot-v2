﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Composite
{
    public class SocieteMere : Societe
    {
        protected IList<Societe> filiales =
            new List<Societe>();

        public override bool ajouteFiliale(Societe filiale)
        {
            filiales.Add(filiale);
            return true;
        }

        public override double calculeCoutEntretien()
        {
            double cout = 0.0;
            foreach (Societe filiale in filiales)
                cout = cout + filiale.calculeCoutEntretien();
            return cout + nbrVehicules * coutUnitVehicule;
        }
    }
}
