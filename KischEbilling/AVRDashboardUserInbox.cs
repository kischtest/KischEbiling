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
    
    public partial class AVRDashboardUserInbox
    {
        public System.Guid AVRDashboardUserInboxID { get; set; }
        public int AVRDashboardUserInboxIndex { get; set; }
        public Nullable<System.Guid> NxBaseUser { get; set; }
        public string PathOrHisID { get; set; }
        public string Type { get; set; }
        public Nullable<int> AVRReportInstance { get; set; }
        public string AVRImages { get; set; }
        public Nullable<byte> IsRead { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string InboxType { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser1 { get; set; }
    }
}
