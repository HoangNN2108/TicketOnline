//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketOnline.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleTicket()
        {
            this.TicketDetails = new HashSet<TicketDetail>();
        }
    
        public int saleTicketID { get; set; }
        public string saleTicketName { get; set; }
        public double percent { get; set; }
        public int saleType { get; set; }
        public int dayType { get; set; }
        public bool status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketDetail> TicketDetails { get; set; }
    }
}
