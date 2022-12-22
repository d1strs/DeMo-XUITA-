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
using RentalPointCPKiO.Views;
using RentalPointCPKiO.ModelEDM;

namespace RentalPointCPKiO.windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            int loh = int.Parse(loginBox.Text);
            var user = DataBase.Entity.DB.DemoEntities.OrdersOfServices.Where(p => p.Orders.IdClient == loh);

            foreach (OrdersOfServices ordersOfServices in user)
            {
                MessageBox.Show($"{ordersOfServices.Services.Name}");
            }
            /*var user = DataBase.Entity.DB.DemoEntities.Staff.Where(p => p.Password == passBox.Password && p.Login == loginBox.Text).FirstOrDefault();

            if (user != null)
            {
                if (user.Post == 1)
                {
                    View.createAdminPage(user).Show();
                    Close();

                    MessageBox.Show($"{user.Roles.Role}");
                }
                else if (user.Post == 2)
                {
                    View.StarshiySmenbIPage(user).Show();
                    Close();

                    MessageBox.Show($"{user.Roles.Role}");
                }
                else if (user.Post == 3)
                {
                    View.ProdavecPage(user).Show();
                    Close();

                    MessageBox.Show($"{user.Roles.Role}");
                }
            }
            else {
                MessageBox.Show("login or parol ne veren");
            }*/
        }

        private void showPass_Checked(object sender, RoutedEventArgs e)
        {
            visiblePassBox.Text = passBox.Password;
            boxPass.Visibility = Visibility.Collapsed;
            boxVisibilePass.Visibility = Visibility.Visible;
        }

        private void showPass_Unchecked(object sender, RoutedEventArgs e)
        {
            passBox.Password = visiblePassBox.Text;
            boxVisibilePass.Visibility = Visibility.Collapsed;
            boxPass.Visibility = Visibility.Visible;
        }
    }
}
