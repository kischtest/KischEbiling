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
    
    public partial class MxUnreconItem
    {
        public System.Guid MxUnreconItemsID { get; set; }
        public int BankGroup { get; set; }
        public int BankStmt { get; set; }
        public Nullable<System.Guid> BankRecWorkHdr { get; set; }
        public System.DateTime ReportEndDate { get; set; }
        public System.DateTime AsOfDate { get; set; }
        public string GLBook { get; set; }
        public Nullable<System.DateTime> ReversalExcludeDate { get; set; }
        public Nullable<decimal> StmtEndingBal { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
    
        public virtual BankRecWorkHdr BankRecWorkHdr1 { get; set; }
    }
}
