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
    
    public partial class NxIntegrationImport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxIntegrationImport()
        {
            this.NxBizTalkActiveDirectories = new HashSet<NxBizTalkActiveDirectory>();
            this.NxBizTalkCurrencies = new HashSet<NxBizTalkCurrency>();
            this.NxIntegrationDuplicateNotifies = new HashSet<NxIntegrationDuplicateNotify>();
            this.NxIntegrationImportDbs = new HashSet<NxIntegrationImportDb>();
            this.NxIntegrationImportFileFormats = new HashSet<NxIntegrationImportFileFormat>();
            this.NxIntegrationNVImportPairGroups = new HashSet<NxIntegrationNVImportPairGroup>();
        }
    
        public System.Guid NxIntegrationImportID { get; set; }
        public Nullable<int> NxIntegration { get; set; }
        public string Description { get; set; }
        public Nullable<int> BatchSize { get; set; }
        public Nullable<int> BatchInterval { get; set; }
        public Nullable<System.Guid> Role { get; set; }
        public byte IsActive { get; set; }
        public byte IsDefault { get; set; }
        public System.Guid ImportType { get; set; }
        public Nullable<byte> IsRequestResponse { get; set; }
        public Nullable<byte> IsSynchronous { get; set; }
        public string ResponseURL { get; set; }
        public Nullable<decimal> CobraVersion { get; set; }
        public string CobraURL { get; set; }
        public string DateFormat { get; set; }
        public Nullable<byte> RequiresPostTransform { get; set; }
        public byte StockConfigItem { get; set; }
        public Nullable<byte> IsCheckingForDuplicates { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<System.Guid> ESBServerGroupID { get; set; }
        public Nullable<byte> IsLoadingAddtionalConfigurationFrom3E { get; set; }
        public Nullable<byte> IsUsingGLAccountSegmentConfiguration { get; set; }
        public Nullable<System.Guid> RoutingOption { get; set; }
        public Nullable<System.Guid> RoutingRole { get; set; }
        public Nullable<byte> IsRequestingChildAutoCreationSuppresion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkActiveDirectory> NxBizTalkActiveDirectories { get; set; }
        public virtual NxBizTalkBTServersGroup NxBizTalkBTServersGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkCurrency> NxBizTalkCurrencies { get; set; }
        public virtual NxESBRouteOption NxESBRouteOption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationDuplicateNotify> NxIntegrationDuplicateNotifies { get; set; }
        public virtual NxIntegrationImportType NxIntegrationImportType { get; set; }
        public virtual NxRole NxRole { get; set; }
        public virtual NxRole NxRole1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationImportDb> NxIntegrationImportDbs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationImportFileFormat> NxIntegrationImportFileFormats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationNVImportPairGroup> NxIntegrationNVImportPairGroups { get; set; }
    }
}
