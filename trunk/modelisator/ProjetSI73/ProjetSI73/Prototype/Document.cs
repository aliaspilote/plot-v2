using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Prototype
{
    public abstract class Document
    {
        protected string contenu = "";

        public Document duplique()
        {
            Document resultat;
            resultat = (Document)this.MemberwiseClone();
            return resultat;
        }

        public void remplit(string informations)
        {
            contenu = informations;
        }

        public abstract void imprime();
        public abstract void affiche();
    }


}
