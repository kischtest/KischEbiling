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
    
    public partial class MxAP
    {
        public System.Guid MxAPID { get; set; }
        public string VouchersThruDateOption { get; set; }
        public Nullable<System.DateTime> VouchersThruDate { get; set; }
        public string AsOfDateOption { get; set; }
        public Nullable<System.DateTime> AsOfDate { get; set; }
        public string ReportDateCode { get; set; }
        public string VendorSelectionCode { get; set; }
        public Nullable<int> OverAmount { get; set; }
        public string VendorPred { get; set; }
        public string PayeePred { get; set; }
        public string VoucherPred { get; set; }
        public Nullable<System.DateTime> CurrencyAsOfDate { get; set; }
        public byte IsBalancingIntegrityRun { get; set; }
        public string BalancingPeriod { get; set; }
        public string BalancingPeriodOption { get; set; }
    }
}