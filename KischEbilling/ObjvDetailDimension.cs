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
    
    public partial class ObjvDetailDimension
    {
        public System.Guid ObjvDetailDimensionID { get; set; }
        public System.Guid ObjvDetail { get; set; }
        public string Measure { get; set; }
        public string Arrangement { get; set; }
        public Nullable<int> Client { get; set; }
        public string Department { get; set; }
        public Nullable<int> GlAcct { get; set; }
        public Nullable<int> Matter { get; set; }
        public string Office { get; set; }
        public string PracticeGroup { get; set; }
        public string RateClass { get; set; }
        public string Section { get; set; }
        public Nullable<int> TimeKeeper { get; set; }
        public string Title { get; set; }
        public string TkprTeam { get; set; }
        public Nullable<int> Vendor { get; set; }
        public decimal Objective { get; set; }
        public string Currency { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual ObjvDetail ObjvDetail1 { get; set; }
    }
}