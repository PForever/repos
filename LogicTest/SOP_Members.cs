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
    
    public partial class SOP_Members
    {
        public int Id { get; set; }
        public int SOPId { get; set; }
        public Nullable<System.Guid> SAPId { get; set; }
        public Nullable<int> PartnerPersonId { get; set; }
        public Nullable<int> PositionId { get; set; }
        public string Author { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual PartnerPerson PartnerPerson { get; set; }
        public virtual SAP_ALL_PERS SAP_ALL_PERS { get; set; }
        public virtual SOP SOP { get; set; }
        public virtual SOP_Position SOP_Position { get; set; }
    }
}
