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
    
    public partial class CollectionThresholdEvent
    {
        public System.Guid CollectionThresholdEventID { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<System.Guid> Collector { get; set; }
        public byte IsCollectorNotified { get; set; }
        public byte IsBillTkprNotified { get; set; }
        public byte IsCollectionItemThresholdUsed { get; set; }
        public Nullable<decimal> NotificationThreshold { get; set; }
        public string ThresholdCurrency { get; set; }
        public string CurrencyConversionDateType { get; set; }
        public Nullable<System.DateTime> ConversionDate { get; set; }
    
        public virtual Collector Collector1 { get; set; }
    }
}