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
    
    public partial class login_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public login_data()
        {
            this.otzov3 = new HashSet<otzov3>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<otzov3> otzov3 { get; set; }
    }
}
