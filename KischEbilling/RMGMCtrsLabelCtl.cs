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
    
    public partial class RMGMCtrsLabelCtl
    {
        public System.Guid RMGMCtrsLabelCtlID { get; set; }
        public int RMGMCtrs { get; set; }
        public string RMContainerType { get; set; }
        public Nullable<int> NumberOfCopies { get; set; }
        public string RMPrintLabelList { get; set; }
        public string NxPrinter { get; set; }
        public Nullable<System.Guid> NxPrinterTemplate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxPrinterTemplate NxPrinterTemplate1 { get; set; }
    }
}