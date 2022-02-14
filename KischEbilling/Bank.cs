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
    
    public partial class Bank
    {
        public System.Guid BankID { get; set; }
        public int BankIndex { get; set; }
        public string Name { get; set; }
        public string BankNum { get; set; }
        public string BranchNum { get; set; }
        public int Entity { get; set; }
        public int Site { get; set; }
        public string FedReserveRouting { get; set; }
        public byte IsPositivePay { get; set; }
        public Nullable<System.Guid> PositivePayTemplate { get; set; }
        public string PaymentFileMask { get; set; }
        public Nullable<int> PaymentFileNextNum { get; set; }
        public Nullable<System.DateTime> PaymentFileResetDate { get; set; }
        public string RemittanceFileMask { get; set; }
        public Nullable<int> RemittanceFileNextNum { get; set; }
        public Nullable<System.DateTime> RemittanceFileResetDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string TrustFileMask { get; set; }
        public Nullable<int> TrustFileNextNum { get; set; }
        public Nullable<System.DateTime> TrustFileResetDate { get; set; }
        public byte IsPositivePayTrust { get; set; }
        public Nullable<System.Guid> PositivePayTrustTemplate { get; set; }
    
        public virtual NxPrinterTemplate NxPrinterTemplate { get; set; }
        public virtual NxPrinterTemplate NxPrinterTemplate1 { get; set; }
    }
}
