//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoService_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployesSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployesSet()
        {
            this.OrdersSet = new HashSet<OrdersSet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public int Id_Profession { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual ProfessionsSet ProfessionsSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersSet> OrdersSet { get; set; }
    }
}
