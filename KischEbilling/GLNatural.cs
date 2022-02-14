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
    
    public partial class GLNatural
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GLNatural()
        {
            this.ChrgTypes = new HashSet<ChrgType>();
            this.ChrgTypes1 = new HashSet<ChrgType>();
            this.ChrgTypes2 = new HashSet<ChrgType>();
            this.CostTypes = new HashSet<CostType>();
            this.CostTypes1 = new HashSet<CostType>();
            this.CostTypes2 = new HashSet<CostType>();
            this.FACategories = new HashSet<FACategory>();
            this.FACategories1 = new HashSet<FACategory>();
            this.FACategories2 = new HashSet<FACategory>();
            this.FACategories3 = new HashSet<FACategory>();
            this.FACategories4 = new HashSet<FACategory>();
            this.FACategories5 = new HashSet<FACategory>();
            this.FACategories6 = new HashSet<FACategory>();
            this.FACategories7 = new HashSet<FACategory>();
            this.FACategories8 = new HashSet<FACategory>();
            this.GLAccts = new HashSet<GLAcct>();
            this.GLAcctMasks = new HashSet<GLAcctMask>();
            this.GLDetailSubledgerInqs = new HashSet<GLDetailSubledgerInq>();
            this.GLDetailSubledgerInqs1 = new HashSet<GLDetailSubledgerInq>();
            this.GLLocals = new HashSet<GLLocal>();
            this.GLNaturalAccesses = new HashSet<GLNaturalAccess>();
            this.GLOfficeIntercoes = new HashSet<GLOfficeInterco>();
            this.GLProjects = new HashSet<GLProject>();
            this.GLRenumbers = new HashSet<GLRenumber>();
            this.GLRenumbers1 = new HashSet<GLRenumber>();
            this.GLSubledgerTypes = new HashSet<GLSubledgerType>();
            this.GLUnits = new HashSet<GLUnit>();
            this.GLUnits1 = new HashSet<GLUnit>();
            this.GLUnits2 = new HashSet<GLUnit>();
            this.GLUnits3 = new HashSet<GLUnit>();
            this.GLUnits4 = new HashSet<GLUnit>();
            this.GLUnitLocals = new HashSet<GLUnitLocal>();
            this.MaskOverrideTypes = new HashSet<MaskOverrideType>();
            this.MaskOverrideValues = new HashSet<MaskOverrideValue>();
            this.MaskOverrideValues1 = new HashSet<MaskOverrideValues1>();
            this.MxAVRFinancials = new HashSet<MxAVRFinancial>();
            this.MxAVRFinancials1 = new HashSet<MxAVRFinancial>();
            this.MxBalanceSpreadSheetRows = new HashSet<MxBalanceSpreadSheetRow>();
            this.MxBalancingSSRowSQLs = new HashSet<MxBalancingSSRowSQL>();
            this.MxGLBudgets = new HashSet<MxGLBudget>();
            this.MxGLBudgets1 = new HashSet<MxGLBudget>();
            this.MxGLDetails = new HashSet<MxGLDetail>();
            this.MxGLDetails1 = new HashSet<MxGLDetail>();
            this.MxGLDetailByDates = new HashSet<MxGLDetailByDate>();
            this.MxGLDetailByDates1 = new HashSet<MxGLDetailByDate>();
            this.MxGLDetailByDateRuns = new HashSet<MxGLDetailByDateRun>();
            this.MxGLDetailByDateRuns1 = new HashSet<MxGLDetailByDateRun>();
            this.MxGLDetailSubledgerInqRuns = new HashSet<MxGLDetailSubledgerInqRun>();
            this.MxGLSummaries = new HashSet<MxGLSummary>();
            this.MxGLSummaries1 = new HashSet<MxGLSummary>();
            this.MxGLSummaryRuns = new HashSet<MxGLSummaryRun>();
            this.MxGLSummaryRuns1 = new HashSet<MxGLSummaryRun>();
            this.Payees = new HashSet<Payee>();
            this.Payees1 = new HashSet<Payee>();
            this.TaxCodes = new HashSet<TaxCode>();
            this.TaxCodes1 = new HashSet<TaxCode>();
            this.TaxCodes2 = new HashSet<TaxCode>();
            this.TaxDates = new HashSet<TaxDate>();
            this.TimeTypes = new HashSet<TimeType>();
            this.TimeTypes1 = new HashSet<TimeType>();
            this.TimeTypes2 = new HashSet<TimeType>();
            this.TkprGLNaturals = new HashSet<TkprGLNatural>();
            this.TkprGLNaturals1 = new HashSet<TkprGLNatural>();
            this.TkprGLNaturals2 = new HashSet<TkprGLNatural>();
            this.TransactionTypes = new HashSet<TransactionType>();
            this.TransactionTypes1 = new HashSet<TransactionType>();
            this.TransactionTypes2 = new HashSet<TransactionType>();
            this.TransactionTypes3 = new HashSet<TransactionType>();
            this.TransactionTypes4 = new HashSet<TransactionType>();
            this.TransactionTypes5 = new HashSet<TransactionType>();
            this.XVALNaturals = new HashSet<XVALNatural>();
        }
    
        public System.Guid GLNaturalID { get; set; }
        public string GLNat { get; set; }
        public string Description { get; set; }
        public string GLAcctCategoryList { get; set; }
        public byte IsControl { get; set; }
        public byte IsStat { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public byte IsSubledger { get; set; }
        public string GLAcctClass { get; set; }
        public Nullable<byte> IsAutoAdd { get; set; }
        public byte IsAggregate { get; set; }
        public string Definition { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgType> ChrgTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgType> ChrgTypes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgType> ChrgTypes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostType> CostTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostType> CostTypes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostType> CostTypes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACategory> FACategories8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLAcct> GLAccts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLAcctMask> GLAcctMasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLDetailSubledgerInq> GLDetailSubledgerInqs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLDetailSubledgerInq> GLDetailSubledgerInqs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLLocal> GLLocals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLNaturalAccess> GLNaturalAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLOfficeInterco> GLOfficeIntercoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLProject> GLProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLRenumber> GLRenumbers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLRenumber> GLRenumbers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLSubledgerType> GLSubledgerTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnit> GLUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnit> GLUnits1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnit> GLUnits2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnit> GLUnits3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnit> GLUnits4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GLUnitLocal> GLUnitLocals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaskOverrideType> MaskOverrideTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaskOverrideValue> MaskOverrideValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaskOverrideValues1> MaskOverrideValues1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxAVRFinancial> MxAVRFinancials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxAVRFinancial> MxAVRFinancials1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxBalanceSpreadSheetRow> MxBalanceSpreadSheetRows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxBalancingSSRowSQL> MxBalancingSSRowSQLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLBudget> MxGLBudgets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLBudget> MxGLBudgets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetail> MxGLDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetail> MxGLDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetailByDate> MxGLDetailByDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetailByDate> MxGLDetailByDates1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetailByDateRun> MxGLDetailByDateRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetailByDateRun> MxGLDetailByDateRuns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLDetailSubledgerInqRun> MxGLDetailSubledgerInqRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLSummary> MxGLSummaries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLSummary> MxGLSummaries1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLSummaryRun> MxGLSummaryRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MxGLSummaryRun> MxGLSummaryRuns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payee> Payees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payee> Payees1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxCode> TaxCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxCode> TaxCodes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxCode> TaxCodes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaxDate> TaxDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeType> TimeTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeType> TimeTypes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeType> TimeTypes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TkprGLNatural> TkprGLNaturals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TkprGLNatural> TkprGLNaturals1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TkprGLNatural> TkprGLNaturals2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionType> TransactionTypes5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XVALNatural> XVALNaturals { get; set; }
    }
}
