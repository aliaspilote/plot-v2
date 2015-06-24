using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.Model;
using Modelisator.Forms.ViewModel;
using Modelisator.Model;

namespace Modelisator.Forms.Model
{
    public class MenuTop_StatutForm_Model
    {
        public Contexte Ctx;
        public MenuTop_StatutForm_Model() { }
        public MenuTop_StatutForm_Model(Contexte ctx)
        {
            Ctx = ctx;
        }
    }
}
