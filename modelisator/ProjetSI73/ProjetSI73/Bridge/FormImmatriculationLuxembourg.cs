using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Bridge
{
    public class FormImmatriculationLuxembourg :
   FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(FormulaireImpl
          implantation)
            : base(implantation) { }

        protected override bool controleSaisie(string plaque)
        {
            return plaque.Length == 5;
        }
    }
}
