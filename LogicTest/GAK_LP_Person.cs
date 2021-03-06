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
    
    public partial class GAK_LP_Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAK_LP_Person()
        {
            this.GAK_Number = new HashSet<GAK_Number>();
        }
    
        public int Id { get; set; }
        public int Year { get; set; }
        public int LicenseProgramId { get; set; }
        public int PartnerPersonId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public bool OrderDop { get; set; }
        public string PersonNumberInOrder { get; set; }
        public bool IsNotActive { get; set; }
        public string AuthorUpdated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> StudyLevelNum { get; set; }
        public Nullable<int> LicenseProgramNum { get; set; }
        public Nullable<int> PersonNum { get; set; }
        public bool InOrder { get; set; }
    
        public virtual LicenseProgram LicenseProgram { get; set; }
        public virtual PartnerPerson PartnerPerson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_Number> GAK_Number { get; set; }
    }
}
