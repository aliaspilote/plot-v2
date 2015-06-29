using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Observer
{
    public class VueVehicule : Observateur
    {
        protected Vehicule vehicule;
        protected string texte = "";

        public VueVehicule(Vehicule vehicule)
        {
            this.vehicule = vehicule;
            vehicule.ajoute(this);
            metAJourTexte();
        }

        protected void metAJourTexte()
        {
            texte = "Description " + vehicule.description +
              " Prix : " + vehicule.prix;
        }

        public void actualise()
        {
            metAJourTexte();
            this.redessine();
        }

        public void redessine()
        {
            Console.WriteLine(texte);
        }
    }
}
