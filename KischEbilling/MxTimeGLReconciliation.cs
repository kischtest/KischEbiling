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
    
    public partial class MxTimeGLReconciliation
    {
        public System.Guid MxTimeGLReconciliationID { get; set; }
        public byte IsIncludeWorkPostings { get; set; }
        public byte IsIncludeBillPostings { get; set; }
        public byte IsIncludeRcptPostings { get; set; }
        public byte IsIncludeNoPostings { get; set; }
        public string GLType { get; set; }
        public string Timecard { get; set; }
        public string Timebill { get; set; }
        public string TimeRcpt { get; set; }
        public byte IsIncludeDirectGLPostings { get; set; }
        public byte IsBillableOnly { get; set; }
    }
}
