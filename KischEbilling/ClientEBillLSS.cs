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
    
    public partial class ClientEBillLSS
    {
        public System.Guid ClientEBillLSSID { get; set; }
        public System.Guid ClientAdditionalInfo { get; set; }
        public string ClientMatterName { get; set; }
        public string MatterReferenceId { get; set; }
        public string LawFirmName { get; set; }
        public string Location { get; set; }
        public string ClaimRepName { get; set; }
        public string ClaimNumber { get; set; }
        public string DivisionOffice { get; set; }
        public string DivisionName { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual ClientAdditionalInfo ClientAdditionalInfo1 { get; set; }
    }
}
