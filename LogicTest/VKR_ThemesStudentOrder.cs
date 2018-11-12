//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class VKR_ThemesStudentOrder
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int GraduateYear { get; set; }
        public System.Guid StudentOid { get; set; }
        public Nullable<System.Guid> StudyPlanId { get; set; }
        public Nullable<int> NRNPRId { get; set; }
        public Nullable<int> NRNPRChangedId { get; set; }
        public Nullable<int> NRNPRChanged2Id { get; set; }
        public Nullable<int> NR2Id { get; set; }
        public Nullable<int> NR2ChangedId { get; set; }
        public Nullable<int> NR2Changed2Id { get; set; }
        public Nullable<int> ReviewNPR1Id { get; set; }
        public Nullable<int> ReviewNPR1ChangedId { get; set; }
        public Nullable<int> ReviewNPR2Id { get; set; }
        public Nullable<int> ReviewNPR2ChangedId { get; set; }
        public Nullable<int> ReviewPartnerPerson1Id { get; set; }
        public Nullable<int> ReviewPartnerPerson1ChangedId { get; set; }
        public Nullable<int> ReviewPartnerPerson2Id { get; set; }
        public Nullable<int> ReviewPartnerPerson2ChangedId { get; set; }
        public Nullable<int> ConsultId { get; set; }
        public Nullable<System.Guid> NPR_SapId { get; set; }
        public string NPR_FIO { get; set; }
        public string NPR_Position { get; set; }
        public string NPR_Degree { get; set; }
        public string NPR_Rank { get; set; }
        public string NPR_Account { get; set; }
        public string NPR_Chair { get; set; }
        public string NPR_Faculty { get; set; }
        public string Priority { get; set; }
        public string VKRName { get; set; }
        public string VKRNameEng { get; set; }
        public string VKRName_Changed { get; set; }
        public string VKRNameEng_Changed { get; set; }
        public string VKRName_ChangedDoc { get; set; }
        public string VKRName_Changed2 { get; set; }
        public string VKRNameEng_Changed2 { get; set; }
        public string VKRName_ChangedDoc2 { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDocument { get; set; }
        public Nullable<int> OrganizationId2 { get; set; }
        public string OrganizationName2 { get; set; }
        public string OrganizationDocument2 { get; set; }
        public Nullable<int> OrganizationId3 { get; set; }
        public string OrganizationName3 { get; set; }
        public string OrganizationDocument3 { get; set; }
        public Nullable<int> OrganizationId_Changed2 { get; set; }
        public string OrganizationName_Changed2 { get; set; }
        public string OrganizationDocument_Changed2 { get; set; }
        public Nullable<bool> OrganizationDop_Changed2 { get; set; }
        public Nullable<bool> OrganizationNotAgreed_Changed2 { get; set; }
        public Nullable<System.Guid> Review_NPR_SapId { get; set; }
        public string Review_NPR_FIO { get; set; }
        public string Review_NPR_Position { get; set; }
        public string Review_NPR_Degree { get; set; }
        public string Review_NPR_Rank { get; set; }
        public string Review_NPR_Account { get; set; }
        public string Review_NPR_Chair { get; set; }
        public string Review_NPR_Faculty { get; set; }
        public Nullable<int> Review_PartnerPersonId { get; set; }
        public string Review_PP_FIO { get; set; }
        public string Review_PP_Degree { get; set; }
        public string Review_PP_Rank { get; set; }
        public string Review_PP_Account { get; set; }
        public string Review_PP_OrgPosition { get; set; }
        public bool Review_NotUsePrevious { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public bool OrderDop { get; set; }
        public Nullable<int> StudentNumberInOrder { get; set; }
        public string OrderNumberReview { get; set; }
        public Nullable<System.DateTime> OrderDateReview { get; set; }
        public Nullable<int> StudentNumberInOrderReview { get; set; }
        public string AuthorUpdated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string AuthorFreese { get; set; }
        public Nullable<System.DateTime> DateFreeze { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> VKR_ThemesId { get; set; }
        public Nullable<int> GrantId { get; set; }
    
        public virtual Grant Grant { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Organization Organization1 { get; set; }
        public virtual Organization Organization2 { get; set; }
        public virtual Organization Organization3 { get; set; }
        public virtual Student Student { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review1 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review2 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review3 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review4 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review5 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review6 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review7 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review8 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review9 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review10 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review11 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review12 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review13 { get; set; }
        public virtual VKR_ThemesStudentOrder_NR_Review VKR_ThemesStudentOrder_NR_Review14 { get; set; }
    }
}
