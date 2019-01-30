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
            listbox1.ItemsSource = list;
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            _controller.addIngredient(ingredientbox.Text);
            ingredientbox.Text = "";
            updateInventar();
        }
    }
}
