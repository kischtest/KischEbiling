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
    
    public partial class MxWipBalancing
    {
        public System.Guid MxWipBalancingID { get; set; }
        public string StartPeriod { get; set; }
        public string EndPeriod { get; set; }
        public string GlNatural { get; set; }
        public string ReqOffices { get; set; }
        public byte IsIncludeNonBillable { get; set; }
        public Nullable<byte> UseWIP { get; set; }
        public Nullable<byte> UseWork { get; set; }
        public string BalancingPeriod { get; set; }
        public byte IsBalancingIntegrityRun { get; set; }
        public byte IsAutoCreatedFromParent { get; set; }
    }
}
