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
    
    public partial class NxAttachment
    {
        public System.Guid NxAttachmentID { get; set; }
        public System.Guid ParentItemID { get; set; }
        public string ParentArchetypeCode { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string SyncID { get; set; }
        public string TypeCode { get; set; }
        public string DMSDraft { get; set; }
        public string DMSDocumentID { get; set; }
        public Nullable<byte> ReportPrint { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ExtendedAtts { get; set; }
        public string SubFolder { get; set; }
    }
}
