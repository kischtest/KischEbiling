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
    
    public partial class cftFilterStateUserBased
    {
        public System.Guid cftFilterStateUserBasedID { get; set; }
        public int cftFilterStateIndex { get; set; }
        public Nullable<int> cftFilterId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string ProcessName { get; set; }
        public string status { get; set; }
        public Nullable<byte> IsOwner { get; set; }
        public Nullable<System.DateTime> dateLastApplied { get; set; }
        public string comments { get; set; }
        public Nullable<byte> IsApplied { get; set; }
        public string CftSearchFilter { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string CftSearchType { get; set; }
    
        public virtual NxUser NxUser { get; set; }
    }
}
