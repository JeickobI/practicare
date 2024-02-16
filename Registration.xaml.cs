using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

namespace Store_of_safety_and_security_products1
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {

        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var email = Email.Text;
            var pass = Password.Text;

            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists is not null) 
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован");
                return;
            }
            var user = new User { Login = login, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Вы зарегестрировались");
        }
    }
}