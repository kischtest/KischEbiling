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
    
    public partial class AVRReportMetricDependency
    {
        public System.Guid AVRReportMetricDependencyID { get; set; }
        public int AVRReportMetricDependencyIndex { get; set; }
        public Nullable<System.Guid> AVRMetricDependency { get; set; }
        public Nullable<System.Guid> NxMetric { get; set; }
    
        public virtual AVRMetricDependency AVRMetricDependency1 { get; set; }
        public virtual NxMetric NxMetric1 { get; set; }
    }
}
