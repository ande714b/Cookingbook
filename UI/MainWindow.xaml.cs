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
using Cookingbook.Application;

namespace UI
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
            MwFrame.Content = new Forside();      
        }

        private void Forsidebtn(object sender, RoutedEventArgs e)
        {
            MwFrame.Content = new Forside();
        }

        private void Inventarbtn(object sender, RoutedEventArgs e)
        {
            MwFrame.Content = new Inventar(controller);
        }

        private void Opskrifterbtn(object sender, RoutedEventArgs e)
        {
            MwFrame.Content = new Opskrifter(controller);
        }
    }
}
