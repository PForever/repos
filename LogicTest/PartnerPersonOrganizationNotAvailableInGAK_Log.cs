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
    
    public partial class PartnerPersonOrganizationNotAvailableInGAK_Log
    {
        public int OrdId { get; set; }
        public int Id { get; set; }
        public Nullable<int> PartnerPersonId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public Nullable<System.DateTime> DateBegin { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Action { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual PartnerPerson PartnerPerson { get; set; }
    }
}