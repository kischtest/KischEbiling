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
    
    public partial class TrustAllocation
    {
        public System.Guid TrustAllocationID { get; set; }
        public int TrustAllocIndex { get; set; }
        public int BankAcctTrust { get; set; }
        public int Matter { get; set; }
        public string TrustIntededUse { get; set; }
        public Nullable<int> TrustIntendedUseInfo { get; set; }
        public string TrustIntendedUseDet { get; set; }
        public decimal Amount { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
