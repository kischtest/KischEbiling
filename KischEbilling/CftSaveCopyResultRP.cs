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
    
    public partial class CftSaveCopyResultRP
    {
        public System.Guid CftSaveCopyResultRPID { get; set; }
        public System.Guid CftSaveCopySearchResult { get; set; }
        public string EntityName { get; set; }
        public string RPStatus { get; set; }
        public string Role { get; set; }
        public string Relationship { get; set; }
        public string Narrative { get; set; }
        public string Narrative_UnformattedText { get; set; }
        public int EntityIndex { get; set; }
        public int CftSaveCopyResultRPIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CftSaveCopySearchResult CftSaveCopySearchResult1 { get; set; }
    }
}
