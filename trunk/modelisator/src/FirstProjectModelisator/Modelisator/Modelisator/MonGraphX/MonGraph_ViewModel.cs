using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;

namespace Modelisator.MonGraphX
{
    public class MonGraph_ViewModel
    {
        public MonGraph_ViewModel(Contexte ctx)
        {
            View = new MonGraph_UserControl();
            Model = new MonGraph_Model(ctx);
            SetupView();
            ConnectView(); 
        }

        protected void ConnectView()
        {
        }
        
        protected void SetupView()
        {

        }
        public MonGraph_UserControl View
        {
            get;
            private set;
        }
        public MonGraph_Model Model
        {
            get;
            private set;
        }
    }

}
