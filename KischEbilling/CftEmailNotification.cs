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
    
    public partial class CftEmailNotification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CftEmailNotification()
        {
            this.CftEmailMessages = new HashSet<CftEmailMessage>();
            this.CftEmailSubjects = new HashSet<CftEmailSubject>();
        }
    
        public System.Guid CftEmailNotificationID { get; set; }
        public string CftProcess { get; set; }
        public Nullable<System.Guid> CftNotificationOutput { get; set; }
        public string CftNotificationTo { get; set; }
        public string CftNotificationFrom { get; set; }
        public string CftNotificationType { get; set; }
        public string CftFromEmail { get; set; }
        public Nullable<System.Guid> CftLastModifiedBy { get; set; }
        public System.DateTime cftDateTime { get; set; }
        public Nullable<byte> IsActive { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public byte IsHTML { get; set; }
        public Nullable<System.Guid> NxFwkAppObject { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftEmailMessage> CftEmailMessages { get; set; }
        public virtual CftEmlNotificationOutput CftEmlNotificationOutput { get; set; }
        public virtual NxUser NxUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftEmailSubject> CftEmailSubjects { get; set; }
    }
}