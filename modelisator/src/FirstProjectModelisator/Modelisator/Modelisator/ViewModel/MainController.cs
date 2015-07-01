using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using System.Threading;
using System.Windows;

namespace Modelisator.ViewModel
{    /*
     * Réalisé par Omar Latreche
     * omar.latreche@utbm.fr
     * latreche.omar@gmail.com
     * 01/07/2015
     * 
     */
    public class MainController
    {

        public Contexte Ctx;

        public ModelisatorFrame_ViewModel ModelisatorLauncher;

        public MainController(System.Windows.Application app, MainWindow mainWindow)
        {

            Thread.Sleep(2000);
            App = app;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MainWindow = mainWindow;
            Ctx = new Contexte();

            Auth_Controller = new Auth_ViewModel(Ctx);

            Auth_Controller.OKHandler += RunModelisator;
            Auth_Controller.CancelHandler += ExitModelisator;


            MainWindow.ContentPanel.Children.Add(Auth_Controller.View);
            SetupMainWindow();
        }
        private void RunModelisator(object sender, EventArgs args)
        {
            ModelisatorLauncher = new ModelisatorFrame_ViewModel(Ctx);
            MainWindow.ContentPanel.Children.Remove(Auth_Controller.View);
            MainWindow.ContentPanel.Children.Add(ModelisatorLauncher.View);
            ModelisatorLauncher.MenuTop_ViewModel.MenuTopForm_ViewModel.DeconnecterHandler += Logout;
        }
        private void ExitModelisator(object sender, EventArgs args)
        {
            App.Shutdown();
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
