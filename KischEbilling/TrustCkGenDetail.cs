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
    
    public partial class TrustCkGenDetail
    {
        public System.Guid TrustCkGenDetailID { get; set; }
        public int BankAcctTrust { get; set; }
        public string Currency { get; set; }
        public string TrustDsbmtPred { get; set; }
        public string PayeePred { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<int> Matter { get; set; }
        public int TrustCkGen { get; set; }
        public Nullable<int> TrustDisbursement { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
