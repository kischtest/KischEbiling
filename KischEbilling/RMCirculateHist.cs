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
    
    public partial class RMCirculateHist
    {
        public System.Guid RMCirculateHistID { get; set; }
        public int CirculateID { get; set; }
        public Nullable<int> RMEntity { get; set; }
        public System.DateTime RMCirculateDate { get; set; }
        public Nullable<System.DateTime> ExpectedReturn { get; set; }
        public string Comments { get; set; }
        public Nullable<int> RMBaseFile { get; set; }
        public string RMLocation { get; set; }
        public Nullable<int> RMContainer { get; set; }
        public System.Guid FulfillingOp { get; set; }
        public Nullable<int> RMCircContainer { get; set; }
        public Nullable<System.DateTime> StorageDate { get; set; }
        public string RMDeliveryMethod { get; set; }
        public string RMDeliveryTimeframe { get; set; }
        public Nullable<int> RMEntityRequestor { get; set; }
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
    }
}
