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
    
    public partial class OrganizationName
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string ShortName { get; set; }
        public string NameEng { get; set; }
        public string ShortNameEng { get; set; }
        public Nullable<System.DateTime> NameDate { get; set; }
        public string INN { get; set; }
        public string OGRN { get; set; }
        public Nullable<System.DateTime> OGRNDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Organization Organization { get; set; }
    }
}