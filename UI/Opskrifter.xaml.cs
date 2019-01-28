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
    /// Interaction logic for Opskrifter.xaml
    /// </summary>
    public partial class Opskrifter : Page
    {
        Controller _controller;
        public Opskrifter(Controller controller)
        {
            InitializeComponent();
            _controller = controller;

            Updateboxes();
        }

        private void Updateboxes()
        {
            List<string> outputlist1 = new List<string>();
            List<string> outputlist2 = new List<string>();

            outputlist1.Add(_controller.getopskrifttitle(0));

            foreach (var item in _controller.getopskriftingredients(0))
            {
                outputlist1.Add(item);
            }


            outputlist2.Add(_controller.getopskrifttitle(1));

            foreach (var item in _controller.getopskriftingredients(1))
            {
                outputlist2.Add(item);
            }



            box1.ItemsSource = outputlist1;
            box2.ItemsSource = outputlist2;
        }
    }
}
