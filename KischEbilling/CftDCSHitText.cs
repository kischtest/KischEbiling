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
    
    public partial class CftDCSHitText
    {
        public System.Guid CftDCSHitTextID { get; set; }
        public string HitArchCode { get; set; }
        public string HitAttrCode { get; set; }
        public Nullable<System.Guid> HitItemID { get; set; }
        public string HitText { get; set; }
        public Nullable<System.Guid> CftDCSSearch { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CftDCSSearch CftDCSSearch1 { get; set; }
    }
}
