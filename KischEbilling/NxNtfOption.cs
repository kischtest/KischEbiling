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
    
    public partial class NxNtfOption
    {
        public System.Guid NxNtfOptionsID { get; set; }
        public Nullable<System.Guid> BGUser { get; set; }
        public Nullable<System.Guid> BackgroundServer { get; set; }
        public string AdminEmail { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxFWKUser NxFWKUser { get; set; }
        public virtual NxNtfSrvSel NxNtfSrvSel { get; set; }
    }
}
