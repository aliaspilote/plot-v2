using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Visitor
{
    public abstract class Societe
    {
        public string nom { get; protected set; }
        public string email { get; protected set; }
        public string adresse { get; protected set; }

        public Societe(string nom, string email, string adresse)
        {
            this.nom = nom;
            this.email = email;
            this.adresse = adresse;
        }

        public abstract bool ajouteFiliale(Societe filiale);

        public abstract void accepteVisiteur(Visiteur visiteur);
    }

}
