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
    
    public partial class CftSaveCopyResultMatterLink
    {
        public System.Guid CftSaveCopyResultMatterLinksID { get; set; }
        public System.Guid CftSaveCopyResultEntity { get; set; }
        public int ClientIndex { get; set; }
        public int MatterIndex { get; set; }
        public Nullable<System.Guid> CftRelatedPartyID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string MatterStatus { get; set; }
        public string Role { get; set; }
        public string Relationship { get; set; }
        public int CftSaveCopyResultMatterLinksIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CftSaveCopyResultEntity CftSaveCopyResultEntity1 { get; set; }
    }
}