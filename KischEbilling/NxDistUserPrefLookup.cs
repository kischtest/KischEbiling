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
    
    public partial class NxDistUserPrefLookup
    {
        public System.Guid NxDistUserPrefLookupID { get; set; }
        public Nullable<System.Guid> UserPrefID { get; set; }
        public Nullable<System.Guid> DistType { get; set; }
        public Nullable<System.Guid> NxLookupUser { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser { get; set; }
        public virtual NxDistUserLookupType NxDistUserLookupType { get; set; }
        public virtual NxNtfUserPref NxNtfUserPref { get; set; }
    }
}
