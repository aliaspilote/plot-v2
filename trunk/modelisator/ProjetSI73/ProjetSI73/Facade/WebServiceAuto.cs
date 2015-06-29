using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Facade
{
    public interface WebServiceAuto
    {
        string document(int index);
        IList<string> chercheVehicules(int prixMoyen, int
          ecartMax);
    }
}
