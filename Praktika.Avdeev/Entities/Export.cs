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
    
    public partial class Export
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Export()
        {
            this.MineralReport = new HashSet<MineralReport>();
        }
    
        public int ExportID { get; set; }
        public int MineralsID { get; set; }
        public int Weight { get; set; }
        public int ContractID { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual Minerals Minerals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MineralReport> MineralReport { get; set; }
    }
}
