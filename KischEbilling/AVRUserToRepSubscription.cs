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
    
    public partial class AVRUserToRepSubscription
    {
        public System.Guid AVRUserToRepSubscriptionsID { get; set; }
        public System.Guid AVRUserSubscriptions { get; set; }
        public int AVRUserToRepSubscriptionsIndex { get; set; }
        public Nullable<byte> IsBrowser { get; set; }
        public Nullable<byte> IsContentManager { get; set; }
        public Nullable<byte> IsMyReports { get; set; }
        public Nullable<byte> IsPublisher { get; set; }
        public Nullable<byte> IsReportBuilder { get; set; }
        public int AVRReportCatalog { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual AVRUserSubscription AVRUserSubscription { get; set; }
    }
}
