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
    
    public partial class RMBaseFile
    {
        public System.Guid RMBaseFileID { get; set; }
        public int FileIndex { get; set; }
        public string RMFileType { get; set; }
        public string FileID { get; set; }
        public string Description { get; set; }
        public string RMCategory { get; set; }
        public string Barcode { get; set; }
        public string RFID { get; set; }
        public string RMFileStatus { get; set; }
        public System.DateTime StatusDate { get; set; }
        public string RMFilingStatus { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string Notes { get; set; }
        public string Notes_UnformattedText { get; set; }
        public string RMLocation { get; set; }
        public byte IsVital { get; set; }
        public string RMVitalPeriod { get; set; }
        public Nullable<System.DateTime> NextVtlRvwDate { get; set; }
        public Nullable<System.DateTime> LastVtlRvwDate { get; set; }
        public Nullable<System.Guid> LastReviewedBy { get; set; }
        public byte IsFrozen { get; set; }
        public Nullable<System.DateTime> FrozenDate { get; set; }
        public string RMFileFreezeReason { get; set; }
        public Nullable<int> RMParentFile { get; set; }
        public string RMParentType { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string RMMediaType { get; set; }
        public Nullable<int> RMContainer { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> RMSubmatter { get; set; }
        public Nullable<int> RMEntityOwner { get; set; }
        public Nullable<int> RMEntityCircTo { get; set; }
        public string OfficeOfRecord { get; set; }
        public string CreateOffice { get; set; }
        public Nullable<System.DateTime> CircToContainerDate { get; set; }
        public string VaultNum { get; set; }
        public string VaultNumCalc { get; set; }
        public Nullable<int> VitalPeriodUnits { get; set; }
        public string RMVitalPerUnitList { get; set; }
        public byte IsPermanent { get; set; }
        public Nullable<int> RMEntityVtlRvwr { get; set; }
        public Nullable<System.Guid> NxUserCreator { get; set; }
        public string CurrentLocation { get; set; }
        public Nullable<System.DateTime> FinalDispDate { get; set; }
        public string RMRetStatusList { get; set; }
        public string RMRetDecision { get; set; }
        public Nullable<System.DateTime> RetRvwDate { get; set; }
        public Nullable<int> RMEntityRetRvwr { get; set; }
        public byte IsOverrideRetSched { get; set; }
        public Nullable<System.DateTime> CutoffDate { get; set; }
        public byte IsCalcRet { get; set; }
        public Nullable<System.DateTime> SchedCutoffDate { get; set; }
        public string RMRetSchedule { get; set; }
        public string DestrCert { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
    
        public virtual NxUser NxUser { get; set; }
        public virtual NxUser NxUser1 { get; set; }
    }
}
