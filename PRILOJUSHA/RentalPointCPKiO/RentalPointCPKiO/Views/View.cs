using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPointCPKiO.windows;
using RentalPointCPKiO.ModelEDM;

namespace RentalPointCPKiO.Views
{
    class View
    {
        public static EditOrder EditOrderPage(Orders orders, ProdavecPage prodavecPage)
        {
            return new EditOrder(orders, prodavecPage);
        }
        public static LoginPage CreateLoginPage()
        {
            return new LoginPage();
        }
        public static AdminPage createAdminPage(Staff user)
        {
            return new AdminPage(user);
        }
        public static StarshiySmenbIPage StarshiySmenbIPage(Staff user)
        {
            return new StarshiySmenbIPage(user);
        }
        public static ProdavecPage ProdavecPage(Staff user)
        {
            return new ProdavecPage(user);
        }
    }
}
