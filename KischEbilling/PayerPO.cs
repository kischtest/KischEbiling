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
    
    public partial class PayerPO
    {
        public System.Guid PayerPOID { get; set; }
        public string Office { get; set; }
        public string NxUnit { get; set; }
        public int BillSite { get; set; }
        public Nullable<int> ShipSite { get; set; }
        public Nullable<int> ContactEntity { get; set; }
        public Nullable<int> Phone { get; set; }
        public string ShipMethod { get; set; }
        public int BillEntity { get; set; }
        public Nullable<int> ShipEntity { get; set; }
        public string PayerRecordTypeList { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}