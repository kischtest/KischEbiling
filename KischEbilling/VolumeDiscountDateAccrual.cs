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
    
    public partial class VolumeDiscountDateAccrual
    {
        public System.Guid VolumeDiscountDateAccrualID { get; set; }
        public int ProfMaster { get; set; }
        public int InvMaster { get; set; }
        public Nullable<int> RcptMaster { get; set; }
        public decimal Amount { get; set; }
        public string ChrgType { get; set; }
        public string RcptType { get; set; }
        public string AdjType { get; set; }
        public Nullable<System.Guid> VolumeDiscountGroupDate { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> IncreaseAmt { get; set; }
        public byte IsClosing { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual VolumeDiscountGroupDate VolumeDiscountGroupDate1 { get; set; }
    }
}