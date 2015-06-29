using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Prototype
{
    public class BonDeCommande : Document
    {
        public override void affiche()
        {
            Console.WriteLine("Affiche le bon de commande : " +
              contenu);
        }

        public override void imprime()
        {
            Console.WriteLine("Imprime le bon de commande : " +
              contenu);
        }
    }
}
