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
    
    public partial class BiztalkImportScheduler
    {
        public System.Guid BiztalkImportSchedulerID { get; set; }
        public string WebServiceURL { get; set; }
        public string ImportFileLocation { get; set; }
        public string ImportFileName { get; set; }
        public Nullable<System.Guid> ImportType { get; set; }
    
        public virtual NxIntegrationImportType NxIntegrationImportType { get; set; }
    }
}
