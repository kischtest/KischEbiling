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
    
    public partial class MattInterestGenDetail
    {
        public System.Guid MattInterestGenDetailID { get; set; }
        public System.Guid MattInterestGen { get; set; }
        public int ARDetail { get; set; }
        public string Currency { get; set; }
        public System.DateTime CurrDate { get; set; }
        public Nullable<decimal> AccumInterest { get; set; }
        public decimal CurrentBalance { get; set; }
        public Nullable<System.DateTime> LastInterestDate { get; set; }
        public decimal NewInterest { get; set; }
        public Nullable<int> NewARDetail { get; set; }
        public byte IsGenerate { get; set; }
        public string ExcMsg { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual MattInterestGen MattInterestGen1 { get; set; }
    }
}
