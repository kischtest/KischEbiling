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
    
    public partial class MattMinType
    {
        public System.Guid MattMinTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> MinFees { get; set; }
        public Nullable<decimal> MinCosts { get; set; }
        public Nullable<decimal> MinCharges { get; set; }
        public Nullable<decimal> MinTotal { get; set; }
        public byte IsMeetAllCriteria { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
    }
}
