using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.TemplateMethod
{
    public class CommandeLuxembourg : Commande
    {
        protected override void calculeTva()
        {
            montantTva = montantHt * 0.15;
        }
    }
}
