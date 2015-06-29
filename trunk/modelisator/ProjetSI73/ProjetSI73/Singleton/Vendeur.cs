using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Singleton
{
    public class Vendeur
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public string email { get; set; }

        private static Vendeur _instance = null;

        private Vendeur() { }

        public static Vendeur Instance()
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }

        public void affiche()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Adresse : " + adresse);
            Console.WriteLine("Email : " + email);
        }

    }
}
