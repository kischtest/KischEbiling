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
    
    public partial class AVRReportCatalogParameter
    {
        public System.Guid AVRReportCatalogParametersID { get; set; }
        public int ReportCatalogParametersIndex { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Nullable<System.Guid> NxFWKAppObject { get; set; }
        public Nullable<byte> BurstingBy { get; set; }
        public Nullable<int> AVRReportCatalog { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<byte> IsNullable { get; set; }
        public Nullable<byte> IsPromptUser { get; set; }
        public Nullable<byte> IsHidden { get; set; }
    
        public virtual NxFWKAppObject NxFWKAppObject1 { get; set; }
    }
}
