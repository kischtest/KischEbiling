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
    
    public partial class RateGlobalChangeCurrency
    {
        public System.Guid RateGlobalChangeCurrencyID { get; set; }
        public System.Guid RateGlobalChangeInfo { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> ChangeAmt { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<decimal> ChangePct { get; set; }
        public string RoundingMethod { get; set; }
        public Nullable<decimal> RateAmt { get; set; }
    
        public virtual RateGlobalChangeInfo RateGlobalChangeInfo1 { get; set; }
    }
}
