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
    
    public partial class NxBizTalkExtendedLogBaseGeneric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxBizTalkExtendedLogBaseGeneric()
        {
            this.NxBizTalkExtLogBaseDets = new HashSet<NxBizTalkExtLogBaseDet>();
        }
    
        public System.Guid NxBizTalkExtendedLogBaseGenericID { get; set; }
        public string GenericDetail { get; set; }
        public Nullable<System.DateTime> LastModifiedDateTime { get; set; }
        public Nullable<System.Guid> ReportUser { get; set; }
        public Nullable<System.Guid> NxBizTalkLogParent { get; set; }
        public Nullable<int> DetailRowCount { get; set; }
        public Nullable<int> HeaderRowCount { get; set; }
        public Nullable<int> TotalInterfaceRowCount { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser { get; set; }
        public virtual NxBizTalkLogArchetype NxBizTalkLogArchetype { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkExtLogBaseDet> NxBizTalkExtLogBaseDets { get; set; }
    }
}
