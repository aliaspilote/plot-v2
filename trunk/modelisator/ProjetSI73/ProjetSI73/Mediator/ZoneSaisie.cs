using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Mediator
{
    public class ZoneSaisie : Controle
    {
        public ZoneSaisie(string nom) : base(nom) { }

        public override void saisie()
        {
            Console.WriteLine("Saisie de : " + nom);
            valeur = Console.ReadLine();
            this.modifie();
        }
    }
}
