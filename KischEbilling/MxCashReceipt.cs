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
    
    public partial class MxCashReceipt
    {
        public System.Guid MxCashReceiptsID { get; set; }
        public Nullable<byte> IsIncludeReversals { get; set; }
        public string ArMatterCode { get; set; }
        public Nullable<byte> IsIncludeWriteOffs { get; set; }
        public string ReqMatters { get; set; }
        public byte IsIncludeReceipts { get; set; }
        public Nullable<System.DateTime> CurrencyAsOfDate { get; set; }
        public string MetricTkprSplitList { get; set; }
        public string ReqMattDate { get; set; }
    }
}
