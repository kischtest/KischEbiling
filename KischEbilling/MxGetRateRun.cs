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
    
    public partial class MxGetRateRun
    {
        public System.Guid MxGetRateRunID { get; set; }
        public Nullable<int> Client { get; set; }
        public string ClientPred { get; set; }
        public Nullable<byte> IsRelatedClient { get; set; }
        public Nullable<int> Matter { get; set; }
        public string MatterPred { get; set; }
        public Nullable<byte> IsRelatedMatter { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public string TimekeeperPred { get; set; }
        public Nullable<byte> IsActiveTkprOnly { get; set; }
        public Nullable<System.Guid> RateExc { get; set; }
        public string TransactionType { get; set; }
        public Nullable<byte> IsTimeType { get; set; }
        public Nullable<System.DateTime> WorkStartDate { get; set; }
        public Nullable<System.DateTime> WorkEndDate { get; set; }
    
        public virtual RateExc RateExc1 { get; set; }
    }
}