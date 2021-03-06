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
    
    public partial class OrganizationSubdivision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationSubdivision()
        {
            this.OrganizationPersons = new HashSet<OrganizationPerson>();
            this.PracticeOrganizationRoutes = new HashSet<PracticeOrganizationRoute>();
        }
    
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPerson> OrganizationPersons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeOrganizationRoute> PracticeOrganizationRoutes { get; set; }
    }
}
