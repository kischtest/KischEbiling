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
    
    public partial class FinancialControlsMinMax
    {
        public System.Guid FinancialControlsMinMaxID { get; set; }
        public Nullable<System.DateTime> MinDate { get; set; }
        public Nullable<System.DateTime> MaxDate { get; set; }
        public System.Guid FinancialControls { get; set; }
        public string MinMaxDateList { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public int MinDateRollMonths { get; set; }
        public int MaxDateRollMonths { get; set; }
    
        public virtual FinancialControl FinancialControl { get; set; }
    }
}
