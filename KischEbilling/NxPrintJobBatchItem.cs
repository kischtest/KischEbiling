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
    
    public partial class NxPrintJobBatchItem
    {
        public System.Guid NxPrintJobBatchItemID { get; set; }
        public System.Guid NxPrintJob { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
    
        public virtual NxPrintJob NxPrintJob1 { get; set; }
    }
}
