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
    
    public partial class BalHistAPBalancing
    {
        public System.Guid BalHistAPBalancingID { get; set; }
        public string Period { get; set; }
        public string Currency { get; set; }
        public string RecordType { get; set; }
        public string RecordSource { get; set; }
        public byte IsDifference { get; set; }
        public Nullable<int> Voucher { get; set; }
        public Nullable<int> CkMaster { get; set; }
        public Nullable<int> Payee { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
