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
    
    public partial class MxDepreciationBatchRun
    {
        public System.Guid MxDepreciationBatchRunID { get; set; }
        public Nullable<int> FADeprHistory { get; set; }
        public string NxCurrencyCode { get; set; }
        public Nullable<System.Guid> GLUnit { get; set; }
        public string FACategory { get; set; }
        public Nullable<int> FAAssetBook { get; set; }
        public Nullable<int> FAAsset { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public Nullable<System.Guid> GLOffice { get; set; }
        public Nullable<System.Guid> GLDepartment { get; set; }
        public string FADeprMethod { get; set; }
        public string FABook { get; set; }
    
        public virtual GLDepartment GLDepartment1 { get; set; }
        public virtual GLOffice GLOffice1 { get; set; }
        public virtual GLUnit GLUnit1 { get; set; }
    }
}
