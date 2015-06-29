using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Facade
{
    public class ComposantGestionDocument : GestionDocument
    {

        public string document(int index)
        {
            return "Document numéro " + index;
        }
    }
}
