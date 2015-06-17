using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;

namespace Modelisator.ViewModel
{
    public class MainController
    {
        public MainController(System.Windows.Application app, MainWindow mainWindow)
        {
            App = app;
            MainWindow = mainWindow;

            Auth_Controller = new Auth_ViewModel();

            MainWindow.ContentPanel.Children.Add(Auth_Controller.View);
            SetupMainWindow();
        }
        private void RunModelisator(object sender, EventArgs args)
        {
            ModelisatorFrame_ViewModel ModelisatorLauncher = new ModelisatorFrame_ViewModel(new Contexte());
            MainWindow.ContentPanel.Children.Remove(Auth_Controller.View);
            MainWindow.ContentPanel.Children.Add(ModelisatorLauncher.View);
        }

        /// <summary>
        /// Exit GSys Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Logout(object sender, EventArgs args)
        {
            App.Shutdown();
        }

        /// <summary>
        /// The Application
        /// </summary>
        public System.Windows.Application App
        {
            get;
            private set;
        }

        /// <summary>
        /// The Main Window
        /// </summary>
        public MainWindow MainWindow
        {
            get;
            private set;
        }

        /// <summary>
        /// The Login Controller
        /// </summary>
        public Auth_ViewModel Auth_Controller
        {
            get;
            private set;
        }

        /// <summary>
        /// Setup the MainWindow
        /// </summary>
        protected void SetupMainWindow()
        {
            MainWindow.Title = "Modélisator - Application";
        }

    }
}
