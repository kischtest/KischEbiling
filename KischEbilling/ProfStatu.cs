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
    
    public partial class ProfStatu
    {
        public System.Guid ProfStatusID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<byte> IsClose { get; set; }
        public Nullable<byte> IsAllowInvNumber { get; set; }
        public string Comment { get; set; }
        public byte IsHold { get; set; }
        public byte IsInfoOnly { get; set; }
        public byte IsAssignInvoice { get; set; }
        public byte IsSaveEdits { get; set; }
        public byte IsRevertToOrigCurrency { get; set; }
        public byte IsDistributedToMobileApps { get; set; }
        public byte IsReturnedFromMobileApps { get; set; }
        public byte IsMobileApproved { get; set; }
        public byte IsStock { get; set; }
    }
}
