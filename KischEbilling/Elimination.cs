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
    
    public partial class Elimination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elimination()
        {
            this.EliminationLines = new HashSet<EliminationLine>();
        }
    
        public System.Guid EliminationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NxUnit { get; set; }
        public Nullable<int> ElimMask { get; set; }
        public string GLBook { get; set; }
        public string GLType { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EliminationLine> EliminationLines { get; set; }
    }
}
