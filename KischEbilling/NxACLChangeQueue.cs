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
    
    public partial class NxACLChangeQueue
    {
        public System.Guid NxACLChangeQueueID { get; set; }
        public int ChangeType { get; set; }
        public string ChangedObject { get; set; }
        public System.Guid ChangedItemID { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    }
}
