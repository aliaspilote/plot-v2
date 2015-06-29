using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Interpreter
{
    public class OperateurOu : OperateurBinaire
    {
        public OperateurOu(Expression operandeGauche,
          Expression operandeDroite)
            : base(operandeGauche,
                operandeDroite) { }

        public override bool evalue(string description)
        {
            return operandeGauche.evalue(description) ||
              operandeDroite.evalue(description);
        }

        // partie analyse syntaxique
        public static new Expression parse()
        {
            Expression resultatGauche, resultatDroit;
            resultatGauche = OperateurEt.parse();
            while ((jeton != null) && (jeton == "ou"))
            {
                prochainJeton();
                resultatDroit = OperateurEt.parse();
                resultatGauche = new OperateurOu(resultatGauche,
                  resultatDroit);
            }
            return resultatGauche;
        }
    }
}
