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
    
    public partial class RMProbate
    {
        public System.Guid RMProbatesID { get; set; }
        public int ProbatesIndex { get; set; }
        public Nullable<System.DateTime> ProbateDate { get; set; }
        public Nullable<System.DateTime> DeathDate { get; set; }
        public Nullable<System.DateTime> WillDate { get; set; }
        public Nullable<decimal> GrossEstateValue { get; set; }
        public Nullable<decimal> NetEstateValue { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> ConvDate { get; set; }
        public string ProbateRegistry { get; set; }
        public Nullable<int> NumPkts { get; set; }
        public string Comments { get; set; }
        public string Comments_UnformattedText { get; set; }
    }
}
