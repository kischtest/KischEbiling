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
    
    public partial class CmParentEvent
    {
        public System.Guid CmParentEventID { get; set; }
        public int CmParentIndex { get; set; }
        public byte IsAlternate { get; set; }
        public byte IsGeneratedFrom { get; set; }
        public byte IsCreateWhenDone { get; set; }
        public Nullable<int> GeneratedEvent { get; set; }
        public System.Guid ParentDocketingID { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
