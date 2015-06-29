using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Mediator
{
    public abstract class Controle
{
  public string valeur { get; protected set; }
  public Formulaire directeur { get;  set;}
  public string nom { get; protected set; }

  public Controle(string nom)
  {
    this.valeur = "";
    this.nom = nom;
  }

  public abstract void saisie();

  protected void modifie()
  {
    directeur.controleModifie(this);
  }
}

}
