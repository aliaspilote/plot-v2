using Modelisator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modelisator.View
{
    /// <summary>
    /// Logique d'interaction pour Auth_View_UserControl.xaml
    /// </summary>
    public partial class Auth_View_UserControl : UserControl
    {
        Auth_Model View_Model;
        /// <summary>
        /// User  TextBox
        /// </summary>
        public TextBox User
        {
            get
            {
                return m_User;
            }
        }

        /// <summary>
        /// Password box
        /// </summary>
        public PasswordBox Password
        {
            get
            {
                return m_Password;
            }
        }

        /// <summary>
        /// The OK Button
        /// </summary>
        public Button OkBtn
        {
            get
            {
                return m_OkBtn;
            }
        }

        /// <summary>
        /// The Cancel Button
        /// </summary>
        public Button QuitBtn
        {
            get
            {
                return m_QuitBtn;
            }
        }

        public Auth_View_UserControl()
        {
            InitializeComponent();
            View_Model = new Auth_Model();
        }



    }
}
