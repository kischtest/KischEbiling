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
    
    public partial class RcptInvoiceDetTime
    {
        public System.Guid RcptInvoiceDetTimeID { get; set; }
        public int TimeBill { get; set; }
        public System.Guid RcptInvoiceMatter { get; set; }
        public string RcptCurrency { get; set; }
        public Nullable<System.DateTime> RcptDate { get; set; }
        public Nullable<decimal> RcptAmt { get; set; }
        public Nullable<int> RcptTkpr { get; set; }
        public string InvCurrency { get; set; }
        public Nullable<decimal> InvRcptAmt { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual RcptInvoiceMatter RcptInvoiceMatter1 { get; set; }
    }
}
