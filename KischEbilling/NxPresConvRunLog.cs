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
    
    public partial class NxPresConvRunLog
    {
        public System.Guid NxPresConvRunLogID { get; set; }
        public System.Guid ConversionRun { get; set; }
        public System.DateTime LogDate { get; set; }
        public string Log { get; set; }
    
        public virtual NxPresConvRun NxPresConvRun { get; set; }
    }
}
