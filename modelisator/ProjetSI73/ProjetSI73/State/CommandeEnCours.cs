using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.State
{
    public class CommandeEnCours : EtatCommande
    {
        public CommandeEnCours(Commande commande)
            : base
                (commande) { }

        public override void ajouteProduit(Produit produit)
        {
            commande.Produits.Add(produit);
        }

        public override void efface()
        {
            commande.Produits.Clear();
        }

        public override void retireProduit(Produit produit)
        {
            commande.Produits.Remove(produit);
        }

        public override EtatCommande etatSuivant()
        {
            return new CommandeValidee(commande);
        }
    }
}
