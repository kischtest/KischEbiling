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
    
    public partial class RMCirctoInv
    {
        public System.Guid RMCirctoInvID { get; set; }
        public string CircCode { get; set; }
        public string Code { get; set; }
        public string CodeType { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string FilingLocation { get; set; }
        public string Process { get; set; }
        public Nullable<int> Sort { get; set; }
        public string Status { get; set; }
        public Nullable<System.Guid> RMCirctoInvParentID { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual RMCirctoInvParent RMCirctoInvParent { get; set; }
    }
}
