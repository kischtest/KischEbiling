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
    
    public partial class DataValidationInfo
    {
        public System.Guid DataValidationInfoID { get; set; }
        public Nullable<int> DataValidation { get; set; }
        public int DataValidationInfoIndex { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string TableName { get; set; }
        public Nullable<int> Count { get; set; }
        public string Result { get; set; }
        public string ValidationSQL { get; set; }
        public string ErrorMsg { get; set; }
        public Nullable<byte> IsSelected { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}