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
    
    public partial class Phase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phase()
        {
            this.ChargeGlobalChanges = new HashSet<ChargeGlobalChange>();
            this.ChargeGlobalChanges1 = new HashSet<ChargeGlobalChange>();
            this.ChrgCards = new HashSet<ChrgCard>();
            this.ChrgCards1 = new HashSet<ChrgCard>();
            this.ChrgCardPendings = new HashSet<ChrgCardPending>();
            this.ChrgCardPendings1 = new HashSet<ChrgCardPending>();
            this.CostCards = new HashSet<CostCard>();
            this.CostCards1 = new HashSet<CostCard>();
            this.CostCardPendings = new HashSet<CostCardPending>();
            this.CostCardPendings1 = new HashSet<CostCardPending>();
            this.CostGlobalChanges = new HashSet<CostGlobalChange>();
            this.CostGlobalChanges1 = new HashSet<CostGlobalChange>();
            this.EBillValListRulesDetails = new HashSet<EBillValListRulesDetail>();
            this.EBillValListRulesDetails1 = new HashSet<EBillValListRulesDetail>();
            this.EBillValRunDetails = new HashSet<EBillValRunDetail>();
            this.EBillValRunDetails1 = new HashSet<EBillValRunDetail>();
            this.MattBudgets = new HashSet<MattBudget>();
            this.MattBudgets1 = new HashSet<MattBudget>();
            this.MattPhaseExceptions = new HashSet<MattPhaseException>();
            this.ProfDetails = new HashSet<ProfDetail>();
            this.ProfDetails1 = new HashSet<ProfDetail>();
            this.ProfDetails2 = new HashSet<ProfDetail>();
            this.ProfDetails3 = new HashSet<ProfDetail>();
            this.RcptGLs = new HashSet<RcptGL>();
            this.RcptGLs1 = new HashSet<RcptGL>();
            this.TaskExceptions = new HashSet<TaskException>();
            this.Timecards = new HashSet<Timecard>();
            this.Timecards1 = new HashSet<Timecard>();
            this.TimeCardPendings = new HashSet<TimeCardPending>();
            this.TimeCardPendings1 = new HashSet<TimeCardPending>();
            this.TimeGlobalChanges = new HashSet<TimeGlobalChange>();
            this.TimeGlobalChanges1 = new HashSet<TimeGlobalChange>();
        }
    
        public System.Guid PhaseID { get; set; }
        public string Description { get; set; }
        public string PhaseList { get; set; }
        public string Code { get; set; }
        public string FirmPhase { get; set; }
        public byte IsStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChargeGlobalChange> ChargeGlobalChanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChargeGlobalChange> ChargeGlobalChanges1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgCard> ChrgCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgCard> ChrgCards1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgCardPending> ChrgCardPendings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChrgCardPending> ChrgCardPendings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostCard> CostCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostCard> CostCards1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostCardPending> CostCardPendings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostCardPending> CostCardPendings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostGlobalChange> CostGlobalChanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostGlobalChange> CostGlobalChanges1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EBillValListRulesDetail> EBillValListRulesDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EBillValListRulesDetail> EBillValListRulesDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EBillValRunDetail> EBillValRunDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EBillValRunDetail> EBillValRunDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MattBudget> MattBudgets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MattBudget> MattBudgets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MattPhaseException> MattPhaseExceptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfDetail> ProfDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfDetail> ProfDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfDetail> ProfDetails2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfDetail> ProfDetails3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptGL> RcptGLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcptGL> RcptGLs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskException> TaskExceptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timecard> Timecards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timecard> Timecards1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeCardPending> TimeCardPendings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeCardPending> TimeCardPendings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeGlobalChange> TimeGlobalChanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeGlobalChange> TimeGlobalChanges1 { get; set; }
    }
}
