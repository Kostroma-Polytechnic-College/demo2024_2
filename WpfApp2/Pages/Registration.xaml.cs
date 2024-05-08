using System;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text == "" || password.Password == "")
            {
                MessageBox.Show("Поля должны быть заполнены");
                return;
            }

            User user = Singleton.DB.User.FirstOrDefault(u=>u.Username == username.Text);
            if(user != null)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                return;
            }

            if(password.Password != confirmPassword.Password)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if(password.Password.Length < 7)
            {
                MessageBox.Show("Пароль должен быть на менее 7 символов");
                return;
            }

            Singleton.DB.User.Add(new User() {
                Username = username.Text,
                Password = password.Password,
                RoleID = 2
            });
            Singleton.DB.SaveChanges();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new Roles());
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new LigIn());
        }
    }
}
