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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var db = new Entities();
            db.agents.Load();
            var delete = db.agents.Local.Where(p => p.Id == Convert.ToInt32(DeleteId.Text)).FirstOrDefault();
            db.agents.Remove(delete);
            db.SaveChanges();
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            var db = new Entities();
            var agent = new agents();
            agent.FirstName = FN.Text;
            agent.MiddleName = MN.Text;
            agent.LastName = LN.Text;
            agent.DealShare = Convert.ToInt32(DS.Text);
            db.agents.Add(agent);
            db.SaveChanges();


        }



        private void Update(object sender, RoutedEventArgs e)
        {
            var db = new Entities();
            db.agents.Load();
            var agentUpdate = db.agents.Local.Where(p => p.Id == Convert.ToInt32(UpdateId.Text)).FirstOrDefault();
           
            agentUpdate.FirstName = FN1.Text;
            agentUpdate.MiddleName = MN1.Text;
            agentUpdate.LastName = LN2.Text;
            agentUpdate.DealShare = Convert.ToInt32(DS1.Text); ;
            db.SaveChanges();
        }
    }
}
