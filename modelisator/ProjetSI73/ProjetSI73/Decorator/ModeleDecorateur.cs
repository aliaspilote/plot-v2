using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Decorator
{
    public class ModeleDecorateur : Decorateur
    {
        public ModeleDecorateur(ComposantGraphiqueVehicule
          composant)
            : base(composant) { }

        protected void afficheInfosTechniques()
        {
            Console.WriteLine("Informations techniques du modèle");
        }

        public override void affiche()
        {
            base.affiche();
            this.afficheInfosTechniques();
        }
    }
}
