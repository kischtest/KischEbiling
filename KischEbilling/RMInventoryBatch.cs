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
    
    public partial class RMInventoryBatch
    {
        public System.Guid RMInventoryBatchID { get; set; }
        public int InvBatchIndex { get; set; }
        public Nullable<System.DateTime> LoadDateTime { get; set; }
        public Nullable<int> RMEntity { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateTimeScanned { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
