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

namespace DragDropTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Circle c = new Circle();
            Truc1.Children.Add(c);
        }

        private void panel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Object"))
            {
                // Vérifie que les données glissées contiennent les données Object qui ont été empaquetées dans DataObject par le contrôle utilisateur Circle
                // et passées dans l'appel à DoDragDrop
                if(e.KeyStates == DragDropKeyStates.ControlKey)
                {
                    e.Effects = DragDropEffects.Copy;
                }
                else
                {
                    e.Effects = DragDropEffects.Move;
                }
            }
        }

        private void panel_Drop (object sender, DragEventArgs e)
        {
            // Si un contrôle Circle est déposé sur un autre contrôle Circle qui gère l'évènement Drop, le panneau qui contient le
            // controle Circle ne doit pas également le gérer.
            if(e.Handled == false)
            {
                Panel _panel = (Panel)sender;
                UIElement _element = (UIElement)e.Data.GetData("Object");

                if(_panel != null && _element != null)
                {
                    // récupère le panel auquel l'élément appartient, puis le détruit de ce panel et ajoute l'objet dans le panel dans lequel il est droppé
                    Panel _parent = (Panel)VisualTreeHelper.GetParent(_element);

                    if(_parent != null)
                    {
                        if(e.KeyStates ==  DragDropKeyStates.ControlKey && e.AllowedEffects.HasFlag(DragDropEffects.Copy))
                        {
                            Circle _circle = new Circle((Circle)_element);
                            _panel.Children.Add(_circle);
                            e.Effects = DragDropEffects.Copy;
                        }
                        else if (e.AllowedEffects.HasFlag(DragDropEffects.Move))
                        {
                            _parent.Children.Remove(_element);
                            _panel.Children.Add(_element);
                            e.Effects = DragDropEffects.Move;
                        }
                    }
                }
            }
        }
    }
}
