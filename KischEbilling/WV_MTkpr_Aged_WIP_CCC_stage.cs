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
    
    public partial class WV_MTkpr_Aged_WIP_CCC_stage
    {
        public System.Guid WV_MTkpr_Aged_WIP_CCC_stageID { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public string WV_TkprType { get; set; }
        public Nullable<int> Matter { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> Age1 { get; set; }
        public Nullable<decimal> Age2 { get; set; }
        public Nullable<decimal> Age3 { get; set; }
        public Nullable<decimal> Age4 { get; set; }
        public Nullable<decimal> Age5 { get; set; }
        public Nullable<decimal> Age6 { get; set; }
        public Nullable<decimal> Age7 { get; set; }
        public Nullable<System.Guid> AgingScheme { get; set; }
        public Nullable<decimal> FeeAmt { get; set; }
        public Nullable<decimal> HCoAmt { get; set; }
        public Nullable<decimal> SCoAmt { get; set; }
        public Nullable<decimal> BOAAmt { get; set; }
        public Nullable<decimal> TaxAmt { get; set; }
        public Nullable<decimal> IntAmt { get; set; }
        public Nullable<decimal> OthAmt { get; set; }
        public Nullable<decimal> WIPTotal { get; set; }
        public Nullable<int> Client { get; set; }
        public string Currency { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual AgingSchemeBucket AgingSchemeBucket { get; set; }
    }
}
