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
    
    public partial class Adj1099
    {
        public System.Guid Adj1099ID { get; set; }
        public int Adj1099Index { get; set; }
        public int Payee { get; set; }
        public string Flag1099 { get; set; }
        public System.DateTime AdjDate { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public byte IsTrust { get; set; }
        public string Reason { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
