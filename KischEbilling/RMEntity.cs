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
    
    public partial class RMEntity
    {
        public System.Guid RMEntityID { get; set; }
        public int EntityIndex { get; set; }
        public string RMEntityTypeList { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> Entity { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public Nullable<System.Guid> NxUser { get; set; }
        public byte IsAllowCirculate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
    
        public virtual NxUser NxUser1 { get; set; }
    }
}
