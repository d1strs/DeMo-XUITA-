//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalPointCPKiO.ModelEDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersOfServices
    {
        public int ID { get; set; }
        public Nullable<int> ID_Oreders { get; set; }
        public Nullable<int> ID_Servises { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Services Services { get; set; }
    }
}
