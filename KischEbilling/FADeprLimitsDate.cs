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
    
    public partial class FADeprLimitsDate
    {
        public System.Guid FADeprLimitsDateID { get; set; }
        public System.Guid FADeprLimitsLkUp { get; set; }
        public System.DateTime InServiceEffectiveDate { get; set; }
        public string Currency { get; set; }
        public decimal FirstYearAmt { get; set; }
        public decimal SecondYearAmt { get; set; }
        public decimal ThirdYearAmt { get; set; }
        public decimal FourthYearAmt { get; set; }
        public Nullable<decimal> FifthYearAmt { get; set; }
        public Nullable<decimal> SixthYearAmt { get; set; }
        public Nullable<decimal> SeventhYearAmt { get; set; }
        public Nullable<decimal> EighthYearAmt { get; set; }
        public Nullable<decimal> NinthYearAmt { get; set; }
        public Nullable<decimal> TenthYearAmt { get; set; }
        public Nullable<System.DateTime> NxEndDate { get; set; }
        public Nullable<System.DateTime> NxStartDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual FADeprLimit FADeprLimit { get; set; }
    }
}