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
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.Grants = new HashSet<Grant>();
            this.OrgAddresses = new HashSet<OrgAddress>();
            this.OrganizationActivityAreas = new HashSet<OrganizationActivityArea>();
            this.OrganizationActivityAreaProfessionals = new HashSet<OrganizationActivityAreaProfessional>();
            this.OrganizationContacts = new HashSet<OrganizationContact>();
            this.OrganizationDogovors = new HashSet<OrganizationDogovor>();
            this.OrganizationMails = new HashSet<OrganizationMail>();
            this.OrganizationNames = new HashSet<OrganizationName>();
            this.OrganizationOkveds = new HashSet<OrganizationOkved>();
            this.OrganizationPersons = new HashSet<OrganizationPerson>();
            this.OrganizationSubdivisions = new HashSet<OrganizationSubdivision>();
            this.PartnerPersonOrganizationNotAvailableInGAK_Log = new HashSet<PartnerPersonOrganizationNotAvailableInGAK_Log>();
            this.PracticeOrganizationRoutes = new HashSet<PracticeOrganizationRoute>();
            this.VKR_Themes = new HashSet<VKR_Themes>();
            this.VKR_ThemesStudentOrder = new HashSet<VKR_ThemesStudentOrder>();
            this.VKR_ThemesStudentOrder1 = new HashSet<VKR_ThemesStudentOrder>();
            this.VKR_ThemesStudentOrder2 = new HashSet<VKR_ThemesStudentOrder>();
            this.VKR_ThemesStudentOrder3 = new HashSet<VKR_ThemesStudentOrder>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string ShortName { get; set; }
        public string NameEng { get; set; }
        public string ShortNameEng { get; set; }
        public Nullable<System.DateTime> NameDate { get; set; }
        public string Source { get; set; }
        public Nullable<bool> EngSourceOfficial { get; set; }
        public Nullable<int> OrganizationEnglishSourceId { get; set; }
        public Nullable<bool> SourceCharter { get; set; }
        public Nullable<bool> SourceEGRUL { get; set; }
        public Nullable<bool> SourceSite { get; set; }
        public Nullable<bool> CardChecked { get; set; }
        public Nullable<bool> IsActual { get; set; }
        public string Description { get; set; }
        public Nullable<bool> SPbGU { get; set; }
        public string OECD { get; set; }
        public string Okved { get; set; }
        public string OkvedDop { get; set; }
        public Nullable<int> OwnershipTypeId { get; set; }
        public Nullable<int> ActivityGoalId { get; set; }
        public Nullable<int> NationalAffiliationId { get; set; }
        public Nullable<int> ActivityAreaId { get; set; }
        public Nullable<int> ActivityAreaProfessionalId { get; set; }
        public string Contact { get; set; }
        public Nullable<bool> OrgBranchesOffices { get; set; }
        public Nullable<int> EGRULBranchNumber { get; set; }
        public string INN { get; set; }
        public string OGRN { get; set; }
        public Nullable<System.DateTime> OGRNDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobiles { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string CodeKLADR { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.Guid rowguid { get; set; }
        public Nullable<int> RealCountryId { get; set; }
        public Nullable<int> RealRegionId { get; set; }
        public string RealCodeKLADR { get; set; }
        public string RealCode { get; set; }
        public string RealCity { get; set; }
        public string RealStreet { get; set; }
        public string RealHouse { get; set; }
        public string RealApartment { get; set; }
        public string RealAddress { get; set; }
    
        public virtual ActivityArea ActivityArea { get; set; }
        public virtual ActivityAreaProfessional ActivityAreaProfessional { get; set; }
        public virtual ActivityGoal ActivityGoal { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grant> Grants { get; set; }
        public virtual NationalAffiliation NationalAffiliation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgAddress> OrgAddresses { get; set; }
        public virtual OwnershipType OwnershipType { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationActivityArea> OrganizationActivityAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationActivityAreaProfessional> OrganizationActivityAreaProfessionals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationDogovor> OrganizationDogovors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationMail> OrganizationMails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationName> OrganizationNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationOkved> OrganizationOkveds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPerson> OrganizationPersons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationSubdivision> OrganizationSubdivisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerPersonOrganizationNotAvailableInGAK_Log> PartnerPersonOrganizationNotAvailableInGAK_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeOrganizationRoute> PracticeOrganizationRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_Themes> VKR_Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_ThemesStudentOrder> VKR_ThemesStudentOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_ThemesStudentOrder> VKR_ThemesStudentOrder1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_ThemesStudentOrder> VKR_ThemesStudentOrder2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VKR_ThemesStudentOrder> VKR_ThemesStudentOrder3 { get; set; }
    }
}
