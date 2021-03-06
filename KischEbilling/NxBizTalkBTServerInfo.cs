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
    
    public partial class NxBizTalkBTServerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxBizTalkBTServerInfo()
        {
            this.NxBizTalkStepObjectEnumerations = new HashSet<NxBizTalkStepObjectEnumeration>();
            this.NxIntegrationDuplicateNotifies = new HashSet<NxIntegrationDuplicateNotify>();
        }
    
        public System.Guid NxBizTalkBTServerInfoID { get; set; }
        public string ServerName { get; set; }
        public string ESBServicesURL { get; set; }
        public string ServerMachineName { get; set; }
        public Nullable<int> CheckServerHealth { get; set; }
        public Nullable<int> ServerRelevanceOrder { get; set; }
        public Nullable<System.Guid> ServerGroup { get; set; }
        public string EAIServiceAuthUserName { get; set; }
        public string EAIServiceAuthPwd { get; set; }
        public string ServerDescription { get; set; }
        public Nullable<byte> IsTrustedServer { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ESBServerStatusQuickInfo { get; set; }
    
        public virtual NxBizTalkBTServersGroup NxBizTalkBTServersGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkStepObjectEnumeration> NxBizTalkStepObjectEnumerations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxIntegrationDuplicateNotify> NxIntegrationDuplicateNotifies { get; set; }
    }
}
