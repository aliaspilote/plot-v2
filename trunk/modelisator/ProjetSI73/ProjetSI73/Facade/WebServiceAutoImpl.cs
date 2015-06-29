using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Facade
{
    public class WebServiceAutoImpl : WebServiceAuto
    {
        protected Catalogue catalogue = new ComposantCatalogue();
        protected GestionDocument gestionDocument = new
          ComposantGestionDocument();

        public string document(int index)
        {
            return gestionDocument.document(index);
        }

        public IList<string> chercheVehicules(int prixMoyen,
          int ecartMax)
        {
            return catalogue.retrouveVehicules(prixMoyen -
              ecartMax, prixMoyen + ecartMax);
        }
    }

}
