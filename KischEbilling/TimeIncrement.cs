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
    
    public partial class TimeIncrement
    {
        public System.Guid TimeIncrementID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Increment { get; set; }
        public string RndBasisList { get; set; }
        public Nullable<byte> IsAutoRound { get; set; }
    }
}
