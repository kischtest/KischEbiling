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
    
    public partial class Department
    {
        public System.Guid DepartmentID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> GLDepartment { get; set; }
        public string DepartmentGroup { get; set; }
        public string IDMaskIdentifier { get; set; }
    
        public virtual GLDepartment GLDepartment1 { get; set; }
    }
}
