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
    
    public partial class Cft3TierBasicRPMCaseDtl
    {
        public System.Guid Cft3TierBasicRPMCaseDtlID { get; set; }
        public Nullable<System.Guid> Cft3TierNxItem { get; set; }
        public Nullable<int> MattIndex { get; set; }
        public Nullable<int> CmCase { get; set; }
        public Nullable<System.Guid> CftRelatedParty { get; set; }
    
        public virtual CftRelatedParty CftRelatedParty1 { get; set; }
    }
}
