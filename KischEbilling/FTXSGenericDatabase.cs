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
    
    public partial class FTXSGenericDatabase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FTXSGenericDatabase()
        {
            this.FTXSGenericDBColls = new HashSet<FTXSGenericDBColl>();
        }
    
        public System.Guid FTXSGenericDatabaseID { get; set; }
        public string GenDBName { get; set; }
        public string FTXDatabaseType { get; set; }
        public byte IsUseWindowsAuthForDB { get; set; }
        public string DatabaseUserID { get; set; }
        public string DatabasePassword { get; set; }
        public byte IsUse3EConnection { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FTXSGenericDBColl> FTXSGenericDBColls { get; set; }
    }
}
