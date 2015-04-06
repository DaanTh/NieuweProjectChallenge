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
// Date : 04.04.2015 17:31 && 05.04.2015 13:39
namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public static bool eersteclick = false;
        public static bool tweedeclick = false;
        public static bool derdeclick = false;

        public Window3()
        {
            InitializeComponent();
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            Window2 menu = new Window2();
            menu.Show();
            this.Close();
        }

        private void eerste_Click(object sender, RoutedEventArgs e) //maak graadselectie onzichtbaar en aard van oefeningen zichtbaar
        {
            tafels.Visibility = System.Windows.Visibility.Visible;
            optellingen.Visibility = System.Windows.Visibility.Visible;
            delingen.Visibility = System.Windows.Visibility.Visible;
            graad1.Visibility = System.Windows.Visibility.Hidden;
            graad2.Visibility = System.Windows.Visibility.Hidden;
            graad3.Visibility = System.Windows.Visibility.Hidden;
            vorige.Visibility = System.Windows.Visibility.Visible;
            eersteclick = true;
        }

        private void tweede_Click(object sender, RoutedEventArgs e)
        {
            tafels.Visibility = System.Windows.Visibility.Visible;
            optellingen.Visibility = System.Windows.Visibility.Visible;
            delingen.Visibility = System.Windows.Visibility.Visible;
            graad1.Visibility = System.Windows.Visibility.Hidden;
            graad2.Visibility = System.Windows.Visibility.Hidden;
            graad3.Visibility = System.Windows.Visibility.Hidden;
            vorige.Visibility = System.Windows.Visibility.Visible;
            tweedeclick = true;
        }

        private void derde_Click(object sender, RoutedEventArgs e)
        {
            tafels.Visibility = System.Windows.Visibility.Visible;
            optellingen.Visibility = System.Windows.Visibility.Visible;
            delingen.Visibility = System.Windows.Visibility.Visible;
            graad1.Visibility = System.Windows.Visibility.Hidden;
            graad2.Visibility = System.Windows.Visibility.Hidden;
            graad3.Visibility = System.Windows.Visibility.Hidden;
            vorige.Visibility = System.Windows.Visibility.Visible;
            derdeclick = true;
        }

        private void tafels_Click(object sender, RoutedEventArgs e)
        {
            Tafels tafels = new Tafels();
            tafels.Show();
            this.Close(); ;
        }

        private void optellingen_Click(object sender, RoutedEventArgs e)
        {
        }

        private void delingen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vorige_Click(object sender, RoutedEventArgs e)
        {
            tafels.Visibility = System.Windows.Visibility.Hidden;
            optellingen.Visibility = System.Windows.Visibility.Hidden;
            delingen.Visibility = System.Windows.Visibility.Hidden;
            graad1.Visibility = System.Windows.Visibility.Visible;
            graad2.Visibility = System.Windows.Visibility.Visible;
            graad3.Visibility = System.Windows.Visibility.Visible;
            vorige.Visibility = System.Windows.Visibility.Hidden;
            eersteclick = false;
            tweedeclick = false;
            derdeclick = false;
        }
    }
}
