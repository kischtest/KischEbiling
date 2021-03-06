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
    
    public partial class RMAppOptionRel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RMAppOptionRel()
        {
            this.RMAppOptRelOffices = new HashSet<RMAppOptRelOffice>();
            this.RMAppOptRelRoles = new HashSet<RMAppOptRelRole>();
            this.RMAppOptRelUsers = new HashSet<RMAppOptRelUser>();
        }
    
        public System.Guid RMAppOptionRelID { get; set; }
        public Nullable<System.Guid> RelationshipValue { get; set; }
        public string RMContainerType { get; set; }
        public Nullable<int> RMEntity { get; set; }
        public string OfficeOpt { get; set; }
        public string RMFileStatus { get; set; }
        public string RMFilingStatus { get; set; }
        public string RMDeliveryMethod { get; set; }
        public string RMDeliveryTimeframe { get; set; }
        public Nullable<System.Guid> NxPrinterTemplate { get; set; }
        public string NxPrinter { get; set; }
        public string RMCategory { get; set; }
        public string RMLocation { get; set; }
        public string RMMediaType { get; set; }
        public string RMPrintLabelList { get; set; }
        public Nullable<System.Guid> NxBaseUser { get; set; }
        public string EntityType { get; set; }
        public string MattStatus { get; set; }
        public string CliStatusType { get; set; }
        public Nullable<int> Matter { get; set; }
        public string CftSearchReason { get; set; }
        public string CftSearchResultsViewList { get; set; }
        public string CmEvSendAsList { get; set; }
        public Nullable<System.Guid> CmTimeZone { get; set; }
        public string CftSearchReportTypeList { get; set; }
        public string RMFileType { get; set; }
        public string CftSearchReportTemplate { get; set; }
        public Nullable<System.Guid> NxSyncMap { get; set; }
        public Nullable<System.Guid> NxSyncField { get; set; }
        public string CftSearchAuthorityList { get; set; }
    
        public virtual NxBaseUser NxBaseUser1 { get; set; }
        public virtual NxPrinterTemplate NxPrinterTemplate1 { get; set; }
        public virtual NxSyncField NxSyncField1 { get; set; }
        public virtual NxSyncMap NxSyncMap1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMAppOptRelOffice> RMAppOptRelOffices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMAppOptRelRole> RMAppOptRelRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMAppOptRelUser> RMAppOptRelUsers { get; set; }
    }
}
