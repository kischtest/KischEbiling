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
    
    public partial class MxARRun
    {
        public System.Guid MxARRunID { get; set; }
        public string BillsThruDateOption { get; set; }
        public Nullable<System.DateTime> BillsThruDate { get; set; }
        public string PaymentsThruDateOption { get; set; }
        public Nullable<System.DateTime> PaymentsThruDate { get; set; }
        public byte IsIncludeUnallocated { get; set; }
        public byte IsIncludeReverse { get; set; }
        public byte IsExcludeDoubtful { get; set; }
        public string ArMatterCode { get; set; }
        public string MatterSelectionCode { get; set; }
        public Nullable<int> OverAmount { get; set; }
        public string MatterPred { get; set; }
        public string InvoicePred { get; set; }
        public string MattDatePred { get; set; }
        public string WorkTkprPred { get; set; }
        public string TimeCardPred { get; set; }
        public string CostCardPred { get; set; }
        public string ChrgCardPred { get; set; }
        public byte IsIncWorkTkpr { get; set; }
        public Nullable<decimal> RoundTolerance { get; set; }
        public string MetricTkprSplitList { get; set; }
        public string CurrencyRate { get; set; }
        public byte IsBalancingIntegrityRun { get; set; }
        public string BalancingPeriod { get; set; }
        public string BalancingPeriodOption { get; set; }
        public byte IsIncludeVolumeDiscount { get; set; }
        public byte IsVoucherValues { get; set; }
    }
}
