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
    
    public partial class MattEBillLEDE
    {
        public System.Guid MattEBillLEDESID { get; set; }
        public System.Guid MatterAdditionalInfo { get; set; }
        public string ClientCompanyCode { get; set; }
        public string ClientContactFirstName { get; set; }
        public string ClientContactLastName { get; set; }
        public string RemitToAddressCity { get; set; }
        public string RemitToAddressCountry { get; set; }
        public string RemitToAddressPostalCode { get; set; }
        public string RemitToAddressState { get; set; }
        public string RemitToAddressStreet { get; set; }
        public string AFAClass { get; set; }
        public string BillingCycle { get; set; }
        public string BillingCycleIteration { get; set; }
        public string CompanyCode { get; set; }
        public string AccountTitle { get; set; }
        public string LawFirmTaxId { get; set; }
        public string PaymentMethod { get; set; }
        public string EntityBilledCountry { get; set; }
        public string ArchetypeCode { get; set; }
        public Nullable<System.Guid> CurrProcItemID { get; set; }
        public Nullable<System.Guid> LastProcItemID { get; set; }
        public Nullable<System.Guid> OrigProcItemID { get; set; }
        public Nullable<byte> HasAttachments { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }
    
        public virtual MatterAdditionalInfo MatterAdditionalInfo1 { get; set; }
    }
}
