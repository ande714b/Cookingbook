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
    /// Interaction logic for Vejledning.xaml
    /// </summary>
    public partial class Vejledning : Page
    {
        Controller _controller;
        public Vejledning(Controller controller, int i)
        {
            _controller = controller;
            InitializeComponent();

            updateListboxes(i);
        }

        private void updateListboxes(int i)
        {
            List<string> outputlist1 = new List<string>();

            outputlist1.Add(_controller.getrecepiestile(i));

            foreach (var item in _controller.getrecepiesSteps(i))
            {
                outputlist1.Add(item);
            }

            outputlist1.Add("Tid: " + _controller.getrecepiesTime(i).ToString());

            listbox1.ItemsSource = outputlist1;
        }
    }
}
