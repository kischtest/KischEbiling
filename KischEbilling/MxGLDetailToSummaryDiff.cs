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
    
    public partial class MxGLDetailToSummaryDiff
    {
        public System.Guid MxGLDetailToSummaryDiffID { get; set; }
        public string FiscalYearPred { get; set; }
        public Nullable<int> PeriodNumber { get; set; }
        public byte IsAllPeriods { get; set; }
        public string PeriodNumberPred { get; set; }
        public string NxUnit { get; set; }
        public string UnitPred { get; set; }
        public byte IsGLDetailToSummary { get; set; }
        public byte IsSummaryToGLDetail { get; set; }
        public byte IsBothGLDetailAndSummary { get; set; }
        public string SummaryActionList { get; set; }
        public byte IsDeleteCjeTcje { get; set; }
        public byte IsRebuildAllGLSummaries { get; set; }
        public byte IsRunBackground { get; set; }
        public byte IsGLUnitSumm { get; set; }
        public byte IsGLRpt1Summ { get; set; }
        public byte IsGLRpt2Summ { get; set; }
        public byte IsGLRpt3Summ { get; set; }
        public byte IsGLTranSummTran { get; set; }
        public byte IsGLTranSummUnit { get; set; }
        public byte IsGLTranSummFirm { get; set; }
        public byte IsGLTranSummRpt1 { get; set; }
        public byte IsGLTranSummRpt2 { get; set; }
        public byte IsGLTranSummRpt3 { get; set; }
        public byte IsGLFirmSumm { get; set; }
        public byte IsIncludeOpeningBalance { get; set; }
        public byte IsDeleteBackUp { get; set; }
        public byte DoValidate { get; set; }
        public byte DoRebuild { get; set; }
        public byte DoValidateRepair { get; set; }
        public byte UseExistingCJE { get; set; }
    }
}
