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
    
    public partial class NxOutlookQuickLink
    {
        public System.Guid NxOutlookQuickLinkID { get; set; }
        public string Caption { get; set; }
        public string URL { get; set; }
        public int SortOrder { get; set; }
        public System.Guid ShowLink { get; set; }
        public Nullable<System.Guid> OutlookMapParent { get; set; }
        public Nullable<System.Guid> OutlookTaskPaneParent { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxOutlookMap NxOutlookMap { get; set; }
        public virtual NxOutlookQuickLinkShow NxOutlookQuickLinkShow { get; set; }
        public virtual NxOutlookTaskPaneMap NxOutlookTaskPaneMap { get; set; }
    }
}
