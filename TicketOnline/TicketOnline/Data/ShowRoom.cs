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
    
    public partial class ShowRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShowRoom()
        {
            this.RoomDetails = new HashSet<RoomDetail>();
        }
    
        public int showRoomID { get; set; }
        public string showRoomName { get; set; }
        public int rowSeatNumber { get; set; }
        public int seatName { get; set; }
        public int cinemaID { get; set; }
    
        public virtual Cinema Cinema { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomDetail> RoomDetails { get; set; }
    }
}
