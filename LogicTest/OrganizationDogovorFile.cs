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
    
    public partial class OrganizationDogovorFile
    {
        public System.Guid FileId { get; set; }
        public int OrganizationDogovorId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public System.DateTime DateLoad { get; set; }
        public double FileSizeKBytes { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual OrganizationDogovor OrganizationDogovor { get; set; }
    }
}
