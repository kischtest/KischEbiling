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
    
    public partial class RMDMSSavedQuery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RMDMSSavedQuery()
        {
            this.FTXAutonomySavedQueries = new HashSet<FTXAutonomySavedQuery>();
            this.FTXOpenTextSavedQueries = new HashSet<FTXOpenTextSavedQuery>();
        }
    
        public System.Guid RMDMSSavedQueryID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string RMDMSSystemList { get; set; }
        public string DMSLibraryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FTXAutonomySavedQuery> FTXAutonomySavedQueries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FTXOpenTextSavedQuery> FTXOpenTextSavedQueries { get; set; }
    }
}
