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
    
    public partial class CftFilterAttributeJoin
    {
        public System.Guid CftFilterAttributeJoinID { get; set; }
        public int FltrAttrJoinIndex { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string FromArchetype { get; set; }
        public string FromAttribute { get; set; }
        public string ToArchetype { get; set; }
        public string ToAttribute { get; set; }
        public Nullable<byte> IsTerminal { get; set; }
        public string TargetAttribute { get; set; }
        public Nullable<int> CftFilterAttribute { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}