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
    
    public partial class DataExportWorksheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataExportWorksheet()
        {
            this.DataExportWorksheetContents = new HashSet<DataExportWorksheetContent>();
            this.DataImportChildProcesses = new HashSet<DataImportChildProcess>();
        }
    
        public System.Guid DataExportWorksheetID { get; set; }
        public byte BaselineCodes { get; set; }
        public byte Required { get; set; }
        public byte ConversionFactor { get; set; }
        public string Definition { get; set; }
        public string Definition_UnformattedText { get; set; }
        public string Spreadsheet { get; set; }
        public Nullable<System.Guid> Process { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxFWKAppObject NxFWKAppObject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataExportWorksheetContent> DataExportWorksheetContents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataImportChildProcess> DataImportChildProcesses { get; set; }
    }
}
