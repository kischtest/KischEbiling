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
    
    public partial class MxWIPRun
    {
        public System.Guid MxWIPRunID { get; set; }
        public string WorkThruDateOption { get; set; }
        public Nullable<System.DateTime> WorkThruDate { get; set; }
        public string BillsThruDateOption { get; set; }
        public Nullable<System.DateTime> BillsThruDate { get; set; }
        public string ReportValues { get; set; }
        public string CurrencyRate { get; set; }
        public byte IsIncludeBillable { get; set; }
        public byte IsIncludeNB { get; set; }
        public byte IsIncludeFees { get; set; }
        public byte IsIncludeCosts { get; set; }
        public byte IsIncludeCharges { get; set; }
        public byte IsProforma { get; set; }
        public byte IsIncludeActiveOnly { get; set; }
        public string MatterPred { get; set; }
        public string MattDatePred { get; set; }
        public string TkprDatePred { get; set; }
        public string TimeCardPred { get; set; }
        public string CostCardPred { get; set; }
        public string ChrgCardPred { get; set; }
        public string MatterSelectionCode { get; set; }
        public Nullable<int> OverAmount { get; set; }
        public byte IsAddWorkingTkpr { get; set; }
        public string MetricTkprSplitList { get; set; }
        public byte IsBalancingIntegrityRun { get; set; }
        public string BalancingPeriod { get; set; }
        public string BalancingPeriodOption { get; set; }
        public byte IsReportWorkValues { get; set; }
        public byte IsReportWIPValues { get; set; }
        public byte IsReportRefValues { get; set; }
        public byte IsReportStdValues { get; set; }
        public byte IsWIPChargesOnly { get; set; }
        public byte IsVoucherValues { get; set; }
        public byte IsIncludeBillBeforeWork { get; set; }
    }
}
