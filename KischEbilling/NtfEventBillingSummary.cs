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
    
    public partial class NtfEventBillingSummary
    {
        public System.Guid NtfEventBillingSummaryID { get; set; }
        public Nullable<decimal> FeeAmount { get; set; }
        public Nullable<decimal> CostAmount { get; set; }
        public Nullable<decimal> ChargeAmount { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public string BillingSummaryPredicate { get; set; }
        public Nullable<int> LastIndexRetrieved { get; set; }
        public Nullable<int> DaysOpen { get; set; }
    }
}
