//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project2
    {
        public Project2()
        {
            this.ProjectPhase = new HashSet<ProjectPhase>();
            this.SurveyForm = new HashSet<SurveyForm>();
            this.Grants = new HashSet<Grant>();
            this.Publications = new HashSet<Publication>();
            this.ClientAgmt = new HashSet<ClientAgmt>();
        }
    
        public int Id { get; set; }
        public int PIId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public System.DateTime InitialDate { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public int LeadBiostatId { get; set; }
        public long OtherMemberBitSum { get; set; }
        public long StudyAreaBitSum { get; set; }
        public string StudyAreaOther { get; set; }
        public long HealthDateBitSum { get; set; }
        public string HealthDataOther { get; set; }
        public long StudyTypeBitSum { get; set; }
        public string StudyTypeOther { get; set; }
        public long StudyPopulationBitSum { get; set; }
        public string StudyPopulationOther { get; set; }
        public long ServiceBitSum { get; set; }
        public string ServiceOther { get; set; }
        public long GrantBitSum { get; set; }
        public string GrantOther { get; set; }
        public Nullable<bool> IsJuniorPI { get; set; }
        public Nullable<bool> HasMentor { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }
        public string MentorEmail { get; set; }
        public Nullable<bool> IsInternal { get; set; }
        public Nullable<bool> IsPilot { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsRmatrixRequest { get; set; }
        public Nullable<bool> IsRmatrixReport { get; set; }
        public string TypeOfPayment { get; set; }
        public Nullable<int> RmatrixNum { get; set; }
        public Nullable<System.DateTime> RmatrixSubDate { get; set; }
        public Nullable<System.DateTime> ProjectCompletionDate { get; set; }
        public string ProjectStatus { get; set; }
        public string Comments { get; set; }
        public bool IsApproved { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreationDate { get; set; }
        public byte ProjectType { get; set; }
        public byte CreditTo { get; set; }
        public Nullable<bool> IsOlaHawaiiRequest { get; set; }
        public Nullable<int> OlaHawaiiNum { get; set; }
        public Nullable<System.DateTime> OlaHawaiiSubDate { get; set; }
        public Nullable<byte> OlaHawaiiRequestType { get; set; }
        public Nullable<byte> IsHealthDisparity { get; set; }
        public Nullable<int> GrantDepartmentFundingType { get; set; }
        public string GrantDepartmentFundingOther { get; set; }
    
        public virtual Invest Invests { get; set; }
        public virtual ICollection<ProjectPhase> ProjectPhase { get; set; }
        public virtual ICollection<SurveyForm> SurveyForm { get; set; }
        public virtual ICollection<Grant> Grants { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
        public virtual ICollection<ClientAgmt> ClientAgmt { get; set; }
    }
}
