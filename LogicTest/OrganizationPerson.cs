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
    
    public partial class OrganizationPerson
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int PartnerPersonId { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> OrganizationSubdivisionId { get; set; }
        public string Position { get; set; }
        public string PositionEng { get; set; }
        public Nullable<int> Position2Id { get; set; }
        public Nullable<int> OrganizationSubdivision2Id { get; set; }
        public string Position2 { get; set; }
        public string PositionEng2 { get; set; }
        public Nullable<int> Sorting { get; set; }
        public Nullable<bool> NotUseInDocs { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual OrganizationSubdivision OrganizationSubdivision { get; set; }
        public virtual PartnerPerson PartnerPerson { get; set; }
        public virtual Position Position1 { get; set; }
    }
}
