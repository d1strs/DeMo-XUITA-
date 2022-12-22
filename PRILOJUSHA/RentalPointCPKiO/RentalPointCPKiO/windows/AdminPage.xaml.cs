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
using RentalPointCPKiO.Views;
using RentalPointCPKiO.ModelEDM;

namespace RentalPointCPKiO.windows
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage(Staff user)
        {
            InitializeComponent();
            DataContext = user;
        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            View.CreateLoginPage().Show();
            Close();
        }
    }
}
