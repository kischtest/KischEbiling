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
    
    public partial class RMDMSLoadEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RMDMSLoadEvent()
        {
            this.RMDMSExcepts = new HashSet<RMDMSExcept>();
            this.RMDMSLoadLibraries = new HashSet<RMDMSLoadLibrary>();
        }
    
        public System.Guid RMDMSLoadEventID { get; set; }
        public string RMDMSRunModeList { get; set; }
        public Nullable<int> StartClient { get; set; }
        public Nullable<int> EndClient { get; set; }
        public Nullable<int> StartMatter { get; set; }
        public Nullable<int> EndMatter { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> LastGoodRun { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMDMSExcept> RMDMSExcepts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMDMSLoadLibrary> RMDMSLoadLibraries { get; set; }
    }
}