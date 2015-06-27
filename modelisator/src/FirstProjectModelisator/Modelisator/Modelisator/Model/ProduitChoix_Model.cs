using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelisator.Model
{
    public class ProduitChoix_Model
    {
        public Contexte Ctx;

        public ProduitChoix_Model() { }

        public ProduitChoix_Model(Contexte ctx)
        {
            Ctx = ctx;
        }

        public void selectionnerProduit(string Nom)
        {
            foreach (Produit P in Ctx.ListeProduits)
            {
                if (P.Nom.ToUpper() == Nom.ToUpper())
                    P.Selectionner = true;
                else
                {
                    P.Selectionner = false;
                }
            }
        }
    }
}
