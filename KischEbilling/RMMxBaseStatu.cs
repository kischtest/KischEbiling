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
    
    public partial class RMMxBaseStatu
    {
        public System.Guid RMMxBaseStatusID { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> RMSubmatter { get; set; }
        public string RMCategory { get; set; }
        public string Office { get; set; }
        public string RMContainerType { get; set; }
        public string RMFileType { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string RMLocation { get; set; }
    }
}
