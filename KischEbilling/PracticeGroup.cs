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
    
    public partial class PracticeGroup
    {
        public System.Guid PracticeGroupID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> GLPracticeGroup { get; set; }
        public string IDMaskIdentifier { get; set; }
    
        public virtual GLPracticeGroup GLPracticeGroup1 { get; set; }
    }
}
