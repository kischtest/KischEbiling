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
    
    public partial class ReceiptEvent
    {
        public System.Guid ReceiptEventID { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Payor { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> InvMaster { get; set; }
        public byte IsInCollection { get; set; }
        public byte IsCollectorNotified { get; set; }
        public byte IsBillTkprNotified { get; set; }
        public Nullable<decimal> RcptAmt { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> ConversionDate { get; set; }
        public string CurrencyConversionDateType { get; set; }
    }
}
