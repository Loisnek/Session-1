using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void DeleteC(object sender, RoutedEventArgs e)
        {
            var db = new Entities();
            db.clients.Load();
            var delete = db.clients.Local.Where(p => p.Id == Convert.ToInt32(DeleteId.Text)).FirstOrDefault();
            db.clients.Remove(delete);
            db.SaveChanges();
        }

        private void updateC(object sender, RoutedEventArgs e)
        {

        }

        private void createC(object sender, RoutedEventArgs e)
        {

        }
    }
}
