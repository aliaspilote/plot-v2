using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.FactoryMethod
{
    public class ClientComptant : Client
    {
        protected override Commande creeCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}
