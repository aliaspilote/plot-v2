using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Visitor
{
    public interface Visiteur
    {
        void visite(SocieteSansFiliale
          societe);
        void visite(SocieteMere societe);
    }
}
