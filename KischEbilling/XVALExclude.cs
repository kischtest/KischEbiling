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
    
    public partial class XVALExclude
    {
        public System.Guid XVALExcludesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int XVALExcludesIndex { get; set; }
        public string ErrorMessage { get; set; }
        public Nullable<byte> Include { get; set; }
        public string GLUnitRule { get; set; }
        public string GLNaturalRule { get; set; }
        public string GLDepartmentRule { get; set; }
        public string GLOfficeRule { get; set; }
        public string GLTimekeeperRule { get; set; }
        public string GLSectionRule { get; set; }
        public string GLPracticeGroupRule { get; set; }
        public string GLTitleRule { get; set; }
        public string GLWorkTypeRule { get; set; }
        public string GLArrangementRule { get; set; }
        public byte IsActive { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
        public string GLActivityRule { get; set; }
    }
}
