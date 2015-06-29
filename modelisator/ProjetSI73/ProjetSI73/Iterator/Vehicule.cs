using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Iterator
{
    public class Vehicule : Element
    {

        public Vehicule(string description) : base(description) { }

        public void affiche()
        {
            Console.WriteLine("Description du véhicule : " +
              description);
        }
    }
}
