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
    
    public partial class FlatFeeClose
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlatFeeClose()
        {
            this.FlatFeeCloseMatters = new HashSet<FlatFeeCloseMatter>();
        }
    
        public System.Guid FlatFeeCloseID { get; set; }
        public string OperatingUnit { get; set; }
        public string ReceiptType { get; set; }
        public string ReqMatters { get; set; }
        public string ReqTimeType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlatFeeCloseMatter> FlatFeeCloseMatters { get; set; }
    }
}