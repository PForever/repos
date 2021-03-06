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
    
    public partial class LicenseProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LicenseProgram()
        {
            this.GAK_LP_Person = new HashSet<GAK_LP_Person>();
            this.ObrazPrograms = new HashSet<ObrazProgram>();
            this.ObrazProgramInYears = new HashSet<ObrazProgramInYear>();
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public string Acronym { get; set; }
        public string Code { get; set; }
        public Nullable<int> LicenseId { get; set; }
        public int StudyLevelId { get; set; }
        public int ProgramTypeId { get; set; }
        public Nullable<int> QualificationId { get; set; }
        public int AggregateGroupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAK_LP_Person> GAK_LP_Person { get; set; }
        public virtual License License { get; set; }
        public virtual ProgramType ProgramType { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual StudyLevel StudyLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObrazProgram> ObrazPrograms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObrazProgramInYear> ObrazProgramInYears { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
