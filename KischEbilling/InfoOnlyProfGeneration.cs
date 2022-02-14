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
    
    public partial class InfoOnlyProfGeneration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoOnlyProfGeneration()
        {
            this.InfoOnlyProfGenSorts = new HashSet<InfoOnlyProfGenSort>();
            this.ProformaEvents = new HashSet<ProformaEvent>();
        }
    
        public System.Guid InfoOnlyProfGenerationID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> WorkStart { get; set; }
        public Nullable<System.DateTime> WorkEnd { get; set; }
        public Nullable<System.DateTime> BillStart { get; set; }
        public Nullable<System.DateTime> BillEnd { get; set; }
        public Nullable<int> Invoice { get; set; }
        public Nullable<int> Client { get; set; }
        public Nullable<int> Matter { get; set; }
        public string ProfStatus { get; set; }
        public Nullable<byte> IsIncludeBillable { get; set; }
        public Nullable<byte> IsIncludeNonbillable { get; set; }
        public Nullable<byte> IsCreateSingleProforma { get; set; }
        public Nullable<byte> IsIncludeOtherProf { get; set; }
        public string MatterPredicate { get; set; }
        public string PrinterXML { get; set; }
        public string InternalComments { get; set; }
        public Nullable<byte> IsUnbilledOnly { get; set; }
        public Nullable<byte> IsBilledOnly { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public byte IsInactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoOnlyProfGenSort> InfoOnlyProfGenSorts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaEvent> ProformaEvents { get; set; }
    }
}
