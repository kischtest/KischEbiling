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
    
    public partial class CftRelatedParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CftRelatedParty()
        {
            this.Cft3TierBasicRPMCaseDtl = new HashSet<Cft3TierBasicRPMCaseDtl>();
            this.CmCaseCftRelatedParties = new HashSet<CmCaseCftRelatedParty>();
        }
    
        public System.Guid CftRelatedPartyID { get; set; }
        public Nullable<int> Matter { get; set; }
        public int Entity { get; set; }
        public string Notes { get; set; }
        public string Notes_UnformattedText { get; set; }
        public string CftRelationshipCode { get; set; }
        public string CftRole { get; set; }
        public string CftRPStatus { get; set; }
        public Nullable<System.Guid> CftNewBizRequest { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<byte> IsCreatedParty { get; set; }
        public Nullable<int> EntIndex { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> CmCase { get; set; }
        public Nullable<int> Client { get; set; }
        public string LinkType { get; set; }
        public int CftRelatedPartyIndex { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
        public Nullable<int> CftNBISearch { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cft3TierBasicRPMCaseDtl> Cft3TierBasicRPMCaseDtl { get; set; }
        public virtual CftNewBizRequest CftNewBizRequest1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CmCaseCftRelatedParty> CmCaseCftRelatedParties { get; set; }
    }
}
