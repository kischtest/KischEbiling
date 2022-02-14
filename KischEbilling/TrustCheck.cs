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
    
    public partial class TrustCheck
    {
        public System.Guid TrustCheckID { get; set; }
        public int TrustChkIndex { get; set; }
        public System.DateTime TranDate { get; set; }
        public System.DateTime PostDate { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public int BankAcctTrust { get; set; }
        public string Currency { get; set; }
        public System.DateTime CurrDate { get; set; }
        public decimal Amount { get; set; }
        public byte IsVoided { get; set; }
        public Nullable<byte> IsVoidJournal { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public Nullable<int> VoidCheck { get; set; }
        public string VoidReason { get; set; }
        public Nullable<System.Guid> CheckPrnTemplate { get; set; }
        public string CkNum { get; set; }
        public string CheckType { get; set; }
        public string ReconStatusList { get; set; }
        public string PayeeName { get; set; }
        public string OnBehalf { get; set; }
        public string AuthorizedBy { get; set; }
        public Nullable<int> ClearDays { get; set; }
        public Nullable<System.DateTime> ClearDate { get; set; }
        public string VoidComment { get; set; }
        public Nullable<int> CashJournal { get; set; }
        public Nullable<int> RequestedBy { get; set; }
        public string Office { get; set; }
        public Nullable<int> Language { get; set; }
        public string ConversionRefNum { get; set; }
        public byte IsEFT { get; set; }
        public Nullable<System.DateTime> EFTBankDate { get; set; }
        public Nullable<int> TrustCkMaster { get; set; }
        public Nullable<int> PayeeSite { get; set; }
        public string PayeeAddr { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<int> PositivePayTrust { get; set; }
    
        public virtual NxPrinterTemplate NxPrinterTemplate { get; set; }
    }
}
