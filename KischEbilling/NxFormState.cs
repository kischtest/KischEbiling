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
    
    public partial class NxFormState
    {
        public System.Guid NxFormStateID { get; set; }
        public System.Guid UserID { get; set; }
        public string ProcessID { get; set; }
        public string StepID { get; set; }
        public string FormID { get; set; }
        public string StateName { get; set; }
        public string StateValue { get; set; }
    
        public virtual NxUser NxUser { get; set; }
    }
}
