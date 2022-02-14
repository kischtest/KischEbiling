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
    
    public partial class WV_Statistics_CCC
    {
        public System.Guid WV_Statistics_CCCID { get; set; }
        public Nullable<System.Guid> NxUser { get; set; }
        public Nullable<int> Timekeeper { get; set; }
        public Nullable<int> Matter { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> WorkingTimekeeper { get; set; }
        public string WV_TkprType { get; set; }
        public string Currency { get; set; }
        public string PeriodRange { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> Bill_Amt_Fees { get; set; }
        public Nullable<decimal> Bill_Amt_Costs { get; set; }
        public Nullable<decimal> Bill_Amt_Charges { get; set; }
        public Nullable<decimal> Coll_Amt_Fees { get; set; }
        public Nullable<decimal> Coll_Amt_Costs { get; set; }
        public Nullable<decimal> Coll_Amt_Charges { get; set; }
        public Nullable<decimal> HrsUpDown { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public Nullable<decimal> NBHrs { get; set; }
        public Nullable<decimal> NB_Amt_Fees { get; set; }
        public Nullable<decimal> NB_Amt_Costs { get; set; }
        public Nullable<decimal> NB_Amt_Charges { get; set; }
        public Nullable<decimal> Ref_Amt { get; set; }
        public Nullable<decimal> Std_Amt { get; set; }
        public Nullable<decimal> Woff_Hrs { get; set; }
        public Nullable<decimal> Woff_Amt_Fees { get; set; }
        public Nullable<decimal> Woff_Amt_Costs { get; set; }
        public Nullable<decimal> Woff_Amt_Charges { get; set; }
        public Nullable<decimal> Work_Amt_Fees { get; set; }
        public Nullable<decimal> Work_Amt_Costs { get; set; }
        public Nullable<decimal> Work_Amt_Charges { get; set; }
        public Nullable<decimal> Work_Hrs { get; set; }
        public Nullable<decimal> Bill_Amt_Fees_W { get; set; }
        public Nullable<decimal> Bill_Amt_Costs_W { get; set; }
        public Nullable<decimal> Bill_Amt_Charges_W { get; set; }
        public Nullable<decimal> Bill_Hrs { get; set; }
        public Nullable<decimal> Bill_Hrs_W { get; set; }
        public Nullable<decimal> Coll_Hrs { get; set; }
        public Nullable<decimal> Coll_Amt_Ref { get; set; }
        public Nullable<decimal> Coll_Amt_Std { get; set; }
        public Nullable<decimal> Coll_Amt_Work { get; set; }
        public Nullable<decimal> WD_Hours { get; set; }
        public Nullable<decimal> WD_Amt_Fees { get; set; }
        public Nullable<decimal> WD_Amt_Costs { get; set; }
        public Nullable<decimal> WD_Amt_Charges { get; set; }
        public Nullable<decimal> WU_Hours { get; set; }
        public Nullable<decimal> WU_Amt_Fees { get; set; }
        public Nullable<decimal> WU_Amt_Costs { get; set; }
        public Nullable<decimal> WU_Amt_Charges { get; set; }
        public Nullable<decimal> Bill_Amt_Ref { get; set; }
        public Nullable<decimal> Bill_Amt_Std { get; set; }
        public byte IsCurrentStats { get; set; }
        public string FirmMattDatePred { get; set; }
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
