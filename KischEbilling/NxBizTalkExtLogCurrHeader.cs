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
    
    public partial class NxBizTalkExtLogCurrHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NxBizTalkExtLogCurrHeader()
        {
            this.NxBizTalkExtLogCurrencies = new HashSet<NxBizTalkExtLogCurrency>();
        }
    
        public System.Guid NxBizTalkExtLogCurrHeaderID { get; set; }
        public string TargetCurrency { get; set; }
        public string AdditionalDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NxBizTalkExtLogCurrency> NxBizTalkExtLogCurrencies { get; set; }
    }
}
