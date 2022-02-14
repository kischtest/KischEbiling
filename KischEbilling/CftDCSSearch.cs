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
    
    public partial class CftDCSSearch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CftDCSSearch()
        {
            this.CftDCSGenericHits = new HashSet<CftDCSGenericHit>();
            this.CftDCSHitTexts = new HashSet<CftDCSHitText>();
            this.CftDCSSearchResults = new HashSet<CftDCSSearchResult>();
            this.CftDCSSearchResultDetails = new HashSet<CftDCSSearchResultDetail>();
            this.CftDCSSearchResultRelMatters = new HashSet<CftDCSSearchResultRelMatter>();
            this.CftDCSSearchTerms = new HashSet<CftDCSSearchTerm>();
            this.CftLOVClientLists = new HashSet<CftLOVClientList>();
            this.CftLOVEntityLists = new HashSet<CftLOVEntityList>();
            this.CftLOVMatterLists = new HashSet<CftLOVMatterList>();
        }
    
        public System.Guid CftDCSSearchID { get; set; }
        public string Description { get; set; }
        public string NumResultsLiteral { get; set; }
        public Nullable<System.DateTime> DateRun { get; set; }
        public string Comments { get; set; }
        public string Comments_UnformattedText { get; set; }
        public string DeclineComment { get; set; }
        public Nullable<System.Guid> CftNewBizRequest { get; set; }
        public Nullable<System.Guid> RanBy { get; set; }
        public string CurrentWorkflowStep { get; set; }
        public string FinalDecision { get; set; }
        public string DeclineReason { get; set; }
        public Nullable<System.DateTime> DCSReportDateTime { get; set; }
        public Nullable<System.Guid> CftSearch { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSGenericHit> CftDCSGenericHits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSHitText> CftDCSHitTexts { get; set; }
        public virtual CftNewBizRequest CftNewBizRequest1 { get; set; }
        public virtual NxUser NxUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSSearchResult> CftDCSSearchResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSSearchResultDetail> CftDCSSearchResultDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSSearchResultRelMatter> CftDCSSearchResultRelMatters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSSearchTerm> CftDCSSearchTerms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftLOVClientList> CftLOVClientLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftLOVEntityList> CftLOVEntityLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftLOVMatterList> CftLOVMatterLists { get; set; }
    }
}