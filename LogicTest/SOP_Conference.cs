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
    
    public partial class SOP_Conference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOP_Conference()
        {
            this.SOP_Conference_Questions = new HashSet<SOP_Conference_Questions>();
            this.SOP_ConferenceMembers = new HashSet<SOP_ConferenceMembers>();
        }
    
        public int Id { get; set; }
        public int SOPId { get; set; }
        public string Number { get; set; }
        public System.DateTime Date { get; set; }
        public string Address { get; set; }
        public string Theme { get; set; }
        public Nullable<System.Guid> ProtocolFileId { get; set; }
        public string AuthorCreate { get; set; }
        public Nullable<System.DateTime> TimestampCreate { get; set; }
        public string AuthorUpdate { get; set; }
        public Nullable<System.DateTime> TimestampUpdate { get; set; }
        public string ProtocolFileName { get; set; }
        public string ProtocolFileAuthor { get; set; }
        public Nullable<System.DateTime> ProtocolFileTimestamp { get; set; }
    
        public virtual SOP SOP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOP_Conference_Questions> SOP_Conference_Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOP_ConferenceMembers> SOP_ConferenceMembers { get; set; }
    }
}
