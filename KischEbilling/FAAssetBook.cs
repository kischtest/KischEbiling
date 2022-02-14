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
    
    public partial class FAAssetBook
    {
        public System.Guid FAAssetBookID { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrencyDate { get; set; }
        public int Asset { get; set; }
        public string Book { get; set; }
        public Nullable<System.DateTime> InServiceDate { get; set; }
        public Nullable<int> LifeYearQnt { get; set; }
        public Nullable<int> LifeMonthQnt { get; set; }
        public Nullable<decimal> SalvageAmount { get; set; }
        public Nullable<System.DateTime> ReversedDate { get; set; }
        public Nullable<System.DateTime> RemovedDate { get; set; }
        public Nullable<decimal> DeprCost { get; set; }
        public Nullable<System.DateTime> FullyDeprDate { get; set; }
        public int AssetBookIndex { get; set; }
        public Nullable<byte> IsOptOutBonus { get; set; }
        public Nullable<byte> IsAlternativeDepr { get; set; }
        public string FAZone { get; set; }
        public Nullable<System.DateTime> ZoneStartDate { get; set; }
        public Nullable<System.DateTime> ZoneEndDate { get; set; }
        public string AssetBookName { get; set; }
        public string FADeprMethod { get; set; }
        public Nullable<decimal> DeprRate { get; set; }
        public string FAConvention { get; set; }
        public System.DateTime TranDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
