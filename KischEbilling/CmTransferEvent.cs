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
    
    public partial class CmTransferEvent
    {
        public System.Guid CmTransferEventID { get; set; }
        public int CmTransferEventIndex { get; set; }
        public int CmCase { get; set; }
        public byte IsRulesetChange { get; set; }
        public byte IsTimeZoneChange { get; set; }
        public byte IsTimekeepersChange { get; set; }
        public byte IsRelatedPartiesDelete { get; set; }
        public int CmMasterEvent { get; set; }
        public int FromCase { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}