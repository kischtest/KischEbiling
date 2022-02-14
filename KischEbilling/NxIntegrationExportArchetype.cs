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
    
    public partial class NxIntegrationExportArchetype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxIntegrationExportArchetype()
        {
            this.BizTalkExportFileEvents = new HashSet<BizTalkExportFileEvent>();
            this.NxIntegrationExportConfigurations = new HashSet<NxIntegrationExportConfiguration>();
        }
    
        public System.Guid NxIntegrationExportArchetypeID { get; set; }
        public string Description { get; set; }
        public Nullable<byte> IsActive { get; set; }
        public Nullable<byte> IsDefault { get; set; }
        public Nullable<int> NxIntegration { get; set; }
        public System.Guid ExportType { get; set; }
        public Nullable<byte> ArchiveFile { get; set; }
        public string ArchiveFileLocation { get; set; }
        public Nullable<byte> IsExportAll { get; set; }
        public Nullable<byte> ExportNewAndUpdated { get; set; }
        public string ReportQueryFull { get; set; }
        public string ReportQueryUpdate { get; set; }
        public string TriggerExportFileName { get; set; }
        public string TiggerFileLocation { get; set; }
        public Nullable<System.Guid> Role { get; set; }
        public string CobraURL { get; set; }
        public byte StockConfigItem { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BizTalkExportFileEvent> BizTalkExportFileEvents { get; set; }
        public virtual NxIntegrationExportType NxIntegrationExportType { get; set; }
        public virtual NxRole NxRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationExportConfiguration> NxIntegrationExportConfigurations { get; set; }
    }
}
