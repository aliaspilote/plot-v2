using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.State
{
    public class Produit
    {
        protected string nom;

        public Produit(string nom)
        {
            this.nom = nom;
        }

        public void affiche()
        {
            Console.WriteLine("Produit : " + nom);
        }
    }
}
