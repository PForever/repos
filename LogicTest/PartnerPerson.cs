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
    
    public partial class PartnerPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartnerPerson()
        {
            this.GAK_LP_Person = new HashSet<GAK_LP_Person>();
            this.GAK_MemberPP = new HashSet<GAK_MemberPP>();
            this.GAK_MemberPP_archive = new HashSet<GAK_MemberPP_archive>();
            this.GAK_MemberPP_log = new HashSet<GAK_MemberPP_log>();
            this.GAK_Number = new HashSet<GAK_Number>();
            this.GAK_Number_archive = new HashSet<GAK_Number_archive>();
            this.GAK_Number_log = new HashSet<GAK_Number_log>();
            this.OrganizationPersons = new HashSet<OrganizationPerson>();
            this.PartnerPersonActivityAreas = new HashSet<PartnerPersonActivityArea>();
            this.PartnerPersonOrganizationNotAvailableInGAK_Log = new HashSet<PartnerPersonOrganizationNotAvailableInGAK_Log>();
            this.SOP_Members = new HashSet<SOP_Members>();
            this.VKR_Themes = new HashSet<VKR_Themes>();
            this.VKR_Themes1 = new HashSet<VKR_Themes>();
            this.VKR_ThemesStudentOrder_NR_Review = new HashSet<VKR_ThemesStudentOrder_NR_Review>();
        }
    
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string NameInitials { get; set; }
        public Nullable<int> PartnerPersonPrefixId { get; set; }
        public string LastNameEng { get; set; }
        public string FirstNameEng { get; set; }
        public string SecondNameEng { get; set; }
        public string NameEng { get; set; }
        public string NameInitialsEng { get; set; }
        public Nullable<bool> NameInitialsEngNotEdit { get; set; }
        public string Title { get; set; }
        public string TitleEng { get; set; }
        public string Account { get; set; }
        public string SttAccount { get; set; }
        public Nullable<System.DateTime> SttAccountDateCreated { get; set; }
        public string SttPwd { get; set; }
        public Nullable<int> DegreeId { get; set; }
        public Nullable<int> Degree2Id { get; set; }
        public Nullable<int> RankId { get; set; }
        public Nullable<int> Rank2Id { get; set; }
        public Nullable<int> RankHonoraryId { get; set; }
        public Nullable<int> RankHonorary2Id { get; set; }
        public Nullable<int> RankStateId { get; set; }
        public Nullable<int> RankState2Id { get; set; }
        public Nullable<int> ActivityAreaId { get; set; }
        public Nullable<bool> IsSPbGUGraduate { get; set; }
        public Nullable<int> SPbGUGraduateYear { get; set; }
        public Nullable<bool> AlumniAssociation { get; set; }
        public Nullable<bool> IsGAK { get; set; }
        public Nullable<bool> IsGAKChairman { get; set; }
        public Nullable<bool> IsGAK2016 { get; set; }
        public Nullable<bool> IsGAKChairman2016 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobiles { get; set; }
        public string WebSite { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string CodeKLADR { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsPersonDataAgreed { get; set; }
        public Nullable<bool> IsPersonDataChecked { get; set; }
        public string Author { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.Guid rowguid { get; set; }
        public Nullable<bool> SexMale { get; set; }
        public Nullable<System.Guid> SapId { get; set; }
    
        public virtual ActivityArea ActivityArea { get; set; }
        public virtual Country Country { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual Degree Degree1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_LP_Person> GAK_LP_Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_MemberPP> GAK_MemberPP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_MemberPP_archive> GAK_MemberPP_archive { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_MemberPP_log> GAK_MemberPP_log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_Number> GAK_Number { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_Number_archive> GAK_Number_archive { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_Number_log> GAK_Number_log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPerson> OrganizationPersons { get; set; }
        public virtual PartnerPersonPrefix PartnerPersonPrefix { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual Rank Rank1 { get; set; }
        public virtual RankHonorary_ RankHonorary_ { get; set; }
        public virtual RankHonorary_ RankHonorary_1 { get; set; }
        public virtual RankState RankState { get; set; }
        public virtual RankState RankState1 { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerPersonActivityArea> PartnerPersonActivityAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerPersonOrganizationNotAvailableInGAK_Log> PartnerPersonOrganizationNotAvailableInGAK_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOP_Members> SOP_Members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_Themes> VKR_Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_Themes> VKR_Themes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_ThemesStudentOrder_NR_Review> VKR_ThemesStudentOrder_NR_Review { get; set; }
    }
}
