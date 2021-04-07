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
    /// Логика взаимодействия для Houses.xaml
    /// </summary>
    public partial class Houses : Window
    {
        public Houses()
        {
            InitializeComponent();
        }

        private void Add_ClickH(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            houses House = new houses();
            House.Address_City = Ac.Text;
            House.Address_House = Ah.Text;
            House.Address_Number = An.Text;
            House.Address_Street = As.Text;
            House.Coordinate_latitude = Cl.Text;
            House.Coordinate_longitude = Clo.Text;
            House.TotalFloors = F.Text;
            House.TotalArea = Ta.Text;
            db.houses.Add(House);
            db.SaveChanges();
        }

        private void Update_ClickH(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            db.apartments.Load();
            var ap = Convert.ToInt64(UpdateId.Text);
            apartments Apart = db.apartments.Where(p => p.Id == ap).FirstOrDefault();
            if (HAcU.Text != "")
            {
                Apart.Address_City = HAcU.Text;
            }
            if (HAhU.Text != "")
            {
                Apart.Address_House = HAhU.Text;
            }
            if (HAnU.Text != "")
            {
                Apart.Address_Number = HAnU.Text;
            }
            if (HAsU.Text != "")
            {
                Apart.Address_Street = HAsU.Text;
            }
            if (HClU.Text != "")
            {
                Apart.Coordinate_latitude = HClU.Text;
            }
            if (HCloU.Text != "")
            {
                Apart.Coordinate_longitude = HCloU.Text;
            }
            if (HFU.Text != "")
            {
                Apart.Floor = HFU.Text;
            }
            if (HTaU.Text != "")
            {
                Apart.TotalArea = HTaU.Text;
            }
            db.SaveChanges();

        }

        private void Delete_ClickH(object sender, RoutedEventArgs e)
        {
            Entities db = new Entities();
            db.houses.Load();
            var hs = Convert.ToInt64(DeleteId.Text);
            houses dll= db.houses.Where(p => p.Id == hs).FirstOrDefault();
            db.houses.Remove(dll);
            db.SaveChanges();
        }
    }
}
