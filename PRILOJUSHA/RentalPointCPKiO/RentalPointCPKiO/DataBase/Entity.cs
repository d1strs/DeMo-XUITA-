using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalPointCPKiO.ModelEDM;
using RentalPointCPKiO;

namespace RentalPointCPKiO.DataBase
{
    public class Entity
    {
        public DemoEntities DemoEntities = new DemoEntities();

        public static Entity DB = new Entity();
    }
}
