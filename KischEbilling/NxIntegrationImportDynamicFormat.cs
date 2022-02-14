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
    
    public partial class NxIntegrationImportDynamicFormat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxIntegrationImportDynamicFormat()
        {
            this.NxESBDynImportFieldLists = new HashSet<NxESBDynImportFieldList>();
            this.NxESBExcelSheets = new HashSet<NxESBExcelSheet>();
            this.NxEsbImprtRteSteps = new HashSet<NxEsbImprtRteStep>();
        }
    
        public System.Guid NxIntegrationImportDynamicFormatID { get; set; }
        public string FormatName { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string ArchiveFileLocation { get; set; }
        public Nullable<System.Guid> ProcessID { get; set; }
        public Nullable<System.Guid> FormID { get; set; }
        public Nullable<System.Guid> DefaultDelimiter { get; set; }
        public Nullable<int> ESBGeneratedCount { get; set; }
        public Nullable<int> FlatFileHeaderRowCount { get; set; }
        public Nullable<System.Guid> DynImportSrceType { get; set; }
    
        public virtual NxESBDynImportDelimiter NxESBDynImportDelimiter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxESBDynImportFieldList> NxESBDynImportFieldLists { get; set; }
        public virtual NxESBDynImportSourceType NxESBDynImportSourceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxESBExcelSheet> NxESBExcelSheets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxEsbImprtRteStep> NxEsbImprtRteSteps { get; set; }
        public virtual NxFWKAppObject NxFWKAppObject { get; set; }
        public virtual NxFWKAppObject NxFWKAppObject1 { get; set; }
    }
}
