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
    
    public partial class PracticeStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PracticeStudent()
        {
            this.PracticeStudentOrganizationRoutes = new HashSet<PracticeStudentOrganizationRoute>();
        }
    
        public int Id { get; set; }
        public System.Guid PracticeId { get; set; }
        public System.Guid StudentOid { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Practice Practice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PracticeStudentOrganizationRoute> PracticeStudentOrganizationRoutes { get; set; }
        public virtual Student Student { get; set; }
    }
}
