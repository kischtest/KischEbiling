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
    
    public partial class NxSyncItem
    {
        public System.Guid NxSyncItemID { get; set; }
        public System.Guid ItemIDToSync { get; set; }
        public System.Guid SyncMap { get; set; }
        public System.Guid FwkUser { get; set; }
        public System.DateTime ModDateTime { get; set; }
        public string Tag { get; set; }
    
        public virtual NxFWKUser NxFWKUser { get; set; }
        public virtual NxSyncMap NxSyncMap { get; set; }
    }
}
