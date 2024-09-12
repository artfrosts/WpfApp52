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

namespace RegistrationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Здесь можно добавить код для регистрации пользователя
                MessageBox.Show("Регистрация прошла успешно!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.");
            }
        }
    }
}