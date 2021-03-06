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
    
    public partial class FACategory
    {
        public System.Guid FACategoryID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte IsCapitalized { get; set; }
        public byte IsDepreciable { get; set; }
        public byte IsLeased { get; set; }
        public byte IsRealProperty { get; set; }
        public System.Guid CostAcct { get; set; }
        public System.Guid AccumDeprAcct { get; set; }
        public System.Guid DeprExpAcct { get; set; }
        public System.Guid GainLossAcct { get; set; }
        public System.Guid AssetClearingAcct { get; set; }
        public Nullable<System.Guid> Exp179Acct { get; set; }
        public Nullable<System.Guid> Recap179Acct { get; set; }
        public Nullable<System.Guid> RetProceedsAcct { get; set; }
        public Nullable<System.Guid> RetDisposalCostAcct { get; set; }
        public string FAUSIRCPropSec { get; set; }
        public byte IsTangible { get; set; }
        public string FAACRSType { get; set; }
        public string FAMACRSType { get; set; }
        public string FAPropTaxCode { get; set; }
        public string NumberMask { get; set; }
    
        public virtual GLNatural GLNatural { get; set; }
        public virtual GLNatural GLNatural1 { get; set; }
        public virtual GLNatural GLNatural2 { get; set; }
        public virtual GLNatural GLNatural3 { get; set; }
        public virtual GLNatural GLNatural4 { get; set; }
        public virtual GLNatural GLNatural5 { get; set; }
        public virtual GLNatural GLNatural6 { get; set; }
        public virtual GLNatural GLNatural7 { get; set; }
        public virtual GLNatural GLNatural8 { get; set; }
    }
}
