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
    
    public partial class OrganizationMail
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public bool Incoming { get; set; }
        public string RkNum { get; set; }
        public System.DateTime Date { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Organization Organization { get; set; }
    }
}
