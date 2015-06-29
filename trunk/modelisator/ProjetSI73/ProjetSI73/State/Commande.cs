using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.State
{
   public class Commande
{
  protected IList<Produit> produits = new List<Produit>();
  public IList<Produit> Produits
  {
    get
    {
      return produits;
    }
  }
  protected EtatCommande etatCommande;

  public Commande()
  {
    etatCommande = new CommandeEnCours(this);
  }

  public void ajouteProduit(Produit produit)
  {
    etatCommande.ajouteProduit(produit);
  }

  public void retireProduit(Produit produit)
  {
    etatCommande.retireProduit(produit);
  }

  public void efface()
  {
    etatCommande.efface();
  }

  public void etatSuivant()
  {
    etatCommande = etatCommande.etatSuivant();
  }

  public void affiche()
  {
    Console.WriteLine("Contenu de la commande");
    foreach (Produit produit in produits)
      produit.affiche();
    Console.WriteLine();
  }
}

}
