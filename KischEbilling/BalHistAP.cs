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
    
    public partial class BalHistAP
    {
        public System.Guid BalHistAPID { get; set; }
        public string Period { get; set; }
        public string Currency { get; set; }
        public Nullable<int> Vendor { get; set; }
        public Nullable<int> Payee { get; set; }
        public Nullable<int> Voucher { get; set; }
        public string Invoice { get; set; }
        public Nullable<System.DateTime> InvDate { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> DiscountDate { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string APTranType { get; set; }
        public string VoucherStatus { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}