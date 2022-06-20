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

        }
        public void SchecludeCreatePn()
        {
            AddItem aI = new AddItem();
            aI.ShowDialog();
            if (aI.DialogResult == true)
            {
                // Создать нового покупателя
                Items item = new Items
                {
                    Name_Item = $"{aI.addItemsText.Text}"
                };
                db.Item.Add(item);

                // Сохранить изменения в базе данных
                db.SaveChanges();
            }
        }
    }
}
