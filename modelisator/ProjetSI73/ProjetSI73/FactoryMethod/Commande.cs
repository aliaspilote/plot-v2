using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.FactoryMethod
{
    public abstract class Commande
    {
        protected double montant;

        public Commande(double montant)
        {
            this.montant = montant;
        }

        public abstract bool valide();

        public abstract void paye();
    }


}