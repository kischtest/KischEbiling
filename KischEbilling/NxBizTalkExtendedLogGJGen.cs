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
    
    public partial class NxBizTalkExtendedLogGJGen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxBizTalkExtendedLogGJGen()
        {
            this.NxBizTalkExtLogGJGenericPerCurrTtls = new HashSet<NxBizTalkExtLogGJGenericPerCurrTtl>();
        }
    
        public System.Guid NxBizTalkExtendedLogGJGenID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> ExchangeDate { get; set; }
        public string GLType { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public Nullable<byte> ForeignExchange { get; set; }
        public Nullable<byte> AutoRev { get; set; }
        public Nullable<byte> InterCompanyGJE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkExtLogGJGenericPerCurrTtl> NxBizTalkExtLogGJGenericPerCurrTtls { get; set; }
    }
}
