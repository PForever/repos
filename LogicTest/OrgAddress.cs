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
    
    public partial class OrgAddress
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public bool IsDefault { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public string House { get; set; }
        public int RegionId { get; set; }
        public string Street { get; set; }
        public string CodeKLADR { get; set; }
        public string PostCode { get; set; }
        public string Apartment { get; set; }
        public string Address { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Region Region { get; set; }
    }
}
