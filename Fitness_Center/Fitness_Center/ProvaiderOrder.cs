//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitness_Center
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProvaiderOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProvaiderOrder()
        {
            this.ProductProvaiderOrder = new HashSet<ProductProvaiderOrder>();
        }
    
        public int id { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Provaiderid { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<decimal> total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProvaiderOrder> ProductProvaiderOrder { get; set; }
        public virtual Provaider Provaider { get; set; }
    }
}