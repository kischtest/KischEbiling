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
    
    public partial class NxBizTalkStepObjectEnumeration
    {
        public System.Guid NxBizTalkStepObjectEnumerationID { get; set; }
        public string StepItemFQN { get; set; }
        public System.Guid ServerGroup { get; set; }
        public System.Guid ServerInfoId { get; set; }
        public string FriendlyName { get; set; }
        public System.Guid StepType { get; set; }
        public string Description { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBizTalkBTServerInfo NxBizTalkBTServerInfo { get; set; }
        public virtual NxBizTalkBTServersGroup NxBizTalkBTServersGroup { get; set; }
        public virtual NxBizTalkStepType NxBizTalkStepType { get; set; }
    }
}
