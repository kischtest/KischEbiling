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
    
    public partial class NtfEventGLBudget
    {
        public System.Guid NtfEventGLBudgetID { get; set; }
        public Nullable<decimal> BudgetPctGreater { get; set; }
        public Nullable<decimal> BudgetPctLess { get; set; }
        public Nullable<decimal> BudgetAmtGreater { get; set; }
        public Nullable<decimal> BudgetAmtLess { get; set; }
        public Nullable<decimal> ActualAmtGreater { get; set; }
        public Nullable<decimal> ActualAmtLess { get; set; }
        public string NtfDateRangeList { get; set; }
        public string GLBudgetPredicate { get; set; }
    }
}
