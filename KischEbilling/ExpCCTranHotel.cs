//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KischEbilling
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpCCTranHotel
    {
        public System.Guid ExpCCTranHotelID { get; set; }
        public string HotelName { get; set; }
        public Nullable<decimal> RoomRate { get; set; }
        public Nullable<decimal> RoomTax { get; set; }
        public Nullable<decimal> RoomPhone { get; set; }
        public Nullable<decimal> RoomOther { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> NumberOfDays { get; set; }
        public string DetailNumber { get; set; }
    }
}
