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
    
    public partial class ExpTypeMap
    {
        public System.Guid ExpTypeMapID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CostType { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public byte IsQuantityEntry { get; set; }
        public byte IsDescriptionRequired { get; set; }
        public byte IsAirFare { get; set; }
        public byte IsHotel { get; set; }
        public byte IsMeals { get; set; }
        public byte IsGeneral { get; set; }
        public byte IsCarRental { get; set; }
        public byte IsLocationRequired { get; set; }
    }
}
