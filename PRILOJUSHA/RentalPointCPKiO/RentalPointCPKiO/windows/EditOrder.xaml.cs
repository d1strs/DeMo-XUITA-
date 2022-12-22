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
using RentalPointCPKiO.DataBase;

namespace RentalPointCPKiO.windows
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class EditOrder : Window
    {
        ProdavecPage prodavecPage;
        Orders orders;
        public EditOrder(Orders orders, ProdavecPage prodavecPage)
        {
            InitializeComponent();
            this.prodavecPage = prodavecPage;
            this.orders = orders;

            DataCreate.Text = orders.DateCloseSplit.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataCreate.Text == null)
            {
                orders.DateClose = null;
            }
            else
            {
                orders.Status = "Закрыта";
                orders.DateClose = DateTime.Parse(DataCreate.Text);
            }
            orders.DateClose = DateTime.Parse(DataCreate.Text);

            prodavecPage.OrdersDataGrid.ItemsSource = Entity.DB.DemoEntities.Orders.ToList();
            Entity.DB.DemoEntities.SaveChanges();
            Close();
        }
    }
}
