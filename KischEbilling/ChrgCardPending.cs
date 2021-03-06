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
    
    public partial class ChrgCardPending
    {
        public System.Guid ChrgCardPendingID { get; set; }
        public int ChrgPendIndex { get; set; }
        public string Source { get; set; }
        public Nullable<byte> IsNB { get; set; }
        public Nullable<byte> IsNoCharge { get; set; }
        public Nullable<byte> IsWIP { get; set; }
        public string WorkType { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public Nullable<System.DateTime> WorkDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Currency { get; set; }
        public string ChrgType { get; set; }
        public string PurgeType { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public Nullable<System.Guid> TkprEffDate { get; set; }
        public string Office { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<System.Guid> MattEffDate { get; set; }
        public Nullable<int> Language { get; set; }
        public string TaxCode { get; set; }
        public string TaxJurisdiction { get; set; }
        public string TransactionType { get; set; }
        public Nullable<System.Guid> Phase { get; set; }
        public Nullable<System.Guid> Task { get; set; }
        public Nullable<System.Guid> Activity { get; set; }
        public string Narrative { get; set; }
        public string Narrative_UnformattedText { get; set; }
        public string InternalComments { get; set; }
        public string LoadNumber { get; set; }
        public string LoadSource { get; set; }
        public string LoadGroup { get; set; }
        public Nullable<int> SpvTimekeeper { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<System.Guid> Phase2 { get; set; }
        public Nullable<System.Guid> Task2 { get; set; }
        public Nullable<System.Guid> Activity2 { get; set; }
    
        public virtual Activity Activity1 { get; set; }
        public virtual Activity Activity3 { get; set; }
        public virtual MattDate MattDate { get; set; }
        public virtual Phase Phase1 { get; set; }
        public virtual Phase Phase3 { get; set; }
        public virtual Task Task1 { get; set; }
        public virtual Task Task3 { get; set; }
        public virtual TkprDate TkprDate { get; set; }
    }
}
