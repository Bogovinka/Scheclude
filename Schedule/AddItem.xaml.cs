﻿using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
