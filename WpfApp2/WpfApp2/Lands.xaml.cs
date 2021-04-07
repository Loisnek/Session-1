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
    /// Логика взаимодействия для Lands.xaml
    /// </summary>
    public partial class Lands : Window
    {
        public Lands()
        {
            InitializeComponent();
        }

        private void Add_ClickL(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            lands land = new lands();
            land.Address_City = LAc.Text;
            land.Address_House = LAh.Text;
            land.Address_Number = LAn.Text;
            land.Address_Street = LAs.Text;
            land.Coordinate_latitude = LCl.Text;
            land.Coordinate_longitude = LClo.Text;
            land.TotalArea = LTa.Text;
            db.lands.Add(land);
            db.SaveChanges();
        }

        private void Update_ClickL(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            db.lands.Load();
            var lan = Convert.ToInt64(UpdateId.Text);
            lands Apart = db.lands.Where(p => p.Id == lan).FirstOrDefault();
            if (LAcU.Text != "")
            {
                Apart.Address_City = LAcU.Text;
            }
            if (LAhU.Text != "")
            {
                Apart.Address_House = LAhU.Text;
            }
            if (LAnU.Text != "")
            {
                Apart.Address_Number = LAnU.Text;
            }
            if (LAsU.Text != "")
            {
                Apart.Address_Street = LAsU.Text;
            }
            if (LClU.Text != "")
            {
                Apart.Coordinate_latitude = LClU.Text;
            }
            if (LCloU.Text != "")
            {
                Apart.Coordinate_longitude = LCloU.Text;
            }
            if (LTaU.Text != "")
            {
                Apart.TotalArea = LTaU.Text;
            }
            db.SaveChanges();

        }

        private void Delete_ClickL(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            db.lands.Load();
            var lan = Convert.ToInt64(DeleteId.Text);
            lands ds = db.lands.Where(p => p.Id == lan).FirstOrDefault();
            db.lands.Remove(ds);
            db.SaveChanges();
        }
    }
}
