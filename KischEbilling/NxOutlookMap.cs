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
    
    public partial class NxOutlookMap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxOutlookMap()
        {
            this.NxOutlookMap1 = new HashSet<NxOutlookMap>();
            this.NxOutlookQuickLinks = new HashSet<NxOutlookQuickLink>();
        }
    
        public System.Guid NxOutlookMapID { get; set; }
        public string ProfileName { get; set; }
        public string AddObject { get; set; }
        public string ViewObject { get; set; }
        public string DeleteLink { get; set; }
        public Nullable<System.Guid> SyncMap { get; set; }
        public Nullable<byte> DeleteObject { get; set; }
        public System.Guid OutlookType { get; set; }
        public Nullable<byte> AttachOutlookItem { get; set; }
        public Nullable<System.Guid> TagMap { get; set; }
        public Nullable<System.Guid> Category { get; set; }
        public string RegionCaption { get; set; }
        public Nullable<System.Guid> AttachmentSyncMap { get; set; }
        public Nullable<System.Guid> MasterSyncMap { get; set; }
        public Nullable<System.Guid> TagApplyOutlookMap { get; set; }
        public string DeleteConfirmationMessage { get; set; }
        public string Description { get; set; }
        public string DesyncConfirmationMessage { get; set; }
        public Nullable<byte> ShipToClient { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxOutlookCategory NxOutlookCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxOutlookMap> NxOutlookMap1 { get; set; }
        public virtual NxOutlookMap NxOutlookMap2 { get; set; }
        public virtual NxOutlookTag NxOutlookTag { get; set; }
        public virtual NxSyncMap NxSyncMap { get; set; }
        public virtual NxSyncMap NxSyncMap1 { get; set; }
        public virtual NxSyncMap NxSyncMap2 { get; set; }
        public virtual NxSyncType NxSyncType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxOutlookQuickLink> NxOutlookQuickLinks { get; set; }
    }
}
