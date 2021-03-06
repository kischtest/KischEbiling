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
    
    public partial class NxSyncMapping
    {
        public System.Guid NxSyncMappingID { get; set; }
        public Nullable<System.Guid> SyncMapParent { get; set; }
        public Nullable<System.Guid> BusinessObject { get; set; }
        public string FunctionName { get; set; }
        public Nullable<byte> Advanced { get; set; }
        public Nullable<System.Guid> From3ESyncField { get; set; }
        public string From3EAttName { get; set; }
        public Nullable<byte> From3EAdvanced { get; set; }
        public Nullable<System.Guid> From3EBusinessObject { get; set; }
        public string From3EFunctionName { get; set; }
        public string From3EValue { get; set; }
        public string Value { get; set; }
        public Nullable<System.Guid> SyncField { get; set; }
        public string AttName { get; set; }
        public Nullable<int> ApplyOrder { get; set; }
        public Nullable<int> From3EApplyOrder { get; set; }
        public Nullable<byte> IsAttachmentField { get; set; }
        public Nullable<System.Guid> SyncAttachmentField { get; set; }
        public Nullable<byte> SensitiveField { get; set; }
        public Nullable<System.Guid> BOFunctionName { get; set; }
        public Nullable<System.Guid> From3EBOFunctionName { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxSyncAttachmentField NxSyncAttachmentField { get; set; }
        public virtual NxSyncBOFunction NxSyncBOFunction { get; set; }
        public virtual NxSyncBOFunction NxSyncBOFunction1 { get; set; }
        public virtual NxSyncField NxSyncField { get; set; }
        public virtual NxSyncField NxSyncField1 { get; set; }
        public virtual NxSyncMap NxSyncMap { get; set; }
    }
}
