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
    
    public partial class FollowUpCollectionActionEvent
    {
        public System.Guid FollowUpCollectionActionEventID { get; set; }
        public byte IsCollectorNotified { get; set; }
        public byte IsActionByNotified { get; set; }
        public string NotifyAction { get; set; }
        public Nullable<System.Guid> NotifyActionBy { get; set; }
        public Nullable<int> NotifyPriority { get; set; }
        public int NotifyDaysInAdvance { get; set; }
    
        public virtual NxUser NxUser { get; set; }
    }
}
