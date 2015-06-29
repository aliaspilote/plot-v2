using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.View;
using System.Windows;
using Modelisator.Model;

namespace Modelisator.ViewModel
{
    public class Auth_ViewModel
    {
        public event EventHandler<EventArgs> OKHandler;

        public event EventHandler<EventArgs> CancelHandler;

        public Auth_View_UserControl View
        {
            get;
            private set;
        }
        public Auth_Model Model
        {
            get;
            private set;
        }


        public Auth_ViewModel(Contexte ctx)
        {
            View = new Auth_View_UserControl();
            Model = new Auth_Model(ctx);
            ConnectView();
        }
        protected void ConnectView()
        {
            View.OkBtn.Click += OkBtnClick;
            View.QuitBtn.Click += QuitBtnClick;
        }

        /// <summary>   
        /// Handler for the OK button Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void QuitBtnClick(object sender, RoutedEventArgs e)
        {
                if (CancelHandler != null)
                    CancelHandler(this, EventArgs.Empty);

        }
        /// <summary>
        /// Handler for the OK button Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OkBtnClick(object sender, RoutedEventArgs e)
        {
            if (ValidateLogin())
            {
                if (OKHandler != null)
                    OKHandler(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte");
        }

        public bool ValidateLogin()
        {
            string user_login = View.User.Text;
            if (View.Password.Password.Equals(user_login))
            {
                if (user_login == "")
                    user_login = "Utilisateur anonyme";
                Model.Ctx.User = new Utilisateur(user_login, new Groupe("Concepteur"));
                return true;
            }
            else
                return false;
        }

    }
}
