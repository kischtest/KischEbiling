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
    
    public partial class PayeeStatu
    {
        public System.Guid PayeeStatusID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte IsPOOpen { get; set; }
        public byte IsVchrOpen { get; set; }
        public byte IsCkOpen { get; set; }
        public byte Is1099Open { get; set; }
        public byte IsAuthorized { get; set; }
        public byte IsMerged { get; set; }
    }
}