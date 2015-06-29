using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Mediator
{
    public class Bouton : Controle
    {
        public Bouton(string nom) : base(nom) { }

        public override void saisie()
        {
            Console.WriteLine("Désirez-vous activer le bouton " +
              nom + " ?");
            string reponse = Console.ReadLine();
            if (reponse == "oui")
                this.modifie();
        }
    }
}
