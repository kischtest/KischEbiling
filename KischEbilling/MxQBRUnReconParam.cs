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
    
    public partial class MxQBRUnReconParam
    {
        public System.Guid MxQBRUnReconParamID { get; set; }
        public int BankGroup { get; set; }
        public int Bankstmt { get; set; }
        public string GLBook { get; set; }
        public System.DateTime BeginDate { get; set; }
        public Nullable<decimal> StmtEndingBal { get; set; }
        public Nullable<System.DateTime> StmtEndDate { get; set; }
        public Nullable<byte> UseGLDate { get; set; }
        public Nullable<byte> UseTranDate { get; set; }
        public Nullable<byte> IncludeVoidedChecksAfterStmtEndDate { get; set; }
    }
}
