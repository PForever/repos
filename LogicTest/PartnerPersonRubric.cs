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
    
    public partial class PartnerPersonRubric
    {
        public int Id { get; set; }
        public Nullable<int> PartnerPersonId { get; set; }
        public int RubricId { get; set; }
        public Nullable<int> FacultyId { get; set; }
        public Nullable<int> StudyLevelId { get; set; }
        public Nullable<int> LicenseProgramId { get; set; }
        public Nullable<int> ObrazProgramId { get; set; }
        public string Author { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
