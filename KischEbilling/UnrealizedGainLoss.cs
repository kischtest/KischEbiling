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
    
    public partial class UnrealizedGainLoss
    {
        public System.Guid UnrealizedGainLossID { get; set; }
        public string Description { get; set; }
        public string NxUnit { get; set; }
        public string RevalGrp { get; set; }
        public string RevalCurrGrp { get; set; }
        public string GLBook { get; set; }
        public string GLTypeOut { get; set; }
        public System.Guid RevalueAsOf { get; set; }
        public Nullable<System.DateTime> GLDate { get; set; }
        public int UnrealizeGainLossIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual UnitPeriod UnitPeriod { get; set; }
    }
}
