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
    
    public partial class ExpCCEmployee
    {
        public System.Guid ExpCCEmployeeID { get; set; }
        public int CCEmpIndex { get; set; }
        public int ExpCCHeader { get; set; }
        public string CardHolderName { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<decimal> TransactionLimit { get; set; }
        public string SpouseName { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<System.DateTime> CycleDate { get; set; }
        public Nullable<decimal> CurrentBalance { get; set; }
        public Nullable<decimal> PreviousBalance { get; set; }
        public Nullable<decimal> CurrentDue { get; set; }
        public Nullable<decimal> PastDue { get; set; }
        public Nullable<int> NumberOfCards { get; set; }
        public Nullable<decimal> DisputeAmount { get; set; }
        public Nullable<System.DateTime> LastPaymentDate { get; set; }
        public Nullable<decimal> LastPaymentAmount { get; set; }
        public string BillingType { get; set; }
        public Nullable<decimal> AnnualFees { get; set; }
        public string AccountStatus { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public string Currency { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
