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
    
    public partial class MxReconItemsRun
    {
        public System.Guid MxReconItemsRunID { get; set; }
        public Nullable<int> BankGroup { get; set; }
        public Nullable<int> BankStmt { get; set; }
        public Nullable<System.Guid> BankRecWorkHdr { get; set; }
        public Nullable<System.DateTime> ReconStartDate { get; set; }
        public Nullable<System.DateTime> ReconEndDate { get; set; }
        public Nullable<System.DateTime> AsOfDate { get; set; }
        public Nullable<byte> IsGLDateUsed { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
    
        public virtual BankRecWorkHdr BankRecWorkHdr1 { get; set; }
    }
}
