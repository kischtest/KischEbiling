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
    
    public partial class RMAppOptIntRole
    {
        public System.Guid RMAppOptIntRoleID { get; set; }
        public System.Guid NxRole { get; set; }
        public System.Guid RMAppOptionInteger { get; set; }
        public int IntegerValue { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxRole NxRole1 { get; set; }
        public virtual RMAppOptionInteger RMAppOptionInteger1 { get; set; }
    }
}
