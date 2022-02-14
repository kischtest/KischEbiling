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
    
    public partial class AVRSecurityUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AVRSecurityUser()
        {
            this.AVRBillingTimekeepers = new HashSet<AVRBillingTimekeeper>();
            this.AVRDepartments = new HashSet<AVRDepartment>();
            this.AVROffices = new HashSet<AVROffice>();
            this.AVRPracticeGroups = new HashSet<AVRPracticeGroup>();
            this.AVRTimekeepers = new HashSet<AVRTimekeeper>();
            this.AVRWorkingTimekeepers = new HashSet<AVRWorkingTimekeeper>();
        }
    
        public System.Guid AVRSecurityUserID { get; set; }
        public System.Guid NxBaseUser { get; set; }
        public byte IsFirm { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string AVRDrillRoleList { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRBillingTimekeeper> AVRBillingTimekeepers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRDepartment> AVRDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVROffice> AVROffices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRPracticeGroup> AVRPracticeGroups { get; set; }
        public virtual NxBaseUser NxBaseUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRTimekeeper> AVRTimekeepers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVRWorkingTimekeeper> AVRWorkingTimekeepers { get; set; }
    }
}
