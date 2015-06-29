using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Observer
{
    public abstract class Sujet
{
  protected IList<Observateur> observateurs = 
      new List<Observateur>();

  public void ajoute(Observateur observateur)
  {
    observateurs.Add(observateur);
  }

  public void retire(Observateur observateur)
  {
    observateurs.Remove(observateur);
  }

  public void notifie()
  {
    foreach (Observateur observateur in observateurs)
      observateur.actualise();
  }
}

}
