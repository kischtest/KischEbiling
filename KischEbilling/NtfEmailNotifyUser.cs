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
    
    public partial class NtfEmailNotifyUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NtfEmailNotifyUser()
        {
            this.NtfEmailNotifyToes = new HashSet<NtfEmailNotifyTo>();
        }
    
        public System.Guid NtfEmailNotifyUserID { get; set; }
        public Nullable<System.Guid> NtfEvent { get; set; }
        public Nullable<byte> IsSelect { get; set; }
        public Nullable<System.Guid> NtfEmailNtfSetup { get; set; }
        public Nullable<System.Guid> NxNtfSched { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NtfEmailNotifyTo> NtfEmailNotifyToes { get; set; }
        public virtual NtfEmailNtfSetup NtfEmailNtfSetup1 { get; set; }
        public virtual NxNtfSched NxNtfSched1 { get; set; }
    }
}
