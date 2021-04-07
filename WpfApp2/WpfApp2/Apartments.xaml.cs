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
    /// Логика взаимодействия для Apartments.xaml
    /// </summary>
    public partial class Apartments : Window
    {
        public Apartments()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities db = new Entities();
                db.apartments.Load();
                var ap = Convert.ToInt64(UpdateId.Text);
                apartments Apart = db.apartments.Where(p => p.Id == ap).FirstOrDefault();
                if (AACU.Text != "")
                {
                    Apart.Address_City = AACU.Text;
                }
                if (AAHU.Text != "")
                {
                    Apart.Address_House = AAHU.Text;
                }
                if (AANU.Text != "")
                {
                    Apart.Address_Number = AANU.Text;
                }
                if (AASU.Text != "")
                {
                    Apart.Address_Street = AASU.Text;
                }
                if (AClU.Text != "")
                {
                    Apart.Coordinate_latitude = AClU.Text;
                }
                if (ACloU.Text != "")
                {
                    Apart.Coordinate_longitude = ACloU.Text;
                }
                if (AFU.Text != "")
                {
                    Apart.Floor = AFU.Text;
                }
                if (ARU.Text != "")
                {
                    Apart.Rooms = ARU.Text;
                }
                if (ATaU.Text != "")
                {
                    Apart.TotalArea = ATaU.Text;
                }
                db.SaveChanges();

            }
            catch
            {

            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities db = new Entities();
                db.apartments.Load();
                apartments Apart = new apartments();
                Apart.Address_City = AAc.Text;
                Apart.Address_House = AAh.Text;
                Apart.Address_Street = AAs.Text;
                Apart.Address_Number = AAn.Text;
                Apart.Coordinate_latitude = ACl.Text;
                Apart.Coordinate_longitude = AClo.Text;
                Apart.Floor = AF.Text;
                Apart.Rooms = AR.Text;
                Apart.TotalArea = ATa.Text;
                db.apartments.Add(Apart);
                db.SaveChanges();
            }
            catch
            {
               
            }
           

    }

    private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities db = new Entities();
                db.apartments.Load();
                var ap = Convert.ToInt64(DeleteId.Text);
                apartments dl = db.apartments.Where(p => p.Id == ap).FirstOrDefault();
                db.apartments.Remove(dl);
                db.SaveChanges();
            }
            catch
            {

            }
            
        }
    }
    }
