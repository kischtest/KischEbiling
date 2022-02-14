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
    
    public partial class TimeType
    {
        public System.Guid TimeTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Rate { get; set; }
        public string TimeEntryUnit { get; set; }
        public byte IsWriteOffLateTime { get; set; }
        public string Narrative { get; set; }
        public string Narrative_UnformattedText { get; set; }
        public string TransactionType { get; set; }
        public string BillOnceList { get; set; }
        public string ChrgType { get; set; }
        public Nullable<System.Guid> GLNatural1 { get; set; }
        public Nullable<System.Guid> GLNatural2 { get; set; }
        public Nullable<System.Guid> GLNatural3 { get; set; }
        public byte IsFlatFee { get; set; }
        public byte IsDoNotBillUntilComplete { get; set; }
        public Nullable<System.Guid> LangDescription { get; set; }
        public Nullable<decimal> OverridePercent { get; set; }
    
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural4 { get; set; }
        public virtual GLNatural GLNatural5 { get; set; }
    }
}