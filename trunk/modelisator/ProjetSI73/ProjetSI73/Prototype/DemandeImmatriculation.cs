using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Prototype
{
    public class DemandeImmatriculation : Document
    {
        public override void affiche()
        {
            Console.WriteLine(
              "Affiche la demande d’immatriculation : " + contenu);
        }

        public override void imprime()
        {
            Console.WriteLine(
              "Imprime la demande d’immatriculation : " + contenu);
        }
    }
}
