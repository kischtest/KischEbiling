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
    
    public partial class ChrgType
    {
        public System.Guid ChrgTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ChrgCatList { get; set; }
        public string TransactionType { get; set; }
        public Nullable<System.Guid> GLNatural1 { get; set; }
        public Nullable<System.Guid> GLNatural2 { get; set; }
        public Nullable<System.Guid> GLNatural3 { get; set; }
        public byte IsRequireTkpr { get; set; }
        public Nullable<byte> IsWIP { get; set; }
        public byte IsFeeOnly { get; set; }
        public byte IsCostOnly { get; set; }
        public Nullable<System.Guid> LangDescription { get; set; }
        public byte IsICB { get; set; }
    
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural4 { get; set; }
        public virtual GLNatural GLNatural5 { get; set; }
    }
}
