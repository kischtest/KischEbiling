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
    
    public partial class FAAssetCost
    {
        public System.Guid FAAssetCostID { get; set; }
        public int FAAssetCostIndex { get; set; }
        public Nullable<System.Guid> VchrDetail { get; set; }
        public string Description { get; set; }
        public string FAComponentType { get; set; }
        public string CurrCode { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> Payee { get; set; }
        public int FAAsset { get; set; }
        public System.DateTime TranDate { get; set; }
        public byte IsCash { get; set; }
        public string OriginalCurrency { get; set; }
        public Nullable<decimal> OriginalCurrAmt { get; set; }
        public byte IsActive { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual VchrDetail VchrDetail1 { get; set; }
    }
}
