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
    
    public partial class NxTimeZoneRuleException
    {
        public System.Guid NxTimeZoneRuleExceptionID { get; set; }
        public System.Guid NxTimeZoneRule { get; set; }
        public int StartMonth { get; set; }
        public string StartRule { get; set; }
        public Nullable<int> StartDayOfMonth { get; set; }
        public Nullable<int> StartDayOfWeek { get; set; }
        public string StartTime { get; set; }
        public int EndMonth { get; set; }
        public string EndRule { get; set; }
        public Nullable<int> EndDayOfMonth { get; set; }
        public Nullable<int> EndDayOfWeek { get; set; }
        public string EndTime { get; set; }
        public string TimeDiff { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxTimeZoneRule NxTimeZoneRule1 { get; set; }
    }
}
