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
    
    public partial class TimerPeriod
    {
        public System.Guid TimerPeriodID { get; set; }
        public Nullable<int> TimecardPending { get; set; }
        public Nullable<int> Start { get; set; }
        public Nullable<int> Stop { get; set; }
        public Nullable<byte> IsTicking { get; set; }
        public string Note { get; set; }
        public Nullable<int> Timecard { get; set; }
        public Nullable<byte> IsTimer { get; set; }
        public Nullable<System.Guid> DraftUser { get; set; }
        public string DraftExceptions { get; set; }
        public string DraftAccess { get; set; }
        public int TimerPeriodIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
