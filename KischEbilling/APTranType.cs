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
    
    public partial class APTranType
    {
        public System.Guid APTranTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string APDocTypeList { get; set; }
        public string DescSource { get; set; }
        public byte IsAllowCost { get; set; }
        public byte IsAllowCharge { get; set; }
        public byte IsAllowTime { get; set; }
        public byte IsAllowNegValue { get; set; }
        public Nullable<byte> IsDefault { get; set; }
        public Nullable<int> APControlMask { get; set; }
        public Nullable<int> DirectToGLMask { get; set; }
        public Nullable<int> PurchaseDiscountMask { get; set; }
        public Nullable<int> FreightMask { get; set; }
        public Nullable<int> FinanceChargeMask { get; set; }
    }
}
