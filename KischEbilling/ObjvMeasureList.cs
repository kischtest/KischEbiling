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
    
    public partial class ObjvMeasureList
    {
        public System.Guid ObjvMeasureListID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public byte IsVendor { get; set; }
        public byte IsMatterTkpr { get; set; }
        public byte IsGL { get; set; }
        public byte IsCurrencyBased { get; set; }
        public Nullable<byte> IsBillSumWork { get; set; }
        public Nullable<byte> IsBillSumBill { get; set; }
        public Nullable<byte> IsBillSumRcpt { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public byte IsStock { get; set; }
    }
}
