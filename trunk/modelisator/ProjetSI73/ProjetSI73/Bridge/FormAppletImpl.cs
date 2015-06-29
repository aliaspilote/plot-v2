using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Bridge
{
    public class FormAppletImpl : FormulaireImpl
    {

        public void dessineTexte(string texte)
        {
            Console.WriteLine("Applet : " + texte);
        }

        public string gereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
