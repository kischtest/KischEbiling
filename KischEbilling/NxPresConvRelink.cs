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
    
    public partial class NxPresConvRelink
    {
        public System.Guid NxPresConvRelinkID { get; set; }
        public System.Guid Conversion { get; set; }
        public string ArchetypeID { get; set; }
        public string DashboardID { get; set; }
        public System.DateTime RelinkDate { get; set; }
    
        public virtual NxPresConv NxPresConv { get; set; }
    }
}
