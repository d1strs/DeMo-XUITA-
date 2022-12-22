using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPointCPKiO.windows;

namespace ClassLibrary
{
    public class View
    {
        public static AdminPage createAdminPage(){
            return new AdminPage();
        }
        public static StarshiySmenbIPage StarshiySmenbIPage()
        {
            return new StarshiySmenbIPage();
        }
        public static ProdavecPage ProdavecPage()
        {
            return new ProdavecPage();
        }

    }
}
