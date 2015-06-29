using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Decorator
{
    public abstract class Decorateur :
  ComposantGraphiqueVehicule
    {
        protected ComposantGraphiqueVehicule composant;

        public Decorateur(ComposantGraphiqueVehicule composant)
        {
            this.composant = composant;
        }

        public virtual void affiche()
        {
            composant.affiche();
        }
    }
}
