using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Visitor
{
    public class VisiteurMailingCommercial : Visiteur
    {
        public void visite(SocieteSansFiliale
          societe)
        {
            Console.WriteLine("Envoi d’un email à " +
              societe.nom + " adresse : " + societe.email
              + " Proposition commerciale pour votre société");
        }

        public void visite(SocieteMere societe)
        {
            Console.WriteLine("Envoi d’un email à " +
              societe.nom + " adresse : " + societe.email
              + " Proposition commerciale pour votre groupe");
            Console.WriteLine("Impression d’un courrier à " +
              societe.nom + " adresse : " +
              societe.adresse +
              " Proposition commerciale pour votre groupe");
        }
    }
}
