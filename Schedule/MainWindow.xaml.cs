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

namespace Schedule
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

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            WorkBD wBD = new WorkBD();
            if (wBD.UserHave(loginText.Text, passwordText.Password))
            {
                if (wBD.IsAdmin(loginText.Text)){
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                    Close();
                }
            }
            else MessageBox.Show("Такого пользователя нету");
        }
        private void passV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordText2.Text = passwordText.Password.ToString();
            passwordText.Visibility = Visibility.Hidden;
            passwordText2.Visibility = Visibility.Visible;
        }

        private void passV_MouseUp(object sender, MouseButtonEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText2.Visibility = Visibility.Hidden;
        }

        private void passV_MouseLeave(object sender, MouseEventArgs e)
        {
            passwordText.Visibility = Visibility.Visible;
            passwordText2.Visibility = Visibility.Hidden;
        }
    }
}
