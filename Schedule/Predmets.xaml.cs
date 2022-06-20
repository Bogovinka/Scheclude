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
    /// Логика взаимодействия для Predmets.xaml
    /// </summary>
    public partial class Predmets : Window
    {
        public class ItemContext : DbContext
        {
            public ItemContext() : base("Database1Entities")
            {

            }
            public DbSet<Items> Item { get; set; }
        }
        ItemContext db;
        public Predmets()
        {
            InitializeComponent();
            db = new ItemContext();
            db.Item.Load(); // загружаем данные
            itemsDG.ItemsSource = db.Item.Local.ToBindingList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddItem aI = new AddItem();
            aI.ShowDialog();
            if(aI.DialogResult == true)
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
        private void rel_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (itemsDG.SelectedItems.Count > 0)
            {
                for (int i = 0; i < itemsDG.SelectedItems.Count; i++)
                {
                    Items item = itemsDG.SelectedItems[i] as Items;
                    if (item != null)
                    {
                        db.Item.Remove(item);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
