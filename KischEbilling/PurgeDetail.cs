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
    
    public partial class PurgeDetail
    {
        public System.Guid PurgeDetailID { get; set; }
        public string ReqMatters { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public byte IsPurgeTime { get; set; }
        public byte IsPurgeCost { get; set; }
        public byte IsPurgeCharge { get; set; }
        public string PurgeType { get; set; }
        public byte IsPurgeOnProformas { get; set; }
        public string ReqTimeCards { get; set; }
        public string ReqCostCards { get; set; }
        public string ReqChrgCards { get; set; }
        public byte IsNoActivity { get; set; }
        public Nullable<System.DateTime> LastActivity { get; set; }
    }
}
