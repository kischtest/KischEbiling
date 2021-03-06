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
    
    public partial class BankAcct
    {
        public System.Guid BankAcctID { get; set; }
        public int BankAcctIndex { get; set; }
        public string Name { get; set; }
        public int BankGroup { get; set; }
        public int Bank { get; set; }
        public string BankAcctType { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string AcctNum { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string NxUnit { get; set; }
        public string Office { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string SortString { get; set; }
        public string RollNum { get; set; }
        public string BankModuleList { get; set; }
        public Nullable<int> BankChrgGLAcct { get; set; }
        public Nullable<int> InterestGLAcct { get; set; }
        public string BankAcctStatusList { get; set; }
        public byte IsDeferCashPost { get; set; }
        public Nullable<int> SuspenseGLAcct { get; set; }
        public int CashGLAcct { get; set; }
        public Nullable<int> Language { get; set; }
        public Nullable<System.Guid> NxElecTemplate { get; set; }
        public byte IsPositivePay { get; set; }
        public Nullable<System.Guid> LangDescription { get; set; }
        public Nullable<decimal> TolerancePct { get; set; }
        public Nullable<decimal> ToleranceAmt { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public byte IsRestrictedPayment { get; set; }
    
        public virtual NxPrinterTemplate NxPrinterTemplate { get; set; }
    }
}
