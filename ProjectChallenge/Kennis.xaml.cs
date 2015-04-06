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
using System.Windows.Shapes;

// author : Theunis Daan
// Date : 04.04.2015 17:31
namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            Window2 menu = new Window2();
            menu.Show();
            this.Close();
        }
        private void eerste_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tweede_Click(object sender, RoutedEventArgs e)
        {

        }

        private void derde_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tafels_Click(object sender, RoutedEventArgs e)
        {

        }

        private void optellingen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delingen_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
