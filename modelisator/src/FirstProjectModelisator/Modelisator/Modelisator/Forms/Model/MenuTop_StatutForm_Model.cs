using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
            Utilisateur_ctx = ctx.User;
            Ctx = ctx;
        }
        public Utilisateur Utilisateur_ctx
        {
            get;
            set;
        }

    }
}
