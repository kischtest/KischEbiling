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
    
    public partial class JMPostCtl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JMPostCtl()
        {
            this.PostSourceLists = new HashSet<PostSourceList>();
        }
    
        public System.Guid JMPostCtlID { get; set; }
        public byte IsPostEnable { get; set; }
        public byte IsPostLog { get; set; }
        public Nullable<int> SysPostingBatchLevel { get; set; }
        public Nullable<byte> IsLastPostingFailed { get; set; }
        public string InProcessCkFreq { get; set; }
        public Nullable<int> TransactionThreshold { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostSourceList> PostSourceLists { get; set; }
    }
}