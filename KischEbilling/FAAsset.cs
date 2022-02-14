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
    
    public partial class FAAsset
    {
        public System.Guid FAAssetID { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string AltAssetNumber { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> InsurableCost { get; set; }
        public int Quantity { get; set; }
        public Nullable<byte> IsCapitalLease { get; set; }
        public string LeaseNumber { get; set; }
        public string Lessor { get; set; }
        public Nullable<byte> IsReal { get; set; }
        public Nullable<byte> IsUsed { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Notes { get; set; }
        public Nullable<byte> IsFullyRetired { get; set; }
        public string MfgMake { get; set; }
        public string AssetNumber { get; set; }
        public int AssetIndex { get; set; }
        public string Barcode { get; set; }
        public System.DateTime AcquisitionDate { get; set; }
        public string OriginalAsset { get; set; }
        public Nullable<System.DateTime> RetirementDate { get; set; }
        public byte IsReversed { get; set; }
        public System.Guid Unit { get; set; }
        public System.Guid Office { get; set; }
        public Nullable<System.Guid> Department { get; set; }
        public Nullable<System.Guid> PracticeGroup { get; set; }
        public Nullable<System.Guid> Section { get; set; }
        public Nullable<System.Guid> Title { get; set; }
        public Nullable<System.Guid> Arrangement { get; set; }
        public Nullable<System.Guid> WorkType { get; set; }
        public Nullable<System.Guid> GLTimekeeper { get; set; }
        public int Timekeeper { get; set; }
        public string GLProject { get; set; }
        public Nullable<int> GLRespTkpr { get; set; }
        public Nullable<System.DateTime> ReverseDate { get; set; }
        public decimal Cost { get; set; }
        public Nullable<decimal> DisposalCost { get; set; }
        public string ReverseComment { get; set; }
        public string RetireComment { get; set; }
        public byte IsRetireVoluntary { get; set; }
        public string FARetireType { get; set; }
        public string WarrantyNumber { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }
        public Nullable<decimal> RetirementProceeds { get; set; }
        public string FAAcquisitionType { get; set; }
        public string FAUSIRCPropSec { get; set; }
        public byte IsTangible { get; set; }
        public string FAMACRSType { get; set; }
        public string FAACRSType { get; set; }
        public byte IsQIRP { get; set; }
        public string OriginalCurrency { get; set; }
        public string Status { get; set; }
        public string FAPropTaxCode { get; set; }
        public Nullable<System.DateTime> ReclassDate { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public Nullable<System.DateTime> SplitDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<System.Guid> GLActivity { get; set; }
    
        public virtual GLActivity GLActivity1 { get; set; }
        public virtual GLArrangement GLArrangement { get; set; }
        public virtual GLDepartment GLDepartment { get; set; }
        public virtual GLOffice GLOffice { get; set; }
        public virtual GLPracticeGroup GLPracticeGroup { get; set; }
        public virtual GLSection GLSection { get; set; }
        public virtual GLTimekeeper GLTimekeeper1 { get; set; }
        public virtual GLTitle GLTitle { get; set; }
        public virtual GLUnit GLUnit { get; set; }
        public virtual GLWorkType GLWorkType { get; set; }
    }
}
