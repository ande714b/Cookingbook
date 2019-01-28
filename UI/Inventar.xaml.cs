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
    /// Interaction logic for Inventar.xaml
    /// </summary>
    public partial class Inventar : Page
    {
        Controller _controller;
        public Inventar(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
            updateInventar();
        }

        private void updateInventar()
        {
            List<string> list = _controller.getIngredients();
            textbox1.Text = list[0];
            textbox2.Text = list[1];
            textbox3.Text = list[2];
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
