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
    
    public partial class NxWfNotifyList
    {
        public System.Guid NxWfNotifyListID { get; set; }
        public Nullable<System.Guid> NxRole { get; set; }
        public Nullable<byte> IsTo { get; set; }
        public Nullable<byte> IsCc { get; set; }
        public Nullable<byte> IsBcc { get; set; }
        public Nullable<System.Guid> NxFwkUser { get; set; }
        public string Non3EUserEmail { get; set; }
        public string NxWfXOQLFilter { get; set; }
        public Nullable<byte> IsCurrentUser { get; set; }
        public Nullable<byte> IsOriginator { get; set; }
        public Nullable<byte> IsPrevOwner { get; set; }
        public Nullable<System.Guid> NxWfNotify { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxWfNotify NxWfNotify1 { get; set; }
    }
}
