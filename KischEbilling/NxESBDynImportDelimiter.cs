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
    
    public partial class NxESBDynImportDelimiter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxESBDynImportDelimiter()
        {
            this.NxBizTalkBTServersGroups = new HashSet<NxBizTalkBTServersGroup>();
            this.NxESBDynImportFieldLists = new HashSet<NxESBDynImportFieldList>();
            this.NxIntegrationImportDynamicFormats = new HashSet<NxIntegrationImportDynamicFormat>();
        }
    
        public System.Guid NxESBDynImportDelimiterID { get; set; }
        public string Name { get; set; }
        public string DelimiterString { get; set; }
        public Nullable<byte> IsRecordDelimiter { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkBTServersGroup> NxBizTalkBTServersGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxESBDynImportFieldList> NxESBDynImportFieldLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationImportDynamicFormat> NxIntegrationImportDynamicFormats { get; set; }
    }
}
