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
    
    public partial class PrftExpenseCategory
    {
        public System.Guid PrftExpenseCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string ExpenseCategoryGroup { get; set; }
        public string StartPeriod { get; set; }
        public string EndPeriod { get; set; }
        public string Currency { get; set; }
        public System.DateTime ConversionDate { get; set; }
        public byte IsDepartmentSelected { get; set; }
        public byte IsUnitSelected { get; set; }
        public byte IsOfficeSelected { get; set; }
        public byte IsSectionSelected { get; set; }
        public byte IsTimekeeperSelected { get; set; }
        public byte IsTitleSelected { get; set; }
        public Nullable<decimal> AdjustmentPercent { get; set; }
        public byte IsCostAveragedOverPeriods { get; set; }
        public byte IsStatistical { get; set; }
        public byte IsTimekeeperObjective { get; set; }
        public string ObjvMaster { get; set; }
        public string ObjvMeasureList { get; set; }
        public byte IsExpenseCategoryHours { get; set; }
        public string ExpenseCategoryHours { get; set; }
        public byte IsHoursOnly { get; set; }
        public Nullable<byte> IsNB { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}