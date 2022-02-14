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
    
    public partial class CollectionInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CollectionInvoice()
        {
            this.CollectionPromises = new HashSet<CollectionPromise>();
            this.CollPromiseInvoices = new HashSet<CollPromiseInvoice>();
        }
    
        public System.Guid CollectionInvoiceID { get; set; }
        public int CollectionItem { get; set; }
        public System.Guid InvPayor { get; set; }
        public string BillingGroup { get; set; }
        public Nullable<decimal> OrigCollAmt { get; set; }
        public Nullable<System.DateTime> ConvDate { get; set; }
        public string Currency { get; set; }
        public string Comments { get; set; }
        public Nullable<decimal> DisputedAmount { get; set; }
        public Nullable<int> DisputeResolutionResp { get; set; }
        public string InvoiceDisputeReason { get; set; }
        public Nullable<int> ProformaSite { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual InvPayor InvPayor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionPromise> CollectionPromises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollPromiseInvoice> CollPromiseInvoices { get; set; }
    }
}