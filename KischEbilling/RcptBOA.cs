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
    
    public partial class RcptBOA
    {
        public System.Guid RcptBOAID { get; set; }
        public int RcptMaster { get; set; }
        public int Matter { get; set; }
        public string ChrgType { get; set; }
        public System.DateTime RcptDate { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> InvMaster { get; set; }
        public string RcptCurrency { get; set; }
        public decimal RcptCurrAmount { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public string InvNumber { get; set; }
        public string TaxCode { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
