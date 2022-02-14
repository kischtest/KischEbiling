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
    
    public partial class RcptInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RcptInvoice()
        {
            this.RcptInvoice1 = new HashSet<RcptInvoice>();
            this.RcptInvoiceAllocs = new HashSet<RcptInvoiceAlloc>();
            this.RcptInvoiceMatters = new HashSet<RcptInvoiceMatter>();
        }
    
        public System.Guid RcptInvoiceID { get; set; }
        public int RcptMaster { get; set; }
        public int InvMaster { get; set; }
        public System.Guid InvPayor { get; set; }
        public string RcptCurrency { get; set; }
        public System.DateTime RcptDate { get; set; }
        public decimal RcptAmt { get; set; }
        public string InvCurrency { get; set; }
        public Nullable<decimal> InvCurrRcptAmt { get; set; }
        public Nullable<decimal> InvCurrRcptAmtFee { get; set; }
        public Nullable<decimal> InvCurrRcptAmtHCo { get; set; }
        public Nullable<decimal> InvCurrRcptAmtSCo { get; set; }
        public Nullable<decimal> InvCurrRcptAmtTax { get; set; }
        public Nullable<decimal> InvCurrRcptAmtInt { get; set; }
        public Nullable<decimal> InvCurrRcptAmtBOA { get; set; }
        public Nullable<decimal> InvCurrRcptAmtOth { get; set; }
        public Nullable<decimal> RcptAmtFee { get; set; }
        public Nullable<decimal> RcptAmtHCo { get; set; }
        public Nullable<decimal> RcptAmtSCo { get; set; }
        public Nullable<decimal> RcptAmtTax { get; set; }
        public Nullable<decimal> RcptAmtInt { get; set; }
        public Nullable<decimal> RcptAmtBOA { get; set; }
        public Nullable<decimal> RcptAmtOth { get; set; }
        public Nullable<decimal> RcptExchangeRate { get; set; }
        public Nullable<System.Guid> RevRcptInvoice { get; set; }
        public Nullable<decimal> CalcedExcRate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
    
        public virtual InvPayor InvPayor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptInvoice> RcptInvoice1 { get; set; }
        public virtual RcptInvoice RcptInvoice2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptInvoiceAlloc> RcptInvoiceAllocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptInvoiceMatter> RcptInvoiceMatters { get; set; }
    }
}
