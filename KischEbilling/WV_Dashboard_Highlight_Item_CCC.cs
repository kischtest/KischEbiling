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
    
    public partial class WV_Dashboard_Highlight_Item_CCC
    {
        public System.Guid WV_Dashboard_Highlight_Item_CCCID { get; set; }
        public Nullable<System.Guid> Highlight { get; set; }
        public Nullable<System.Guid> Unit { get; set; }
        public decimal Start { get; set; }
        public decimal Stop { get; set; }
        public Nullable<System.Guid> Format { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual WV_Dashboard_Highlight_CCC WV_Dashboard_Highlight_CCC { get; set; }
        public virtual WV_Dashboard_HighlightFormat_CCC WV_Dashboard_HighlightFormat_CCC { get; set; }
        public virtual WV_Dashboard_HighlightUnit_CCC WV_Dashboard_HighlightUnit_CCC { get; set; }
    }
}
