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
        public Vejledning(Controller controller)
        {
            InitializeComponent();
            _controller = controller;

            updateListboxes();
        }

        private void updateListboxes()
        {
            List<string> outputlist1 = new List<string>();
            List<string> outputlist2 = new List<string>();

            outputlist1.Add(_controller.getrecepiestile(0));

            foreach (var item in _controller.getrecepiesSteps(0))
            {
                outputlist1.Add(item);
            }

            outputlist1.Add("Tid: " + _controller.getrecepiesTime(0).ToString());




            outputlist2.Add(_controller.getrecepiestile(1));

            foreach (var item in _controller.getrecepiesSteps(1))
            {
                outputlist2.Add(item);
            }

            outputlist2.Add("Tid: " + _controller.getrecepiesTime(1).ToString());


            listbox1.ItemsSource = outputlist1;
            listbox2.ItemsSource = outputlist2;
        }
    }
}
