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
    
    public partial class MxTimeKeeperSummary
    {
        public System.Guid MxTimeKeeperSummaryID { get; set; }
        public string DateRange { get; set; }
        public byte IsUseTransactionMonth { get; set; }
        public byte IsUseAccountingPeriod { get; set; }
        public string TimekeeperPred { get; set; }
        public Nullable<System.DateTime> CurrencyAsOfDate { get; set; }
        public Nullable<System.DateTime> AdHoc1StartDate { get; set; }
        public Nullable<System.DateTime> AdHoc1EndDate { get; set; }
        public Nullable<System.DateTime> AdHoc2StartDate { get; set; }
        public Nullable<System.DateTime> AdHoc2EndDate { get; set; }
        public Nullable<System.DateTime> CurrencyAsOfDateWIPAR { get; set; }
        public string CurrencyCalcDateWIPAR { get; set; }
        public string TkprDatePred { get; set; }
    }
}
