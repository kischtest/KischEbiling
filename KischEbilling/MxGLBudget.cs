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
    
    public partial class MxGLBudget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MxGLBudget()
        {
            this.MxGLBudgetDetails = new HashSet<MxGLBudgetDetail>();
            this.MxGLBudgetGLAcctDetails = new HashSet<MxGLBudgetGLAcctDetail>();
        }
    
        public System.Guid MxGLBudgetID { get; set; }
        public System.Guid GLBudgetVersion { get; set; }
        public Nullable<int> FiscalYear { get; set; }
        public string GLBook { get; set; }
        public System.Guid GLSummaryList { get; set; }
        public int PeriodNumber { get; set; }
        public Nullable<int> GLAcct { get; set; }
        public Nullable<System.Guid> GLNaturalLow { get; set; }
        public Nullable<System.Guid> GLNaturalHigh { get; set; }
        public Nullable<System.Guid> GLArrangementLow { get; set; }
        public Nullable<System.Guid> GLArrangementHigh { get; set; }
        public Nullable<System.Guid> GLUnitLow { get; set; }
        public Nullable<System.Guid> GLUnitHigh { get; set; }
        public Nullable<System.Guid> GLOfficeLow { get; set; }
        public Nullable<System.Guid> GLOfficeHigh { get; set; }
        public Nullable<System.Guid> GLDepartmentLow { get; set; }
        public Nullable<System.Guid> GLDepartmentHigh { get; set; }
        public Nullable<System.Guid> GLPracticeGroupLow { get; set; }
        public Nullable<System.Guid> GLPracticeGroupHigh { get; set; }
        public Nullable<System.Guid> GLSectionLow { get; set; }
        public Nullable<System.Guid> GLSectionHigh { get; set; }
        public Nullable<System.Guid> GLTimekeeperLow { get; set; }
        public Nullable<System.Guid> GLTimekeeperHigh { get; set; }
        public Nullable<System.Guid> GLTitleLow { get; set; }
        public Nullable<System.Guid> GLTitleHigh { get; set; }
        public Nullable<System.Guid> GLUnitLocalLow { get; set; }
        public Nullable<System.Guid> GLUnitLocalHigh { get; set; }
        public Nullable<System.Guid> GLWorkTypeLow { get; set; }
        public Nullable<System.Guid> GLWorkTypeHigh { get; set; }
        public string GLTypeFilter { get; set; }
        public Nullable<int> RespTkpr { get; set; }
        public Nullable<System.Guid> PriorGLBudgetVersion { get; set; }
        public Nullable<int> PriorFiscalYear { get; set; }
        public byte IsTreatCreditsNegative { get; set; }
        public Nullable<System.Guid> GLActivityLow { get; set; }
        public Nullable<System.Guid> GLActivityHigh { get; set; }
    
        public virtual GLActivity GLActivity { get; set; }
        public virtual GLActivity GLActivity1 { get; set; }
        public virtual GLArrangement GLArrangement { get; set; }
        public virtual GLArrangement GLArrangement1 { get; set; }
        public virtual GLBudgetVersion GLBudgetVersion1 { get; set; }
        public virtual GLBudgetVersion GLBudgetVersion2 { get; set; }
        public virtual GLDepartment GLDepartment { get; set; }
        public virtual GLDepartment GLDepartment1 { get; set; }
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural1 { get; set; }
        public virtual GLOffice GLOffice { get; set; }
        public virtual GLOffice GLOffice1 { get; set; }
        public virtual GLPracticeGroup GLPracticeGroup { get; set; }
        public virtual GLPracticeGroup GLPracticeGroup1 { get; set; }
        public virtual GLSection GLSection { get; set; }
        public virtual GLSection GLSection1 { get; set; }
        public virtual GLSummaryList GLSummaryList1 { get; set; }
        public virtual GLTimekeeper GLTimekeeper { get; set; }
        public virtual GLTimekeeper GLTimekeeper1 { get; set; }
        public virtual GLTitle GLTitle { get; set; }
        public virtual GLTitle GLTitle1 { get; set; }
        public virtual GLUnit GLUnit { get; set; }
        public virtual GLUnit GLUnit1 { get; set; }
        public virtual GLUnitLocal GLUnitLocal { get; set; }
        public virtual GLUnitLocal GLUnitLocal1 { get; set; }
        public virtual GLWorkType GLWorkType { get; set; }
        public virtual GLWorkType GLWorkType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLBudgetDetail> MxGLBudgetDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLBudgetGLAcctDetail> MxGLBudgetGLAcctDetails { get; set; }
    }
}
