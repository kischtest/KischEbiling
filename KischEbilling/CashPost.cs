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
    
    public partial class CashPost
    {
        public System.Guid CashPostID { get; set; }
        public Nullable<System.Guid> CashTranDetail { get; set; }
    
        public virtual CashTranDetail CashTranDetail1 { get; set; }
    }
}
