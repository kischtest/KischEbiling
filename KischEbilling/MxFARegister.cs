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
    
    public partial class MxFARegister
    {
        public System.Guid MxFARegisterID { get; set; }
        public string BalancingPeriods { get; set; }
        public string StartPeriod { get; set; }
        public string EndPeriod { get; set; }
        public Nullable<byte> IsIncludeNoDepr { get; set; }
        public Nullable<System.DateTime> InServiceStartDate { get; set; }
        public Nullable<System.DateTime> InServiceEndDate { get; set; }
        public Nullable<System.DateTime> AsOfDate { get; set; }
        public string Retired { get; set; }
        public string Leased { get; set; }
        public string AssetPred { get; set; }
        public string BookPred { get; set; }
        public byte IsNoCurrencyConv { get; set; }
        public Nullable<byte> IsActivity { get; set; }
    }
}
