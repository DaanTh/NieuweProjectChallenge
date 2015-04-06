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

//Author : Daan Theunis
//Date : 04.04.2015 17:20

namespace ProjectChallenge
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void wiskunde_Click(object sender, RoutedEventArgs e)
        {
            Window3 wiskunde = new Window3();
            wiskunde.Show();
            this.Close(); ;
        }
        private void taal_Click(object sender, RoutedEventArgs e)
        {
            Window4 wiskunde = new Window4();
            wiskunde.Show();
            this.Close(); ;
        }
        private void kennis_Click(object sender, RoutedEventArgs e)
        {
            Window5 wiskunde = new Window5();
            wiskunde.Show();
            this.Close(); ;
        }
    }
}
