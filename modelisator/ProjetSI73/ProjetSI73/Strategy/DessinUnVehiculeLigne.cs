using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Strategy
{
    public class DessinUnVehiculeLigne : DessinCatalogue
    {

        public void dessine(IList<VueVehicule> contenu)
        {
            Console.WriteLine(
              "Dessine les véhicules avec un véhicule par ligne");
            foreach (VueVehicule vueVehicule in contenu)
            {
                vueVehicule.dessine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
