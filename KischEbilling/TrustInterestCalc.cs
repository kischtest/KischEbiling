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
    
    public partial class TrustInterestCalc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrustInterestCalc()
        {
            this.TrustInterestCalcDets = new HashSet<TrustInterestCalcDet>();
        }
    
        public System.Guid TrustInterestCalcID { get; set; }
        public int BankAcctTrust { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime TranDate { get; set; }
        public System.DateTime GLDate { get; set; }
        public System.DateTime PostDate { get; set; }
        public Nullable<byte> IsReversed { get; set; }
        public Nullable<byte> IsReverseJournal { get; set; }
        public Nullable<System.DateTime> ReverseDate { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string ReverseReason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrustInterestCalcDet> TrustInterestCalcDets { get; set; }
    }
}
