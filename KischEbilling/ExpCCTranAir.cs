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
    
    public partial class ExpCCTranAir
    {
        public System.Guid ExpCCTranAirID { get; set; }
        public string PassengerName { get; set; }
        public Nullable<System.DateTime> DepartureDate { get; set; }
        public string DepartureCity { get; set; }
        public string TravelAgencyCode { get; set; }
        public string TravelAgencyName { get; set; }
        public string TicketNumber { get; set; }
        public Nullable<decimal> FareBasis { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public string DestinationCity { get; set; }
        public string CarrierCode { get; set; }
        public string ServiceClass { get; set; }
        public string StopoverCode { get; set; }
        public string DetailNumber { get; set; }
    }
}
