//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjcompAPI.Models
{
    using System;
    using System.Collections.Generic;
    

    
    
    public partial class MyOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyOrder()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        
    
        public int OrderID { get; set; }
    
        public double SubTotal { get; set; }
        
        public Nullable<int> UserID { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
