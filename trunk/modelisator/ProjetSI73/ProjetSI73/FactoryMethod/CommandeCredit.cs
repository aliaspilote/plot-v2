using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.FactoryMethod
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant) { }

        public override void paye()
        {
            Console.WriteLine(
              "Le paiement de la commande au crédit de : " +
              montant + " est effectué.");
        }

        public override bool valide()
        {
            return (montant >= 1000.0) && (montant <= 5000.0);
        }
    }
}
