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
    
    public partial class NxWfRuleSetEndStatu
    {
        public System.Guid NxWfRuleSetEndStatusID { get; set; }
        public string AttrID { get; set; }
        public string AttrValue { get; set; }
        public Nullable<System.Guid> NxWfRuleSet { get; set; }
        public Nullable<byte> IsDynamicStatus { get; set; }
        public string BusinessRule { get; set; }
        public string AttrDataType { get; set; }
        public Nullable<byte> IsDataObjectSave { get; set; }
        public string ArchetypeAttributeID { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxWfRuleSet NxWfRuleSet1 { get; set; }
    }
}
