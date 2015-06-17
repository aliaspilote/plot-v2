﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Modelisator.ViewModel;
using System.Threading;
namespace Modelisator
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {

        //MainWindow

        public MainController ModelisatorController
        {
            get;
            private set;
        }

        /// <summary>
        /// Starts the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Our Login Controller
            Thread.Sleep(2000);
            MainWindow main = new MainWindow();
            MainWindow = main;
            ModelisatorController = new MainController(this, main);

            MainWindow.Show();
        }

    }
}
