using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Prototype
{
    public class CertificatCession : Document
    {
        public override void affiche()
        {
            Console.WriteLine(
              "Affiche le certificat de cession : " + contenu);
        }

        public override void imprime()
        {
            Console.WriteLine(
              "Imprime le certificat de cession : " + contenu);
        }
    }
}
