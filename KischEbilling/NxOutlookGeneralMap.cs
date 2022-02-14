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
    
    public partial class NxOutlookGeneralMap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxOutlookGeneralMap()
        {
            this.NxOutlookCategories = new HashSet<NxOutlookCategory>();
            this.NxOutlookGeneralMapUsers = new HashSet<NxOutlookGeneralMapUser>();
        }
    
        public System.Guid NxOutlookGeneralMapID { get; set; }
        public string InstallLocation { get; set; }
        public Nullable<byte> ForceToInstall { get; set; }
        public Nullable<System.Guid> DataUpdateVersion { get; set; }
        public string MSIVersion { get; set; }
        public Nullable<System.Guid> MessagesUpdateVersion { get; set; }
        public Nullable<System.Guid> RMMattCatTemplateUpdateVersion { get; set; }
        public Nullable<byte> AllowMultipleTimers { get; set; }
        public Nullable<int> MaxLogFileSize { get; set; }
        public Nullable<System.Guid> DefPaneAppointment { get; set; }
        public Nullable<System.Guid> DefPaneContact { get; set; }
        public Nullable<System.Guid> DefPaneMessage { get; set; }
        public Nullable<System.Guid> DefPaneTask { get; set; }
        public string LogErrorEmail { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxOutlookCategory> NxOutlookCategories { get; set; }
        public virtual NxOutlookTaskPaneMap NxOutlookTaskPaneMap { get; set; }
        public virtual NxOutlookTaskPaneMap NxOutlookTaskPaneMap1 { get; set; }
        public virtual NxOutlookTaskPaneMap NxOutlookTaskPaneMap2 { get; set; }
        public virtual NxOutlookTaskPaneMap NxOutlookTaskPaneMap3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxOutlookGeneralMapUser> NxOutlookGeneralMapUsers { get; set; }
    }
}
