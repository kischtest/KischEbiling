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
    
    public partial class WV_MTkpr_ParamSave_CCC
    {
        public System.Guid WV_MTkpr_ParamSave_CCCID { get; set; }
        public Nullable<System.Guid> NxUser { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public string StartPeriod { get; set; }
        public string EndPeriod { get; set; }
        public string Currency { get; set; }
        public Nullable<byte> Option_Bill { get; set; }
        public Nullable<byte> Option_Resp { get; set; }
        public Nullable<byte> Option_Sup { get; set; }
        public Nullable<byte> Option_Org { get; set; }
        public Nullable<byte> Option_Pro { get; set; }
        public string Option_Mat_Or_Cli { get; set; }
        public Nullable<byte> Option_Fee_Only { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string PracticeGroup { get; set; }
        public string IndustryGroup { get; set; }
        public string MattDatePred { get; set; }
        public byte Option_Firm_Wide { get; set; }
        public string FirmMattDatePredSave { get; set; }
        public Nullable<byte> IsLTD { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual NxBaseUser NxBaseUser { get; set; }
    }
}
