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
    
    public partial class RMWill
    {
        public System.Guid RMWillsID { get; set; }
        public int WillsIndex { get; set; }
        public Nullable<System.DateTime> WillDate { get; set; }
        public string MaritalStatus { get; set; }
        public byte IsRevoked { get; set; }
        public byte IsSupByProbate { get; set; }
        public string NxCurrencyCode { get; set; }
        public Nullable<System.DateTime> ConvDate { get; set; }
        public Nullable<decimal> EstateValue { get; set; }
        public Nullable<int> NumPkts { get; set; }
        public string Comments { get; set; }
        public string Comments_UnformattedText { get; set; }
        public string RMWillSubtypeList { get; set; }
    }
}
