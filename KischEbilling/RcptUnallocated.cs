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
    
    public partial class RcptUnallocated
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RcptUnallocated()
        {
            this.RcptPosts = new HashSet<RcptPost>();
            this.RcptUnallocated1 = new HashSet<RcptUnallocated>();
        }
    
        public System.Guid RcptUnallocatedID { get; set; }
        public int RcptMaster { get; set; }
        public int Matter { get; set; }
        public string UnalType { get; set; }
        public System.DateTime RcptDate { get; set; }
        public string RcptCurrency { get; set; }
        public decimal RcptAmt { get; set; }
        public string SelectedCurr { get; set; }
        public Nullable<decimal> SelCurrRcptAmt { get; set; }
        public Nullable<decimal> SelCurrExchangeRate { get; set; }
        public Nullable<System.Guid> ParRcptUnallocated { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public Nullable<int> OrigARDetail { get; set; }
        public string ConvNumber { get; set; }
        public string ConvSource { get; set; }
        public string ConvGroup { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptPost> RcptPosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptUnallocated> RcptUnallocated1 { get; set; }
        public virtual RcptUnallocated RcptUnallocated2 { get; set; }
    }
}
