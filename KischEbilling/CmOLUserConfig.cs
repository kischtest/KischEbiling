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
    
    public partial class CmOLUserConfig
    {
        public System.Guid CmOLUserConfigID { get; set; }
        public int CmOLUserConfigIndex { get; set; }
        public System.Guid NxBaseUser { get; set; }
        public byte IsEmailRemind { get; set; }
        public byte IsApptRemind { get; set; }
        public byte IsOLRemind { get; set; }
        public byte IsSendSyncLog { get; set; }
        public string Send3EEventAs { get; set; }
        public string Send3ETaskAs { get; set; }
        public string SendOLApptAs { get; set; }
        public string SendOLTaskAs { get; set; }
    
        public virtual NxBaseUser NxBaseUser1 { get; set; }
    }
}
