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
    
    public partial class NxTempMattersProcess
    {
        public System.Guid NxTempMattersProcessID { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public Nullable<System.Guid> ProcessUser { get; set; }
        public Nullable<System.Guid> PIID { get; set; }
    
        public virtual NxUser NxUser { get; set; }
    }
}
