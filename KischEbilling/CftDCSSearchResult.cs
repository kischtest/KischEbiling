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
    
    public partial class CftDCSSearchResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CftDCSSearchResult()
        {
            this.CftDCSGenericHits = new HashSet<CftDCSGenericHit>();
            this.CftDCSSearchResultRelMatters = new HashSet<CftDCSSearchResultRelMatter>();
        }
    
        public System.Guid CftDCSSearchResultID { get; set; }
        public Nullable<System.Guid> CftDCSSearch { get; set; }
        public string SearchTermGroupingLabel { get; set; }
        public string Name { get; set; }
        public Nullable<int> HitCount { get; set; }
        public string Text { get; set; }
        public string PartialText { get; set; }
        public string ProviderCode { get; set; }
        public string WhereFound { get; set; }
        public string WhereFoundArchCode { get; set; }
        public string WhereFoundArchCaption { get; set; }
        public string WhereFoundAttrCode { get; set; }
        public string WhereFoundAttrCaption { get; set; }
        public string WhereFoundItemID { get; set; }
        public Nullable<System.Guid> DetailItemID { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<int> RiskImage { get; set; }
        public Nullable<System.Guid> CftSearchResult { get; set; }
        public Nullable<System.Guid> CftSearchTerm { get; set; }
        public string DetailArchCode { get; set; }
        public Nullable<System.Guid> CftDCSSearchTerm { get; set; }
        public Nullable<System.Guid> EntityID { get; set; }
        public Nullable<System.Guid> MatterID { get; set; }
        public Nullable<System.Guid> ActualItemID { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSGenericHit> CftDCSGenericHits { get; set; }
        public virtual CftDCSSearch CftDCSSearch1 { get; set; }
        public virtual CftDCSSearchTerm CftDCSSearchTerm1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CftDCSSearchResultRelMatter> CftDCSSearchResultRelMatters { get; set; }
    }
}
