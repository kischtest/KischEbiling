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
    
    public partial class MatterCollectionGroupLink
    {
        public System.Guid MatterCollectionGroupLinkID { get; set; }
        public System.Guid CollGrpSrchSeq { get; set; }
        public int Matter { get; set; }
        public string CollectionGroup { get; set; }
        public string CollectionItemLevelType { get; set; }
        public Nullable<byte> IsInvoiceAccumulated { get; set; }
    
        public virtual CollectionGroupSearchSequence CollectionGroupSearchSequence { get; set; }
    }
}
