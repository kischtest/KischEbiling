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
    
    public partial class CmCaseTkpr
    {
        public System.Guid CmCaseTkprID { get; set; }
        public int CmCaseTkprIndex { get; set; }
        public int Timekeeper { get; set; }
        public string EventReminderTemplate { get; set; }
        public string TaskReminderTemplate { get; set; }
        public string WestlawID { get; set; }
        public string WestlawPSWD { get; set; }
        public Nullable<int> CalTkpr { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
