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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Page
    {
        public EditUser()
        {
            InitializeComponent();
        }

        User user;
        public EditUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "" || password.Password == "")
            {
                MessageBox.Show("Поля должны быть заполнены");
                return;
            }

            if (username.Text != user.Username)
            {
                User user = Singleton.DB.User.FirstOrDefault(u => u.Username == username.Text);
                if (user != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                    return;
                }
            }

            if (password.Password.Length < 7)
            {
                MessageBox.Show("Пароль должен быть на менее 7 символов");
                return;
            }

            user.Username = username.Text;
            user.Password = password.Password;
            user.Role = role.SelectedItem as Role;

            Singleton.DB.SaveChanges();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new Test());
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new Test());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            role.ItemsSource = Singleton.DB.Role.ToList();
            if(user != null)
            {
                username.Text = user.Username;
                password.Password = user.Password;
                role.SelectedItem = user.Role;
            }
        }
    }
}
