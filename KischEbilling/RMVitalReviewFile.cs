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
    
    public partial class RMVitalReviewFile
    {
        public System.Guid RMVitalReviewFilesID { get; set; }
        public Nullable<System.Guid> RMVitalReview { get; set; }
        public byte IsSelected { get; set; }
        public System.DateTime DateReviewed { get; set; }
        public Nullable<System.DateTime> NextVitalReviewDate { get; set; }
        public int RMBaseFile { get; set; }
        public Nullable<int> RMParentFile { get; set; }
        public byte IsVital { get; set; }
        public byte IsPermanent { get; set; }
        public string Comments { get; set; }
        public string SortString { get; set; }
        public int RMVitalReviewFilesIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual RMVitalReview RMVitalReview1 { get; set; }
    }
}
