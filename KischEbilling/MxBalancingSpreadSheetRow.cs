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
    
    public partial class MxBalancingSpreadSheetRow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MxBalancingSpreadSheetRow()
        {
            this.MxBalancingSSRowSQLs = new HashSet<MxBalancingSSRowSQL>();
        }
    
        public System.Guid MxBalancingSpreadSheetRowID { get; set; }
        public string Name { get; set; }
        public string MxReportPeriods { get; set; }
        public string GLTypePredicate { get; set; }
        public string GLNaturalPredicate { get; set; }
        public string SubLedgerQuery { get; set; }
        public System.Guid MxBalancingSpreadSheet { get; set; }
        public byte IsActive { get; set; }
        public string GLNaturalWhere { get; set; }
        public string MaskNameList { get; set; }
        public string SubLedgerQueryNarr { get; set; }
        public string SubLedgerQueryNarr_UnformattedText { get; set; }
        public string MxCurrencyRatesList { get; set; }
        public string GLUnitPredicate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual MxBalancingSpreadSheet MxBalancingSpreadSheet1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxBalancingSSRowSQL> MxBalancingSSRowSQLs { get; set; }
    }
}