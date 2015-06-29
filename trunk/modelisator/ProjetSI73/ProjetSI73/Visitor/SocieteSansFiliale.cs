using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Visitor
{
    public class SocieteSansFiliale : Societe
    {
        public SocieteSansFiliale(string nom, string email,
          string adresse)
            : base(nom, email, adresse) { }

        public override void accepteVisiteur(Visiteur visiteur)
        {
            visiteur.visite(this);
        }

        public override bool ajouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}
