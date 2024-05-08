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
    /// Логика взаимодействия для LigIn.xaml
    /// </summary>
    public partial class LigIn : Page
    {
        public LigIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = Singleton.DB.User.FirstOrDefault(u =>
                u.Username == username.Text
                && u.Password == password.Password);

            if (user == null)
            {
                MessageBox.Show("Не верный логин или пароль");
            }
            else
            {
                if (user.RoleID == 1)
                {
                    MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                    mainWindow.frame.Navigate(new Test());
                }
                else if (user.RoleID == 2)
                {
                    MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                    mainWindow.frame.Navigate(new Roles());
                }
                else
                {
                    MessageBox.Show("Неизвестная роль");
                }
            }
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.frame.Navigate(new Registration());
        }
    }
}
