//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace harley.bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class motor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public motor()
        {
            this.otzov3 = new HashSet<otzov3>();
        }
    
        public int id { get; set; }
        public string Foto { get; set; }
        public string OP { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string data { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<otzov3> otzov3 { get; set; }
    }
}
