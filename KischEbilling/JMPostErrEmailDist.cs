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
    
    public partial class JMPostErrEmailDist
    {
        public System.Guid JMPostErrEmailDistID { get; set; }
        public string PostSourceList { get; set; }
        public byte IsEmailByUser { get; set; }
        public Nullable<System.Guid> Username { get; set; }
        public Nullable<System.Guid> Role { get; set; }
        public string NxUnit { get; set; }
        public System.DateTime EnableDate { get; set; }
        public Nullable<System.DateTime> DisableDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxRole NxRole { get; set; }
        public virtual NxUser NxUser { get; set; }
    }
}
