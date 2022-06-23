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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
   
    public partial class Admin : Window
    {
        public class ItemContext : DbContext
        {
            public ItemContext() : base("Database1Entities")
            {

            }
            public DbSet<Items> Item { get; set; }
        }
        ItemContext iC;
        int countPage = 0;
        public Admin()
        {
            InitializeComponent();
        }

        private void items_Click(object sender, RoutedEventArgs e)
        {
            Predmets p = new Predmets();
            p.Show();

        }

        private void comboBox_u_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox_u = (ComboBox)sender;
            iC = new ItemContext();
            iC.Item.Load(); // загружаем данные
            comboBox_u.ItemsSource = iC.Item.Local.ToBindingList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (countPage == 6)
            {
                countPage = 0;
                Page();
            }
            else
            {
                countPage++;
                Page();
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (countPage == 0)
            {
                countPage = 6;
                Page();
            }
            else
            {
                countPage--;
                Page();
            }
        }
        public void Page()
        {
            switch (countPage)
            {
                case 0:
                    StackPanelsOff();
                    pn_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 1:
                    StackPanelsOff();
                    vt_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 2:
                    StackPanelsOff();
                    sr_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 3:
                    StackPanelsOff();
                    cht_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 4:
                    StackPanelsOff();
                    pt_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 5:
                    StackPanelsOff();
                    sb_StackPanel.Visibility = Visibility.Visible;
                    break;
                case 6:
                    StackPanelsOff();
                    vs_StackPanel.Visibility = Visibility.Visible;
                    break;

            }
        }
        public void StackPanelsOff()
        {
            pn_StackPanel.Visibility = Visibility.Hidden;
            vt_StackPanel.Visibility = Visibility.Hidden;
            sr_StackPanel.Visibility = Visibility.Hidden;
            cht_StackPanel.Visibility = Visibility.Hidden;
            pt_StackPanel.Visibility = Visibility.Hidden;
            sb_StackPanel.Visibility = Visibility.Hidden;
            vs_StackPanel.Visibility = Visibility.Hidden;
        }
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

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SchecludeCreatePn(comboBox_u1pn.Text, comboBox_u2pn.Text, comboBox_u3pn.Text, comboBox_u4pn.Text, comboBox_u5pn.Text);
            SchecludeCreateVt(comboBox_u1vt.Text, comboBox_u2vt.Text, comboBox_u3vt.Text, comboBox_u4vt.Text, comboBox_u5vt.Text);
            SchecludeCreateSr(comboBox_u1sr.Text, comboBox_u2sr.Text, comboBox_u3sr.Text, comboBox_u4sr.Text, comboBox_u5sr.Text);
            SchecludeCreateCht(comboBox_u1cht.Text, comboBox_u2cht.Text, comboBox_u3cht.Text, comboBox_u4cht.Text, comboBox_u5cht.Text);
            SchecludeCreatePt(comboBox_u1pt.Text, comboBox_u2pt.Text, comboBox_u3pt.Text, comboBox_u4pt.Text, comboBox_u5pt.Text);
            SchecludeCreateSb(comboBox_u1sb.Text, comboBox_u2sb.Text, comboBox_u3sb.Text, comboBox_u4sb.Text, comboBox_u5sb.Text);
            SchecludeCreateVs(comboBox_u1vs.Text, comboBox_u2vs.Text, comboBox_u3vs.Text, comboBox_u4vs.Text, comboBox_u5vs.Text);
        }
        public void SchecludeCreatePn(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Pn
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreateVt(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Vt
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreateSr(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Sr
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreateCht(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Cht
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreatePt(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Pt
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreateSb(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Sb
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }
        public void SchecludeCreateVs(string i1, string i2, string i3, string i4, string i5)
        {
            ScheduleContext context = new ScheduleContext();
            object[] str = { i1, i2, i3, i4, i5 };
            for (int i = 1; i <= 5; i++)
            {
                var customer = context.Vs
                    // Загрузить покупателя с фамилией "Иванов"
                    .Where(c => c.id == i)
                    .FirstOrDefault();
                customer.Item_Name = str[i - 1].ToString();
                // Сохранить изменения
                context.SaveChanges();
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
