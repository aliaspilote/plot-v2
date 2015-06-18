using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelisator.Model
{
    class equations
    {
        // Presure of gaz (1)
        double Pression(double X1, double Tmax,double p0)
        {
            return (X1*double(Math.Pow(Tmax-15,2))+p0);
        }

    }
}
