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
    
    public partial class CftSearchComment
    {
        public System.Guid CftSearchCommentsID { get; set; }
        public Nullable<System.Guid> CftSearchAssessment { get; set; }
        public Nullable<System.Guid> CftReviewer { get; set; }
        public Nullable<System.Guid> CftNewBizRequest { get; set; }
        public Nullable<System.DateTime> CftDateTime { get; set; }
        public string CftComments { get; set; }
        public Nullable<System.Guid> CftSearch { get; set; }
        public int CftSearchCommentsIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<int> CftNBISearch { get; set; }
        public Nullable<int> CftNBISearchResult { get; set; }
        public string CftNBIComments { get; set; }
        public string CftNBIComments_UnformattedText { get; set; }
        public Nullable<System.Guid> RouteSelectJoinID { get; set; }
    
        public virtual CftNewBizRequest CftNewBizRequest1 { get; set; }
        public virtual CftSearchAssessment CftSearchAssessment1 { get; set; }
        public virtual NxUser NxUser { get; set; }
    }
}
