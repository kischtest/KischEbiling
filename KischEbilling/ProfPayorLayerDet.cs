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
    
    public partial class ProfPayorLayerDet
    {
        public System.Guid ProfPayorLayerDetID { get; set; }
        public System.Guid ProfPayorLayer { get; set; }
        public int Payor { get; set; }
        public int Site { get; set; }
        public int StmtSite { get; set; }
        public string ForAttentionOf { get; set; }
        public string RefNumber { get; set; }
        public byte IsDefault { get; set; }
        public decimal PctFee { get; set; }
        public decimal PctHCo { get; set; }
        public decimal PctSCo { get; set; }
        public decimal PctTax { get; set; }
        public decimal PctInt { get; set; }
        public decimal PctBOA { get; set; }
        public decimal PctOth { get; set; }
        public Nullable<decimal> AmtFee { get; set; }
        public Nullable<decimal> AmtHCo { get; set; }
        public Nullable<decimal> AmtSCo { get; set; }
        public Nullable<decimal> AmtTax { get; set; }
        public Nullable<decimal> AmtInt { get; set; }
        public Nullable<decimal> AmtBOA { get; set; }
        public Nullable<decimal> AmtOth { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string FeeRate { get; set; }
        public Nullable<decimal> PctHours { get; set; }
    
        public virtual ProfPayorLayer ProfPayorLayer1 { get; set; }
    }
}
