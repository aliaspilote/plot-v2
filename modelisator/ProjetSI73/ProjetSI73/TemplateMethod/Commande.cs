using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.TemplateMethod
{
    public abstract class Commande
{
  protected double montantHt;
  protected double montantTva;
  protected double montantTtc;

  protected abstract void calculeTva();

  public void calculeMontantTtc()
  {
    this.calculeTva();
    montantTtc = montantHt + montantTva;
  }

  public void setMontantHt(double montantHt)
  {
    this.montantHt = montantHt;
  }

  public void affiche()
  {
    Console.WriteLine("Commande");
    Console.WriteLine("Montant HT " + montantHt);
    Console.WriteLine("Montant TTC " + montantTtc);
  }
}

}
