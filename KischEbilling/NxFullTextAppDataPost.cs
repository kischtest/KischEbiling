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
    
    public partial class NxFullTextAppDataPost
    {
        public System.Guid NxFullTextAppDataPostID { get; set; }
        public string ProviderCode { get; set; }
        public string ArchCode { get; set; }
        public string AttrCode { get; set; }
        public string AttrText { get; set; }
        public Nullable<int> AttrTextLanguage { get; set; }
        public string DataItemID { get; set; }
        public string NewArchCode { get; set; }
        public string NewAttrCode { get; set; }
        public Nullable<byte> IsMultiLanguage { get; set; }
        public Nullable<int> PostReason { get; set; }
        public Nullable<System.DateTime> PostTimeStamp { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.Guid> BatchID { get; set; }
        public Nullable<System.DateTime> ModifiedTimeStamp { get; set; }
        public Nullable<System.DateTime> ErrorTimeStamp { get; set; }
        public Nullable<int> ErrorReason { get; set; }
        public Nullable<int> ErrorCount { get; set; }
        public Nullable<System.Guid> MessageID { get; set; }
        public Nullable<System.DateTime> AssignedTimeStamp { get; set; }
    }
}
