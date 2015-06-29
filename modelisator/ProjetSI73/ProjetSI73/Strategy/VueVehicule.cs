using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Strategy
{
    public class VueVehicule
    {
        protected string description;

        public VueVehicule(string description)
        {
            this.description = description;
        }

        public void dessine()
        {
            Console.Write(description);
        }
    }
}
