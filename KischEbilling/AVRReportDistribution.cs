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
    
    public partial class AVRReportDistribution
    {
        public System.Guid AVRReportDistributionID { get; set; }
        public int AVRDistributionIndex { get; set; }
        public Nullable<int> AVRReportInstance { get; set; }
        public Nullable<System.Guid> NxBaseUser { get; set; }
        public Nullable<byte> IsEmailSnapshot { get; set; }
        public Nullable<byte> IsEmailPdf { get; set; }
        public Nullable<byte> IsInboxSnapshot { get; set; }
        public Nullable<byte> IsInboxPdf { get; set; }
        public Nullable<byte> IsEmailPdfLink { get; set; }
        public Nullable<byte> IsRead { get; set; }
        public Nullable<byte> OverridePredicate { get; set; }
        public Nullable<int> AVRReportBurstingPredicate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser1 { get; set; }
    }
}
