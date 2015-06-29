using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.State
{
    public class CommandeLivree : EtatCommande
    {
        public CommandeLivree(Commande commande)
            : base(commande)
        { }

        public override void ajouteProduit(Produit produit) { }

        public override void efface() { }

        public override void retireProduit(Produit produit) { }

        public override EtatCommande etatSuivant()
        {
            return this;
        }
    }
}
