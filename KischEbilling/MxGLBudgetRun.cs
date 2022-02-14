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
    
    public partial class MxGLBudgetRun
    {
        public System.Guid MxGLBudgetRunID { get; set; }
        public Nullable<System.Guid> GLBudgetVersion { get; set; }
        public Nullable<int> FiscalYear { get; set; }
        public string GLBook { get; set; }
        public Nullable<System.Guid> GLSummaryList { get; set; }
        public Nullable<int> PeriodNumber { get; set; }
        public Nullable<int> GLAcct { get; set; }
        public string GLNaturalLow { get; set; }
        public string GLNaturalHigh { get; set; }
        public string GLArrangementLow { get; set; }
        public string GLArrangementHigh { get; set; }
        public string GLUnitLow { get; set; }
        public string GLUnitHigh { get; set; }
        public string GLOfficeLow { get; set; }
        public string GLOfficeHigh { get; set; }
        public string GLDepartmentLow { get; set; }
        public string GLDepartmentHigh { get; set; }
        public string GLPracticeGroupLow { get; set; }
        public string GLPracticeGroupHigh { get; set; }
        public string GLSectionLow { get; set; }
        public string GLSectionHigh { get; set; }
        public string GLTimekeeperLow { get; set; }
        public string GLTimekeeperHigh { get; set; }
        public string GLTitleLow { get; set; }
        public string GLTitleHigh { get; set; }
        public string GLUnitLocalLow { get; set; }
        public string GLUnitLocalHigh { get; set; }
        public string GLWorkTypeLow { get; set; }
        public string GLWorkTypeHigh { get; set; }
        public string GLTypeFilter { get; set; }
        public Nullable<int> RespTkpr { get; set; }
        public Nullable<System.Guid> PriorGLBudgetVersion { get; set; }
        public Nullable<int> PriorFiscalYear { get; set; }
        public byte IsTreatCreditsNegative { get; set; }
        public string GLActivityLow { get; set; }
        public string GLActivityHigh { get; set; }
    
        public virtual GLBudgetVersion GLBudgetVersion1 { get; set; }
        public virtual GLBudgetVersion GLBudgetVersion2 { get; set; }
        public virtual GLSummaryList GLSummaryList1 { get; set; }
    }
}
