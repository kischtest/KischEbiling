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
    
    public partial class TaxJournal
    {
        public System.Guid TaxJournalID { get; set; }
        public string TaxSourceList { get; set; }
        public System.DateTime TaxDate { get; set; }
        public System.DateTime TranDate { get; set; }
        public System.DateTime GLDate { get; set; }
        public string Tax { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> AccrualAmt { get; set; }
        public Nullable<decimal> CashAmt { get; set; }
        public Nullable<decimal> ReportedAmt { get; set; }
        public Nullable<decimal> SourceAmt { get; set; }
        public Nullable<decimal> ImportAmt { get; set; }
        public Nullable<decimal> ImportTax { get; set; }
        public string RefNumber1 { get; set; }
        public string RefNumber2 { get; set; }
        public string TaxID { get; set; }
        public string Country { get; set; }
        public Nullable<decimal> FirmCurrRate { get; set; }
        public Nullable<decimal> UnitCurrRate { get; set; }
        public Nullable<System.Guid> VchrTax { get; set; }
        public Nullable<System.Guid> CkDetail { get; set; }
        public Nullable<int> ARDetail { get; set; }
        public string TaxCountryList { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public string TaxCode { get; set; }
        public string FromTaxArea { get; set; }
        public string ToTaxArea { get; set; }
        public Nullable<System.Guid> TaxDateID { get; set; }
        public Nullable<int> GLAcct { get; set; }
        public Nullable<int> ClearingGLAcct { get; set; }
        public string RptCurrency { get; set; }
        public string Office { get; set; }
        public string MatterRef { get; set; }
        public string VendorClientRef { get; set; }
        public string PayeePayorRef { get; set; }
        public string AltNum { get; set; }
        public Nullable<decimal> RptCurrRate { get; set; }
        public Nullable<int> TaxClearing { get; set; }
        public string GLType { get; set; }
        public Nullable<decimal> RatePercent { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual CkDetail CkDetail1 { get; set; }
        public virtual TaxDate TaxDate1 { get; set; }
        public virtual VchrTax VchrTax1 { get; set; }
    }
}
