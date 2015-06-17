using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelisator.Model
{
    public class Auth_Model
    {

        public Contexte Ctx
        {
            get;
            private set;
        }

        public Auth_Model()
        {
        }

        public Auth_Model(Contexte ctx)
        {
            Ctx = ctx;
        }

        ~Auth_Model()
        {

		}

		public virtual void Dispose(){

		}


    }
}
