using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse;

        public abstract void construitBonDeCommande(string
          nomClient);

        public abstract void construitDemandeImmatriculation
          (string nomDemandeur);

        public Liasse resultat()
        {
            return liasse;
        }
    }
}
