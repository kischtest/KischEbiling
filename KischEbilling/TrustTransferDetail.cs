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
    
    public partial class TrustTransferDetail
    {
        public System.Guid TrustTransferDetailID { get; set; }
        public int TrustTransferDetIndex { get; set; }
        public int TrustTransfer { get; set; }
        public int BankAcctTrust { get; set; }
        public int Matter { get; set; }
        public string TrustIntendedUse { get; set; }
        public Nullable<int> TrustIntendedUseInfo { get; set; }
        public string TrustIntendedUseDet { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<byte> IsSource { get; set; }
        public string Comments { get; set; }
        public Nullable<int> CashJournal { get; set; }
        public string ReconStatusList { get; set; }
    }
}