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
    
    public partial class FrxEntity
    {
        public System.Guid FrxEntityID { get; set; }
        public int entity_num { get; set; }
        public string entity_code { get; set; }
        public string entity_desc { get; set; }
        public int acct_length { get; set; }
        public int mask_length { get; set; }
        public string acct_mask { get; set; }
        public int max_segs { get; set; }
        public string entity_key1 { get; set; }
        public string entity_key2 { get; set; }
        public int natural_seg { get; set; }
        public Nullable<int> rollup_level { get; set; }
        public Nullable<int> chg_seg_desc { get; set; }
        public Nullable<int> index_built { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
