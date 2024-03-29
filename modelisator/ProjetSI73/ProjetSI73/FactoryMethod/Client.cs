﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> commandes =
            new List<Commande>();

        protected abstract Commande creeCommande(double montant);

        public void nouvelleCommande(double montant)
        {
            Commande commande = this.creeCommande(montant);
            if (commande.valide())
            {
                commande.paye();
                commandes.Add(commande);
            }
        }
    }
}
