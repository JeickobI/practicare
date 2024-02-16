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

namespace Store_of_safety_and_security_products1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter1_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var password = Password.Text;

            var context = new AppDbContext();

            var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (user is null) 
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            else
            {
                var win = new Personal_account();
                win.Show();
                this.Close();
            }
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {
            var win = new Registration();
            win.Show();
            this.Close();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
