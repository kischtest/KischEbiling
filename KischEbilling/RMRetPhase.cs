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
    
    public partial class RMRetPhase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RMRetPhase()
        {
            this.RMBaseFilePhases = new HashSet<RMBaseFilePhas>();
        }
    
        public System.Guid RMRetPhaseID { get; set; }
        public string RMRetSchedule { get; set; }
        public int PhaseID { get; set; }
        public Nullable<int> ParentPhaseID { get; set; }
        public string RMRetTrigger { get; set; }
        public string RMRetActionList { get; set; }
        public int RetentionPeriod { get; set; }
        public string RMPerUnitList { get; set; }
        public string RMLocation { get; set; }
        public string Comment { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMBaseFilePhas> RMBaseFilePhases { get; set; }
    }
}
