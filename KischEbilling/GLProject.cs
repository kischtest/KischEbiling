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
    
    public partial class GLProject
    {
        public System.Guid GLProjectID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ProjNum { get; set; }
        public int ProjIndex { get; set; }
        public Nullable<System.DateTime> EstCompDate { get; set; }
        public Nullable<System.Guid> GLActivity { get; set; }
        public Nullable<System.Guid> GLNatural { get; set; }
    
        public virtual GLActivity GLActivity1 { get; set; }
        public virtual GLNatural GLNatural1 { get; set; }
    }
}
