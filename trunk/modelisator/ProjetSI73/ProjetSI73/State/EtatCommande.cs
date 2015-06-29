using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.State
{
    public abstract class EtatCommande
    {
        protected Commande commande;

        public EtatCommande(Commande commande)
        {
            this.commande = commande;
        }

        public abstract void ajouteProduit(Produit produit);
        public abstract void efface();
        public abstract void retireProduit(Produit produit);
        public abstract EtatCommande etatSuivant();
    }
}
