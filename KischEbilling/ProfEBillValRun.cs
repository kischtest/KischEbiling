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
    
    public partial class ProfEBillValRun
    {
        public System.Guid ProfEBillValRunID { get; set; }
        public int ProfEBillValRunIndex { get; set; }
        public int ProfMaster { get; set; }
        public Nullable<int> ProfDetail { get; set; }
        public Nullable<System.Guid> ProfAdjustDetail { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public string EBillStageList { get; set; }
        public Nullable<System.Guid> EBillValListRules { get; set; }
        public string Message { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string BillingRules { get; set; }
    }
}
