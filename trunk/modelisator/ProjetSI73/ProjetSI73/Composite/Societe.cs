using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Composite
{
    public abstract class Societe
{
  protected static double coutUnitVehicule = 5.0;
  protected int nbrVehicules;

  public void ajouteVehicule()
  {
    nbrVehicules = nbrVehicules + 1;
  }

  public abstract double calculeCoutEntretien();

  public abstract bool ajouteFiliale(Societe filiale);
}

}
