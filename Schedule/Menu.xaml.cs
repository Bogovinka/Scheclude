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

namespace Schedule
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public class ScheduleContext : DbContext
        {
            public ScheduleContext() : base("Database1Entities")
            {

            }
            public DbSet<Schedule_pn> Pn { get; set; }
            public DbSet<Schedule_vt> Vt { get; set; }
            public DbSet<Schedule_sr> Sr { get; set; }
            public DbSet<Schedule_ch> Cht { get; set; }
            public DbSet<Schedule_pt> Pt { get; set; }
            public DbSet<Schedule_sb> Sb { get; set; }
            public DbSet<Schedule_vs> Vs { get; set; }
        }
        ScheduleContext db;
        public Menu()
        {
            InitializeComponent();
            db = new ScheduleContext();
            db.Pn.Load(); // загружаем данные
            itemsPn.ItemsSource = db.Pn.Local.ToBindingList();
            db = new ScheduleContext();
            db.Vt.Load(); // загружаем данные
            itemsVt.ItemsSource = db.Vt.Local.ToBindingList();
            db = new ScheduleContext();
            db.Sr.Load(); // загружаем данные
            itemsSr.ItemsSource = db.Sr.Local.ToBindingList();
            db = new ScheduleContext();
            db.Cht.Load(); // загружаем данные
            itemsCht.ItemsSource = db.Cht.Local.ToBindingList();
            db = new ScheduleContext();
            db.Pt.Load(); // загружаем данные
            itemsPt.ItemsSource = db.Pt.Local.ToBindingList();
            db = new ScheduleContext();
            db.Sb.Load(); // загружаем данные
            itemsSb.ItemsSource = db.Sb.Local.ToBindingList();
            db = new ScheduleContext();
            db.Vs.Load(); // загружаем данные
            itemsVs.ItemsSource = db.Vs.Local.ToBindingList();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
