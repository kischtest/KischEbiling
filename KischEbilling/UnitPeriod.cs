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
    
    public partial class UnitPeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitPeriod()
        {
            this.AVRReportRelationshipParameters = new HashSet<AVRReportRelationshipParameter>();
            this.GLAllocations = new HashSet<GLAllocation>();
            this.JMPostErrors = new HashSet<JMPostError>();
            this.MxATTrustCashBookSummaryFinals = new HashSet<MxATTrustCashBookSummaryFinal>();
            this.MxATTrustCashBookSummaryFinalRuns = new HashSet<MxATTrustCashBookSummaryFinalRun>();
            this.MxPOProductInqBySuppliers = new HashSet<MxPOProductInqBySupplier>();
            this.MxPOProductInqBySuppliers1 = new HashSet<MxPOProductInqBySupplier>();
            this.MxPOProductInqBySuppliersRuns = new HashSet<MxPOProductInqBySuppliersRun>();
            this.MxPOProductInqBySuppliersRuns1 = new HashSet<MxPOProductInqBySuppliersRun>();
            this.PeriodStatuses = new HashSet<PeriodStatus>();
            this.RevalAsOfDates = new HashSet<RevalAsOfDate>();
            this.TrustFinalRuns = new HashSet<TrustFinalRun>();
            this.UnrealizedGainLosses = new HashSet<UnrealizedGainLoss>();
        }
    
        public System.Guid UnitPeriodID { get; set; }
        public Nullable<int> FiscalQtr { get; set; }
        public int PeriodNumber { get; set; }
        public string PeriodNameLookup { get; set; }
        public Nullable<int> CalNumber { get; set; }
        public Nullable<int> CalQtr { get; set; }
        public int CalYear { get; set; }
        public Nullable<System.DateTime> BegDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int FiscalYear { get; set; }
        public string NxUnit { get; set; }
        public string DisplayName { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRReportRelationshipParameter> AVRReportRelationshipParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLAllocation> GLAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JMPostError> JMPostErrors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxATTrustCashBookSummaryFinal> MxATTrustCashBookSummaryFinals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxATTrustCashBookSummaryFinalRun> MxATTrustCashBookSummaryFinalRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxPOProductInqBySupplier> MxPOProductInqBySuppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxPOProductInqBySupplier> MxPOProductInqBySuppliers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxPOProductInqBySuppliersRun> MxPOProductInqBySuppliersRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxPOProductInqBySuppliersRun> MxPOProductInqBySuppliersRuns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeriodStatus> PeriodStatuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RevalAsOfDate> RevalAsOfDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrustFinalRun> TrustFinalRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnrealizedGainLoss> UnrealizedGainLosses { get; set; }
    }
}
