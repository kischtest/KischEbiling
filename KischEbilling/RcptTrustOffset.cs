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
    
    public partial class RcptTrustOffset
    {
        public System.Guid RcptTrustOffsetID { get; set; }
        public int RcptMaster { get; set; }
        public System.Guid TrustReceipt { get; set; }
        public System.Guid RcptGL { get; set; }
        public string Currency { get; set; }
        public System.DateTime CurrDate { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> CashJournal { get; set; }
        public string ReconStatusList { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual RcptGL RcptGL1 { get; set; }
    }
}
