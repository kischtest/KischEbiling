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
    
    public partial class MattPhaseException
    {
        public System.Guid MattPhaseExceptionID { get; set; }
        public int Matter { get; set; }
        public System.Guid Phase { get; set; }
        public Nullable<System.DateTime> MilestoneDate { get; set; }
        public byte IsTimeEntry { get; set; }
        public byte IsCostEntry { get; set; }
        public byte IsChargeEntry { get; set; }
        public string PTAGroup { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual Phase Phase1 { get; set; }
    }
}
