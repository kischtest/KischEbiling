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
    
    public partial class MattRate
    {
        public System.Guid MattRateID { get; set; }
        public int Matter { get; set; }
        public string Rate { get; set; }
        public Nullable<decimal> MaxHours { get; set; }
        public Nullable<decimal> MaxBillAmt { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public byte IsActive { get; set; }
        public string RefRate { get; set; }
        public Nullable<System.Guid> RateGroup { get; set; }
        public Nullable<decimal> MaxFees { get; set; }
        public Nullable<decimal> MaxHCo { get; set; }
        public Nullable<decimal> MaxSCo { get; set; }
        public Nullable<decimal> MaxInt { get; set; }
        public Nullable<decimal> MaxBOA { get; set; }
        public Nullable<decimal> MaxTax { get; set; }
        public Nullable<decimal> MaxOth { get; set; }
        public byte IsEnforceMaximums { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual RateExc RateExc { get; set; }
    }
}
