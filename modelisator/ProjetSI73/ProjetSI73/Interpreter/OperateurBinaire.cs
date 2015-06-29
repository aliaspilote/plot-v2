using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Interpreter
{
    public abstract class OperateurBinaire : Expression
    {
        protected Expression operandeGauche, operandeDroite;

        public OperateurBinaire(Expression operandeGauche,
          Expression operandeDroite)
        {
            this.operandeGauche = operandeGauche;
            this.operandeDroite = operandeDroite;
        }
    }
}
