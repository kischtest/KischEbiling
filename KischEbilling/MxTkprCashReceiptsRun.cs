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
    
    public partial class MxTkprCashReceiptsRun
    {
        public System.Guid MxTkprCashReceiptsRunID { get; set; }
        public string ARMatterCode { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyType { get; set; }
        public string CurrencyCalcDate { get; set; }
        public Nullable<byte> IsCurrentValues { get; set; }
        public string ReportOnDate { get; set; }
        public string ReportingPeriod { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ReportingPeriod2 { get; set; }
        public Nullable<System.DateTime> StartDate2 { get; set; }
        public Nullable<System.DateTime> EndDate2 { get; set; }
        public string ReportingPeriod3 { get; set; }
        public Nullable<System.DateTime> StartDate3 { get; set; }
        public Nullable<System.DateTime> EndDate3 { get; set; }
        public Nullable<byte> IsIncludeReversals { get; set; }
        public Nullable<byte> IsIncludeWriteOffs { get; set; }
        public string ReqTkprs { get; set; }
        public string MetricTkprSplitList { get; set; }
    }
}
