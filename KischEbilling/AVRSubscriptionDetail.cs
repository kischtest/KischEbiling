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
    
    public partial class AVRSubscriptionDetail
    {
        public System.Guid AVRSubscriptionDetailsID { get; set; }
        public int SubscriptionDetailsIndex { get; set; }
        public Nullable<int> AVRSubscription { get; set; }
        public Nullable<System.Guid> NxBaseUser { get; set; }
        public Nullable<int> AVRReportCatalog { get; set; }
        public Nullable<System.Guid> NxFWKAppObject { get; set; }
        public Nullable<byte> IsBrowserRole { get; set; }
        public Nullable<byte> IsContentManagerRole { get; set; }
        public Nullable<byte> IsMyReprotsRole { get; set; }
        public Nullable<byte> IsPublisherRole { get; set; }
        public Nullable<byte> IsReportBuilderRole { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser1 { get; set; }
        public virtual NxFWKAppObject NxFWKAppObject1 { get; set; }
    }
}
