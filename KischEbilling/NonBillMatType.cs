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
    
    public partial class NonBillMatType
    {
        public System.Guid NonBillMatTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte IsTimeBill { get; set; }
        public byte IsCostBill { get; set; }
        public byte IsChargeBill { get; set; }
        public Nullable<byte> IsTimeNB { get; set; }
        public Nullable<byte> IsCostNB { get; set; }
        public Nullable<byte> IsChargeNB { get; set; }
        public Nullable<byte> IsDefaultTimeBill { get; set; }
        public Nullable<byte> IsDefaultCostBill { get; set; }
        public Nullable<byte> IsDefaultChargeBill { get; set; }
    }
}
