//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika.Avdeev.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseApplication
    {
        public int PurchaseApplicationID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public int SupplyAgentID { get; set; }
    
        public virtual User User { get; set; }
    }
}
