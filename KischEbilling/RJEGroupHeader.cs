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
    
    public partial class RJEGroupHeader
    {
        public System.Guid RJEGroupHeaderID { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string RJEGroupName { get; set; }
        public int RJEGroupHeaderIndex { get; set; }
        public string EventName { get; set; }
        public byte IsRunOnDemand { get; set; }
    }
}
