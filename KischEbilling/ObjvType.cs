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
    
    public partial class ObjvType
    {
        public System.Guid ObjvTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ObjvDimension { get; set; }
        public string EntryDimensionDate { get; set; }
        public byte IsEntryTkpr { get; set; }
        public byte IsWorkDateAdj { get; set; }
        public string MatterFilter { get; set; }
        public string TkprFilter { get; set; }
    }
}
