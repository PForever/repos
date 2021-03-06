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
    
    public partial class Place
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Place()
        {
            this.PracticeOrganizationRoutes = new HashSet<PracticeOrganizationRoute>();
            this.RoutePlaces = new HashSet<RoutePlace>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string NameEng { get; set; }
        public string ShortNameEng { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string CodeKLADR { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeOrganizationRoute> PracticeOrganizationRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoutePlace> RoutePlaces { get; set; }
    }
}
