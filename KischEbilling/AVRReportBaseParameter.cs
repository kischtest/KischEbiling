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
    
    public partial class AVRReportBaseParameter
    {
        public System.Guid AVRReportBaseParameterID { get; set; }
        public int BaseParameterIndex { get; set; }
        public Nullable<int> AVRReportInstance { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Nullable<int> AVRReportCatalogParameters { get; set; }
        public string OQLSelectQuery { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
