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
    
    public partial class InvReverseEvent
    {
        public System.Guid InvReverseEventID { get; set; }
        public int InvReverseEventIndex { get; set; }
        public System.Guid ScheduledBy { get; set; }
        public byte IsFullCreditNote { get; set; }
        public Nullable<System.DateTime> CrNoteTaxDate { get; set; }
        public System.DateTime ReversedDate { get; set; }
        public string ReverseComment { get; set; }
        public byte IsDonotReinstate { get; set; }
        public byte IsRetainInvNumber { get; set; }
        public byte IsDonotUpdateWIP { get; set; }
        public string ReasonType { get; set; }
    
        public virtual NxUser NxUser { get; set; }
    }
}
