using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modelisator.Model
{
    public class EspaceTravail_Model
    {
        public Contexte Ctx;

        public EspaceTravail_Model() { }
        
        public EspaceTravail_Model(Contexte ctx)
        {
            Ctx = ctx;
            Relation.EnnumRelation();
        }
    }
}
