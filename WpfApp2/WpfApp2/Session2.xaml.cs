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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Session2.xaml
    /// </summary>
    public partial class Session2 : Window
    {
        public Session2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Apartments ap = new Apartments();
            ap.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lands ap = new Lands();
            ap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Houses ap = new Houses();
            ap.Show();
        }
    }
}
