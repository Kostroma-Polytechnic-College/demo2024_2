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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Roles.xaml
    /// </summary>
    public partial class Roles : Page
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new LigIn());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            table.ItemsSource = Singleton.DB.Role.ToList();
        }
    }
}
