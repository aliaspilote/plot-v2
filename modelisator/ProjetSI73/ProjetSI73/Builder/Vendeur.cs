using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Builder
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse construit(string nomClient)
        {
            constructeur.construitBonDeCommande(nomClient);
            constructeur.construitDemandeImmatriculation
              (nomClient);
            Liasse liasse = constructeur.resultat();
            return liasse;
        }
    }
}
