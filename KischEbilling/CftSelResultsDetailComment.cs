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
    
    public partial class CftSelResultsDetailComment
    {
        public System.Guid CftSelResultsDetailCommentsID { get; set; }
        public Nullable<System.Guid> CftAssessment { get; set; }
        public Nullable<System.Guid> CftReviewer { get; set; }
        public Nullable<System.DateTime> CftDateTime { get; set; }
        public string CftComments { get; set; }
        public Nullable<System.Guid> CftSelResultDetails { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CftSearchAssessment CftSearchAssessment { get; set; }
        public virtual CftSelResultDetail CftSelResultDetail { get; set; }
        public virtual NxUser NxUser { get; set; }
    }
}
