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
    
    public partial class Cft3TierMatterDtl
    {
        public System.Guid Cft3TierMatterDtlID { get; set; }
        public string MatterNumber { get; set; }
        public string MatterName { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> LastWorked { get; set; }
        public Nullable<System.DateTime> LastBilled { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string MatterContact { get; set; }
        public string Timekeeper { get; set; }
        public string Description { get; set; }
        public string Narrative { get; set; }
        public string Narrative_UnformattedText { get; set; }
        public Nullable<System.Guid> Cft3TierNxItem { get; set; }
        public Nullable<int> ClientIndex { get; set; }
        public Nullable<int> EntityIndex { get; set; }
        public string FoundItemID { get; set; }
        public string HitType { get; set; }
        public string Role { get; set; }
        public string Relationship { get; set; }
        public Nullable<int> MatterIndex { get; set; }
        public string ClientHits { get; set; }
        public string MatterHits { get; set; }
        public string EntityHits { get; set; }
        public string RPHits { get; set; }
        public string GenericHits { get; set; }
        public string ContactInfo { get; set; }
    }
}
