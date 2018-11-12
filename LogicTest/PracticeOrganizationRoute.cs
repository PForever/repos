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
    
    public partial class PracticeOrganizationRoute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PracticeOrganizationRoute()
        {
            this.PracticeStudentOrganizationRoutes = new HashSet<PracticeStudentOrganizationRoute>();
        }
    
        public int Id { get; set; }
        public System.Guid PracticeId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public Nullable<int> OrgSubdivisionId { get; set; }
        public Nullable<int> RouteId { get; set; }
        public Nullable<int> PlaceId { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual OrganizationSubdivision OrganizationSubdivision { get; set; }
        public virtual Place Place { get; set; }
        public virtual Practice Practice { get; set; }
        public virtual Route Route { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeStudentOrganizationRoute> PracticeStudentOrganizationRoutes { get; set; }
    }
}