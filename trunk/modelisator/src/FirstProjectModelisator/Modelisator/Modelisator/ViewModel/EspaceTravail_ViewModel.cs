using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Modelisator.Forms.View;
using Modelisator.Model;
using Modelisator.MonGraphX;
using Modelisator.View;

namespace Modelisator.ViewModel
{
    public class EspaceTravail_ViewModel
    {

        public EspaceTravail_ViewModel()
        { }
        public EspaceTravail_ViewModel(Contexte ctx)
        {
            View = new EspaceTravail_View_UserControl();
            Model = new EspaceTravail_Model(ctx);
            MonGraph_ViewModel = new MonGraph_ViewModel(ctx);
            connectView();
            setupView();


        }
        private void FocusGraph(object sender, MouseEventArgs e)
        {
            RefreshVueGraph(((TextBlock) e.Source).Text, "FOCUS");
        }

        public void RefreshVueGraph(string GPnom = "", string FOCUS = "")
        {
            MonGraph_ViewModel.PreapationGPselectionnee(GPnom); ;
            deconnectView();
            unsetView();
            MonGraph_ViewModel.View = new MonGraph_UserControl(FOCUS);
            MonGraph_ViewModel.SetupView();
            MonGraph_ViewModel.ConnectView();
            connectView();
            setupView();

        }
        public MonGraph_ViewModel MonGraph_ViewModel
        {
            get;
            private set;
        }
        public EspaceTravail_View_UserControl View
        {
            get;
            private set;
        }
        public EspaceTravail_Model Model
        {
            get;
            private set;
        }

        public void connectView()
        {
            MonGraph_ViewModel.FocusGraph += FocusGraph;

        }

        public void setupView()
        {
            View.GridEspaceTravail.Children.Add(MonGraph_ViewModel.View);
        }

        public void deconnectView()
        {
            MonGraph_ViewModel.FocusGraph -= FocusGraph;
        }

        public void unsetView()
        {
            View.GridEspaceTravail.Children.Clear();
        }

    }
}
