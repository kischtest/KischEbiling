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
    
    public partial class TimeBill
    {
        public System.Guid TimeBillID { get; set; }
        public int TimeBillIndex { get; set; }
        public Nullable<int> ParTimeBill { get; set; }
        public int TimeCard { get; set; }
        public int ARMaster { get; set; }
        public int InvMaster { get; set; }
        public System.Guid WorkMattEffDate { get; set; }
        public System.Guid BillMattEffDate { get; set; }
        public System.Guid TkprEffDate { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> CurrDate { get; set; }
        public string TaxCode { get; set; }
        public Nullable<decimal> WorkHrs { get; set; }
        public Nullable<decimal> WorkAmt { get; set; }
        public Nullable<decimal> StdAmt { get; set; }
        public Nullable<decimal> BillHrs { get; set; }
        public Nullable<decimal> BillAmt { get; set; }
        public byte IsReversed { get; set; }
        public Nullable<decimal> WorkHrsColl { get; set; }
        public Nullable<decimal> WorkAmtColl { get; set; }
        public Nullable<decimal> StdAmtColl { get; set; }
        public Nullable<decimal> BillHrsWDn { get; set; }
        public Nullable<decimal> BillHrsWUp { get; set; }
        public Nullable<decimal> BillHrsColl { get; set; }
        public Nullable<decimal> BillAmtWDn { get; set; }
        public Nullable<decimal> BillAmtWUp { get; set; }
        public Nullable<decimal> BillAmtColl { get; set; }
        public Nullable<decimal> WorkHrsWOff { get; set; }
        public Nullable<decimal> WorkAmtWOff { get; set; }
        public Nullable<decimal> StdAmtWOff { get; set; }
        public Nullable<decimal> BillHrsWOff { get; set; }
        public Nullable<decimal> BillAmtWOff { get; set; }
        public Nullable<decimal> WorkHrsBal { get; set; }
        public Nullable<decimal> WorkAmtBal { get; set; }
        public Nullable<decimal> StdAmtBal { get; set; }
        public Nullable<decimal> BillHrsBal { get; set; }
        public Nullable<decimal> BillAmtBal { get; set; }
        public Nullable<decimal> UnitCurrRate { get; set; }
        public Nullable<decimal> FirmCurrRate { get; set; }
        public byte IsAdjustment { get; set; }
        public string ProfAdjustType { get; set; }
        public Nullable<decimal> WIPHrs { get; set; }
        public Nullable<decimal> WIPAmt { get; set; }
        public Nullable<decimal> RefAmt { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> Rpt1CurrRate { get; set; }
        public Nullable<decimal> Rpt2CurrRate { get; set; }
        public Nullable<decimal> Rpt3CurrRate { get; set; }
        public byte IsAdjCRNote { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string PurgeType { get; set; }
        public string Disposition { get; set; }
        public Nullable<System.DateTime> GLDateGlobalChange { get; set; }
        public System.DateTime GLDate { get; set; }
    
        public virtual MattDate MattDate { get; set; }
        public virtual MattDate MattDate1 { get; set; }
        public virtual TkprDate TkprDate { get; set; }
    }
}
