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
using RentalPointCPKiO.ModelEDM;
using RentalPointCPKiO.Views;
using RentalPointCPKiO.DataBase;

namespace RentalPointCPKiO.windows
{
    /// <summary>
    /// Логика взаимодействия для ProdavecPage.xaml
    /// </summary>
    public partial class ProdavecPage : Window
    {

        public ProdavecPage(Staff user)
        {
            InitializeComponent();

            OrdersDataGrid.ItemsSource = Entity.DB.DemoEntities.Orders.ToList();

            DataContext = user;
        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            View.CreateLoginPage().Show();
            Close();
        }

        private void buttonShowClients_Click(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            Clients.Visibility = Visibility.Visible;
            Clients.ItemsSource = Entity.DB.DemoEntities.Clients.ToList();
        }

        private void buttonShowOrders_Click(object sender, RoutedEventArgs e)
        {
            Clients.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Visible;
            Clients.ItemsSource = Entity.DB.DemoEntities.Orders.ToList();
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.SelectedItem = null;

            var selectedOrder = (sender as Button).DataContext as Orders;
            View.EditOrderPage(selectedOrder, this).Show();
        }
        private void Orders_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            OrdersDataGrid.SelectedItem = null;
        }
    }
}
