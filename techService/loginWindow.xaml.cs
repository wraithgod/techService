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
using System.Windows.Shapes;

namespace techService
{
    /// <summary>
    /// Логика взаимодействия для loginWindow.xaml
    /// </summary>
    public partial class loginWindow : Window
    {
        class User {
            string login;
            string password;
            bool isCorrect;
        }
        public loginWindow()
        {
            InitializeComponent();
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.ToString();
            string password = passBox.ToString();

            if () {
                Window mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

        }        
    }
}
