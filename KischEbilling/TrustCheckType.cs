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
    
    public partial class TrustCheckType
    {
        public System.Guid TrustCheckTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<int> DaysToClear { get; set; }
        public byte IsReverseDisbursement { get; set; }
        public byte IsEFT { get; set; }
    }
}
